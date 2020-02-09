using stock_div.Common;
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
    public partial class Select_Form : Form
    {
        private Users user;
        public Select_Form()
        {
            InitializeComponent();
            Utilities.PreviousPage = this;
            this.user = Utilities.User;
        }

        private void Select_Form_Load(object sender, EventArgs e)
        {
            if (Utilities.User != null)
            {
                this.lb_name.Text = this.user.LastName;
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(Messages.HISTORY_CONNECT_MSG, " ", 2000);
            History_Form historyForm = new History_Form();
            historyForm.Show();
            this.Hide();
        }

        private void btn_sign_out_Click(object sender, EventArgs e)
        {
            Utilities.PreviousPage = null;
            this.Hide();
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
        }

        public void setForm()
        {

        }


    }
}
