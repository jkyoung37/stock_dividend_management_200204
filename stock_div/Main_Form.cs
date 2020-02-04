using stock_div.Models;
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

namespace stock_div
{
    public partial class Main_Form : Form
    {

        private StockDbContext con;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            con = new StockDbContext();

            var query = from c in con.Stocks
                        where c.User == "test@gmail.com"
                        select new DataBinding { Symbol = c.Symbol, Shares = c.Shares, CreateAt = c.CreateAt, Price = c.Price };

            this.dataGridView1.DataSource = query.ToList();
            this.setRowNumber(this.dataGridView1);
            this.setDataGridViewOption(this.dataGridView1);
        }


        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void setDataGridViewOption(DataGridView dgv)
        {
            //Not allow size modify
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //Column 
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //Header
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Set Font
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            //Show Dollar
            dgv.Columns[1].DefaultCellStyle.Format = "$0.00";
        }
        private class DataBinding
        {
            public string Symbol { get; set; }
            public string Shares { get; set; }
            public DateTime CreateAt { get; set; }
            public Decimal Price { get; set; }
        }
    }
}
