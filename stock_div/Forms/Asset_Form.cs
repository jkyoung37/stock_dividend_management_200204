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

namespace stock_div.Forms
{
    public partial class Asset_Form : Form
    {
        private StockDbContext con;
        private List<NetAsset> stockResult;
        private List<NetAsset> dividendResult;
        private Decimal stockTotal;
        private Decimal dividendTotal;
        private Decimal yen = 109.78M;
        private Decimal won = 10.78M;

        public Asset_Form()
        {
            InitializeComponent();
        }

        private void Asset_Form_Load(object sender, EventArgs e)
        {
            this.con = new StockDbContext();
            this.stockResult = getStockList();
            this.dividendResult = getDividendList();
            this.stockTotal = getTotal(stockResult);
            this.dividendTotal = getTotal(dividendResult);
            setChart(this.stockResult, chart1);
            setChart(this.dividendResult, chart2);
            setTotalLabel(lb_totalStocks, stockTotal);
            setTotalLabel(lb_totalDividend, dividendTotal);
            setTotalMoney(this.yen, this.won);
            tb_yen.Text = this.yen.ToString();
            tb_won.Text = this.won.ToString();
        }

        private void setTotalMoney(Decimal inputYen, Decimal inputWon)
        {
            lb_div_yen.Text = string.Format("¥{0:#,###}", Decimal.Round(this.dividendTotal * inputYen, 0));
            lb_stock_yen.Text = string.Format("¥{0:#,###}", Decimal.Round(this.stockTotal * inputYen, 0));

            lb_div_won.Text = string.Format("₩{0:#,###}", Decimal.Round(this.dividendTotal * inputYen * inputWon, 0));
            lb_stock_won.Text = string.Format("₩{0:#,###}", Decimal.Round(this.stockTotal * inputYen * inputWon, 0));
        }

        private void setChart(List<NetAsset> result, Chart chart1)
        {
            List<String> x1 = new List<string>();
            List<Decimal> y1 = new List<Decimal>();

            if (result != null)
            {
                foreach (NetAsset item in result)
                {
                    if (item.x != null)
                    {
                        x1.Add(item.x);
                        y1.Add(item.y);
                    }
                }
                chart1.Series[0].Points.DataBindXY(x1, y1);
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            }
        }

        private void setTotalLabel(BunifuCustomLabel lb, Decimal dollar)
        {
            lb.Text = "Total" + string.Format("${0:N2}", Decimal.Round(dollar, 2));
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

        private List<NetAsset> getStockList()
        {
            string query = @"SELECT STOCK.YEAR AS X, SUM(AMT) AS Y FROM ( SELECT TO_CHAR(CREATE_AT,'YYYY/MM') AS YEAR, SUM(PRICE*SHARES) AS AMT FROM ""public"".""Stocks"" GROUP BY CREATE_AT ) STOCK GROUP BY ROLLUP (STOCK.YEAR) ORDER BY STOCK.YEAR DESC;";
            return con.Database.SqlQuery<NetAsset>(query).ToList();
        }

        private List<NetAsset> getDividendList()
        {
            string query = @"SELECT Dividend.YEAR AS X, SUM(AMT) AS Y FROM( SELECT TO_CHAR(CREATE_AT,'YYYY-MM') AS YEAR, SUM(price) AS AMT FROM ""public"".""Dividend"" GROUP BY CREATE_AT ) Dividend GROUP BY ROLLUP (Dividend.YEAR) ORDER BY Dividend.YEAR DESC;";
            return con.Database.SqlQuery<NetAsset>(query).ToList();
        }

        private void btn_rate_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal intputYen = Decimal.Parse(tb_yen.Text);
                Decimal inputWon = Decimal.Parse(tb_won.Text);
                setTotalMoney(intputYen, inputWon);
            }
            catch (FormatException formatE)
            {
                MessageBox.Show(Messages.NETASSET_NUM_NO_MSG);
            }
        }
    }
}
