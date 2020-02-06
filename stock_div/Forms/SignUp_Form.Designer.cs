namespace stock_div.Forms
{
    partial class SignUp_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tb_email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_lastName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_firstName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_reg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_firstName);
            this.panel1.Controls.Add(this.tb_lastName);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 279);
            this.panel1.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tb_password.BorderColor = System.Drawing.Color.DarkRed;
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(52, 222);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(306, 38);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "1234";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tb_email.BorderColor = System.Drawing.Color.DarkRed;
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(52, 148);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(306, 38);
            this.tb_email.TabIndex = 2;
            this.tb_email.Text = "test@gmail.com";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 200);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 126);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Email";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(157, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Sign Up";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(48, 51);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(95, 19);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Last Name";
            // 
            // tb_lastName
            // 
            this.tb_lastName.AcceptsReturn = true;
            this.tb_lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tb_lastName.BorderColor = System.Drawing.Color.DarkRed;
            this.tb_lastName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_lastName.ForeColor = System.Drawing.Color.White;
            this.tb_lastName.Location = new System.Drawing.Point(52, 73);
            this.tb_lastName.Multiline = true;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(145, 39);
            this.tb_lastName.TabIndex = 2;
            this.tb_lastName.Text = "test_last";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(209, 51);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "First Name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tb_firstName.BorderColor = System.Drawing.Color.DarkRed;
            this.tb_firstName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_firstName.ForeColor = System.Drawing.Color.White;
            this.tb_firstName.Location = new System.Drawing.Point(213, 73);
            this.tb_firstName.Multiline = true;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(145, 39);
            this.tb_firstName.TabIndex = 2;
            this.tb_firstName.Text = "test_first";
            // 
            // btn_reg
            // 
            this.btn_reg.ActiveBorderThickness = 3;
            this.btn_reg.ActiveCornerRadius = 1;
            this.btn_reg.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_reg.ActiveForecolor = System.Drawing.Color.White;
            this.btn_reg.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reg.BackgroundImage")));
            this.btn_reg.ButtonText = "Register ";
            this.btn_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_reg.IdleBorderThickness = 1;
            this.btn_reg.IdleCornerRadius = 1;
            this.btn_reg.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_reg.IdleForecolor = System.Drawing.SystemColors.Window;
            this.btn_reg.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_reg.Location = new System.Drawing.Point(64, 314);
            this.btn_reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(306, 54);
            this.btn_reg.TabIndex = 4;
            this.btn_reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveBorderThickness = 3;
            this.btn_back.ActiveCornerRadius = 1;
            this.btn_back.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_back.ActiveForecolor = System.Drawing.Color.LightGray;
            this.btn_back.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.ButtonText = "↩";
            this.btn_back.CausesValidation = false;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_back.IdleBorderThickness = 1;
            this.btn_back.IdleCornerRadius = 1;
            this.btn_back.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_back.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btn_back.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(411, 4);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(38, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(450, 395);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_password;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_firstName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_lastName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_reg;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_back;
    }
}