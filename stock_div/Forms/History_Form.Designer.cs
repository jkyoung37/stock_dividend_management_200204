namespace stock_div.Forms
{
    partial class History_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new stock_div.stockDataSet();
            this.stocksTableAdapter = new stock_div.stockDataSetTableAdapters.StocksTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lb_updatetime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.sharesDataGridViewTextBoxColumn,
            this.price,
            this.create_at});
            this.dataGridView1.DataSource = this.stocksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 648);
            this.dataGridView1.TabIndex = 1;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "stockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.btn_back.ButtonText = "Back";
            this.btn_back.CausesValidation = false;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_back.IdleBorderThickness = 1;
            this.btn_back.IdleCornerRadius = 1;
            this.btn_back.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_back.IdleForecolor = System.Drawing.Color.White;
            this.btn_back.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(932, -1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 42);
            this.btn_back.TabIndex = 6;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_updatetime
            // 
            this.lb_updatetime.AutoSize = true;
            this.lb_updatetime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lb_updatetime.ForeColor = System.Drawing.Color.White;
            this.lb_updatetime.Location = new System.Drawing.Point(402, 717);
            this.lb_updatetime.Name = "lb_updatetime";
            this.lb_updatetime.Size = new System.Drawing.Size(157, 18);
            this.lb_updatetime.TabIndex = 7;
            this.lb_updatetime.Text = "bunifuCustomLabel1";
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "symbol";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.symbolDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            this.symbolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.symbolDataGridViewTextBoxColumn.Width = 150;
            // 
            // sharesDataGridViewTextBoxColumn
            // 
            this.sharesDataGridViewTextBoxColumn.DataPropertyName = "shares";
            this.sharesDataGridViewTextBoxColumn.HeaderText = "Shares";
            this.sharesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sharesDataGridViewTextBoxColumn.Name = "sharesDataGridViewTextBoxColumn";
            this.sharesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sharesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sharesDataGridViewTextBoxColumn.Width = 200;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price Per Share($)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 160;
            // 
            // create_at
            // 
            this.create_at.DataPropertyName = "CreateAt";
            this.create_at.HeaderText = "Date";
            this.create_at.MinimumWidth = 6;
            this.create_at.Name = "create_at";
            this.create_at.ReadOnly = true;
            this.create_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.create_at.Width = 200;
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1017, 752);
            this.Controls.Add(this.lb_updatetime);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.History_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private stockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private stockDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_back;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_updatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_at;
    }
}