using stock_div.Common;
using stock_div.Models;
using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_div.Forms
{
    public partial class Add_Form : Form
    {
        private StockDbContext con;

        public Add_Form()
        {
            InitializeComponent();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {
            con = new StockDbContext();
            getStockList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int rowcnt = dataGridView1.RowCount;
            if(rowcnt == 1)
            {
                MessageBox.Show(Messages.REG_EMPTY_MSG);
                return;
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value == null || item.Cells[1].Value == null || item.Cells[1].Value == null)
                {
                    break;
                }

                String symbol = item.Cells[0].Value.ToString();
                int shares = Int16.Parse(item.Cells[1].Value.ToString());
                Decimal price = Decimal.Parse(item.Cells[1].Value.ToString());
                con.Stocks.Add(new Stocks(symbol, shares, price));
            }

            con.SaveChanges();
            MessageBox.Show(Messages.REG_OK_MSG);
            dataGridView1.Rows.Clear();
            getStockList();
        }

        private void getStockList()
        {
            var query = from c in con.Stocks
                        where c.User == Utilities.User.Email && c.DeleteFlag != "1"
                        orderby c.CreateAt descending
                        select new AddDataBinding { Symbol = c.Symbol, Shares = c.Shares, CreateAt = c.CreateAt, Price = c.Price };

            this.dataGridView2.DataSource = query.ToList();
            Utilities.setRowNumber(this.dataGridView2);
            Utilities.setDataGridViewOption(this.dataGridView2);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
