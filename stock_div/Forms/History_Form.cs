using stock_div.Common;
using stock_div.Models;
using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_div.Forms
{
    public partial class History_Form : Form
    {

        private StockDbContext con;

        public History_Form()
        {
            InitializeComponent();
        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            con = new StockDbContext();

            var query = from c in con.Stocks
                        where c.User == Utilities.User.Email
                        orderby c.CreateAt descending
                        select new DataBinding { Symbol = c.Symbol, Shares = c.Shares, CreateAt = c.CreateAt, Price = c.Price };

            con.Database.Log = Console.WriteLine;

            this.dataGridView1.DataSource = query.ToList();
            Utilities.setRowNumber(this.dataGridView1);
            Utilities.setDataGridViewOption(this.dataGridView1);
            this.lb_updatetime.Text = "Update : " + DateTime.Now;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
