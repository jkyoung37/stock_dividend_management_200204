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
    public partial class Delete_Form : Form
    {
        private StockDbContext con;
        private List<DataBinding> stockLists;
        public Delete_Form()
        {
            InitializeComponent();
        }

        private void Delete_Form_Load(object sender, EventArgs e)
        {
            con = new StockDbContext();
            getStockList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<int> idListsDelete = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string chk = (string)row.Cells[0].Value;

                if (chk.Equals("1"))
                {
                    int selectedId = Int32.Parse(row.Cells[1].Value.ToString());
                    idListsDelete.Add(selectedId);
                }
            }

            if (idListsDelete.Count > 0)
            {
                foreach (int id in idListsDelete)
                {
                    con.Stocks.Where(x => x.Id == id).ToList().ForEach(x => x.DeleteFlag = "1");
                }
                con.SaveChanges();
                MessageBox.Show(Messages.DEL_OK_MSG);
                getStockList();
            }
            else
            {
                MessageBox.Show(Messages.DEL_EMPTY_MSG);
            }
        }

        private void getStockList()
        {
            var query = from c in con.Stocks
                        where c.User == Utilities.User.Email && c.DeleteFlag != "1"
                        orderby c.CreateAt descending
                        select new DataBinding { Select = "0", Id = c.Id, Symbol = c.Symbol, Shares = c.Shares, CreateAt = c.CreateAt, Price = c.Price };

            this.dataGridView1.DataSource = query.ToList();
            this.stockLists = query.ToList();
            Utilities.setDataGridViewOption(this.dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                if (dataGridView1.CurrentCell.Value.Equals("0"))
                {
                    dataGridView1.CurrentCell.Value = "1";
                }
                else
                {
                    dataGridView1.CurrentCell.Value = "0";
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
