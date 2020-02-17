using Bunifu.Framework.UI;
using stock_div.Common;
using stock_div.Models;
using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace stock_div.Forms
{
    public partial class Asset_Form : Form
    {
        private StockDbContext con;
        private List<NetAsset> stockResult;
        private List<NetAsset> symbolResult;
        private Decimal stockTotal;
        private Decimal dividendTotal;
        private Decimal yen = 110M;
        private Decimal usd = 1200M;

        public Asset_Form()
        {
            InitializeComponent();
        }

        private void Asset_Form_Load(object sender, EventArgs e)
        {
            this.con = new StockDbContext();
            this.stockResult = getStockList();
            this.symbolResult = getSymbolList();
            this.stockTotal = getTotal(stockResult);
            // this.dividendTotal = getTotal(dividendResult);

            setRateDefault();
            setTotalMoney(this.yen, this.usd);

            setDgv(dataGridView1, this.symbolResult);
            setDgv(dataGridView2, this.stockResult);

            chart1.DataSource = this.symbolResult;
            chart2.DataSource = this.symbolResult;
            chart2.Series[0].Label = "#PERCENT{P2}";
            chart2.Series[0].LegendText = "#VALX";
            chart2.Series[0]["PieLabelStyle"] = "Outside";
            chart2.Series[0].BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            chart2.Series[0].BorderWidth = 1;


            Utilities.setRowNumber(dataGridView1);
            Utilities.setRowNumber(dataGridView2);
        }

        private void setDgv(DataGridView dgv, List<NetAsset> data)
        {
            dgv.DataSource = data;
            if (dgv.Columns["y"] != null)
            {
                dgv.Columns[2].DefaultCellStyle.Format = "$0.00";
            }
            if (dgv.Columns["y1"] != null)
            {
                dgv.Columns["y1"].DefaultCellStyle.Format = "$0.00";
                dgv.Columns[2].Visible = false;
            }


        }
        private void setRateDefault()
        {
            Decimal usdRate = Utilities.setRate("USD");
            Decimal jpyRate = Utilities.setRate("JPY");

            if (usdRate != 0)
            {
                this.usd = usdRate;
            }

            if (jpyRate != 0)
            {
                this.yen = jpyRate / 100;
            }
        }

        private void setTotalMoney(Decimal inputYen, Decimal inputUsd)
        {
            //lb_div_yen.Text = string.Format("¥{0:#,###}", Decimal.Round(inputUsd * this.dividendTotal / inputYen, 0));
            lb_stock_yen.Text = string.Format("¥{0:#,###}", Decimal.Round(inputUsd * this.stockTotal / inputYen, 0));

            //lb_div_won.Text = string.Format("₩{0:#,###}", Decimal.Round(this.dividendTotal * inputUsd, 0));
            lb_stock_won.Text = string.Format("₩{0:#,###}", Decimal.Round(this.stockTotal * inputUsd, 0));
        }

        private Decimal getTotal(List<NetAsset> result)
        {
            if (result != null)
            {
                if (result[0].x == null)
                {
                    return result[0].y;
                }
            }
            return 0;
        }

        private List<NetAsset> getSymbolList()
        {
            string query = @"SELECT symbol AS X, sum(shares) AS Y, sum(shares*price) AS Z FROM ""public"".""Stocks"" WHERE delete_flag !='1' AND Users = @p0 Group by symbol ORDER BY X";
            return con.Database.SqlQuery<NetAsset>(query, Utilities.User.Email).ToList();
        }

        private List<NetAsset> getStockList()
        {
            string query = @"SELECT STOCK.YEAR AS X, SUM(AMT) AS Y FROM ( SELECT TO_CHAR(CREATE_AT,'YYYY/MM') AS YEAR, SUM(PRICE*SHARES) AS AMT FROM ""public"".""Stocks"" WHERE Users = @p0 GROUP BY CREATE_AT ) STOCK GROUP BY ROLLUP (STOCK.YEAR) ORDER BY STOCK.YEAR DESC;";
            return con.Database.SqlQuery<NetAsset>(query, Utilities.User.Email).ToList();
        }

        private List<NetAsset> getDividendList()
        {
            string query = @"SELECT Dividend.YEAR AS X, SUM(AMT) AS Y FROM( SELECT TO_CHAR(CREATE_AT,'YYYY-MM') AS YEAR, SUM(price) AS AMT FROM ""public"".""Dividend"" WHERE Users = @p0 GROUP BY CREATE_AT ) Dividend GROUP BY ROLLUP (Dividend.YEAR) ORDER BY Dividend.YEAR DESC;";
            return con.Database.SqlQuery<NetAsset>(query, Utilities.User.Email).ToList();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
