namespace stock_div
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sign = new System.Windows.Forms.Button();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_box
            // 
            this.pic_box.Image = ((System.Drawing.Image)(resources.GetObject("pic_box.Image")));
            this.pic_box.Location = new System.Drawing.Point(12, 12);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(413, 418);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sign);
            this.panel1.Controls.Add(this.tb_pw);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 194);
            this.panel1.TabIndex = 1;
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(245, 129);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(109, 34);
            this.btn_sign.TabIndex = 2;
            this.btn_sign.Text = "Sign In";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(189, 86);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(165, 22);
            this.tb_pw.TabIndex = 1;
            this.tb_pw.Text = "test";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(189, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(165, 22);
            this.tb_id.TabIndex = 1;
            this.tb_id.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(140, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_box);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

