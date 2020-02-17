using stock_div.Common;
using stock_div.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
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
            DialogResult result = MessageBox.Show(Messages.CLOSE_MSG, "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(Messages.HISTORY_CONNECT_MSG, " ", 2000);
            Add_Form addForm = new Add_Form();
            addForm.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(Messages.HISTORY_CONNECT_MSG, " ", 2000);
            Delete_Form deleteForm = new Delete_Form();
            deleteForm.Show();
            this.Hide();
        }

        private void btn_asset_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(Messages.HISTORY_CONNECT_MSG, " ", 2000);
            Asset_Form assetForm = new Asset_Form();
            assetForm.Show();
            this.Hide();

        }
    }
}
