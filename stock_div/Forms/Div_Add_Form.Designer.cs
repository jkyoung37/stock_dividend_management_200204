namespace stock_div.Forms
{
    partial class Div_Add_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Div_Add_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lb_updatetime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.DataPropertyName = "create_at";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Meiryo", 7.8F);
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.HeaderText = "PAYMENT DATE";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 170;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Meiryo", 7.8F);
            dataGridViewCellStyle6.Format = "$C2";
            dataGridViewCellStyle6.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle6;
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 169;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 3;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Back";
            this.bunifuThinButton22.CausesValidation = false;
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(981, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(69, 32);
            this.bunifuThinButton22.TabIndex = 8;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btn_save
            // 
            this.btn_save.ActiveBorderThickness = 3;
            this.btn_save.ActiveCornerRadius = 1;
            this.btn_save.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_save.ActiveForecolor = System.Drawing.Color.LightGray;
            this.btn_save.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.ButtonText = "Save";
            this.btn_save.CausesValidation = false;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_save.IdleBorderThickness = 1;
            this.btn_save.IdleCornerRadius = 1;
            this.btn_save.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_save.IdleForecolor = System.Drawing.Color.White;
            this.btn_save.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(449, 446);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 42);
            this.btn_save.TabIndex = 8;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 3;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Clear";
            this.bunifuThinButton21.CausesValidation = false;
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(12, 446);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(87, 42);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_updatetime
            // 
            this.lb_updatetime.AutoSize = true;
            this.lb_updatetime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_updatetime.ForeColor = System.Drawing.Color.White;
            this.lb_updatetime.Location = new System.Drawing.Point(738, 26);
            this.lb_updatetime.Name = "lb_updatetime";
            this.lb_updatetime.Size = new System.Drawing.Size(125, 23);
            this.lb_updatetime.TabIndex = 10;
            this.lb_updatetime.Text = "Dividend List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date2,
            this.price2});
            this.dataGridView2.Location = new System.Drawing.Point(601, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(430, 387);
            this.dataGridView2.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(240, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(50, 23);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "ADD";
            // 
            // date2
            // 
            this.date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date2.DataPropertyName = "createat";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Meiryo", 7.8F);
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.date2.DefaultCellStyle = dataGridViewCellStyle7;
            this.date2.HeaderText = "PAYMENT DATE";
            this.date2.MinimumWidth = 6;
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            this.date2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date2.Width = 145;
            // 
            // price2
            // 
            this.price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price2.DataPropertyName = "price";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Meiryo", 7.8F);
            dataGridViewCellStyle8.Format = "C2";
            this.price2.DefaultCellStyle = dataGridViewCellStyle8;
            this.price2.HeaderText = "PRICE";
            this.price2.MinimumWidth = 6;
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            this.price2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price2.Width = 124;
            // 
            // Div_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1053, 492);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lb_updatetime);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Div_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Div_Add_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_save;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_updatetime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
    }
}