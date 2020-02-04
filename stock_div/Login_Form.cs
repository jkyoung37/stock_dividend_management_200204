using Npgsql;
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

namespace stock_div
{
    public partial class Login_Form : Form
    {

        private StockDbContext con;

        public Login_Form()
        {
            con = new StockDbContext();
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            string userId = tb_id.Text;
            string userPw = tb_pw.Text;

            if (String.IsNullOrEmpty(userId))
            {
                MessageBox.Show(Messages.NON_ID_MSG);
                return;
            }

            if (String.IsNullOrEmpty(userPw))
            {
                MessageBox.Show(Messages.NON_PW_MSG);
                return;
            }

            int signCnt = con.Users.Where(x => x.Email == userId).Count();

            if (signCnt == 1)
            {
                MessageBox.Show(Messages.YES_SIGN_MSG);
            }
            else if (signCnt > 1)
            {
                MessageBox.Show(Messages.NO_SIGN_DUP_MSG);
                return;
            }
            else
            {
                MessageBox.Show(Messages.NO_SIGN_MSG);
                return;
            }


        }
    }
}
