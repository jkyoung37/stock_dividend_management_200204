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
    public partial class Div_Add_Form : Form
    {
        private StockDbContext con;

        public Div_Add_Form()
        {
            InitializeComponent();
        }

        private void Div_Add_Form_Load(object sender, EventArgs e)
        {
            con = new StockDbContext();
            getDivList();
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
                if (item.Cells[0].Value == null || item.Cells[1].Value == null)
                {
                    break;
                }

                DateTime date = DateTime.Parse(item.Cells[0].Value.ToString());
                Decimal price = Decimal.Parse(item.Cells[1].Value.ToString());
                con.Dividend.Add(new Dividend(price,date));
            }

            con.SaveChanges();
            MessageBox.Show(Messages.REG_OK_MSG);
            dataGridView1.Rows.Clear();
            getDivList();
        }

        private void getDivList()
        {
            var query = from c in con.Dividend
                        where c.User == Utilities.User.Email
                        orderby c.CreateAt descending
                        select new DividendDTO { Price = c.Price, CreateAt = c.CreateAt };

            this.dataGridView2.DataSource = query.ToList();
            this.dataGridView2.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd";
            Utilities.setRowNumber(this.dataGridView2);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
