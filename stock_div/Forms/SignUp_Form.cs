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
    public partial class SignUp_Form : Form
    {
        private StockDbContext con;

        public SignUp_Form(StockDbContext con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage.Show();
            this.Close();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(Messages.REG_MSG, "登録", 2000);

            string fistName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            string password = tb_password.Text;
            string email = tb_email.Text;

            Users newUser = new Users(email, password, fistName, lastName, null);
            con.Users.Add(newUser);
            con.SaveChanges();
            MessageBox.Show(Messages.REG_OK_MSG);

            Utilities.PreviousPage.Show();
            this.Close();
        }
    }
}
