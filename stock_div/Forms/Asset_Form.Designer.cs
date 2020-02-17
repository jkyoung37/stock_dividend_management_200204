namespace stock_div.Forms
{
    partial class Asset_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_updatetime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.create_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_stock_won = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_stock_yen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lb_updatetime
            // 
            this.lb_updatetime.AutoSize = true;
            this.lb_updatetime.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_updatetime.ForeColor = System.Drawing.Color.White;
            this.lb_updatetime.Location = new System.Drawing.Point(616, 21);
            this.lb_updatetime.Name = "lb_updatetime";
            this.lb_updatetime.Size = new System.Drawing.Size(135, 28);
            this.lb_updatetime.TabIndex = 8;
            this.lb_updatetime.Text = "Total Asset";
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
            this.btn_back.Location = new System.Drawing.Point(1307, -6);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 42);
            this.btn_back.TabIndex = 9;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.create_at,
            this.y1});
            this.dataGridView2.Location = new System.Drawing.Point(44, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(607, 362);
            this.dataGridView2.TabIndex = 10;
            // 
            // create_at
            // 
            this.create_at.DataPropertyName = "x";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo", 7.8F);
            this.create_at.DefaultCellStyle = dataGridViewCellStyle3;
            this.create_at.HeaderText = "DATE";
            this.create_at.MinimumWidth = 6;
            this.create_at.Name = "create_at";
            this.create_at.ReadOnly = true;
            this.create_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.create_at.Width = 200;
            // 
            // y1
            // 
            this.y1.DataPropertyName = "y";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Meiryo", 7.8F);
            this.y1.DefaultCellStyle = dataGridViewCellStyle4;
            this.y1.HeaderText = "ASSET";
            this.y1.MinimumWidth = 6;
            this.y1.Name = "y1";
            this.y1.ReadOnly = true;
            this.y1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y1.Width = 185;
            // 
            // lb_stock_won
            // 
            this.lb_stock_won.AutoSize = true;
            this.lb_stock_won.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_stock_won.ForeColor = System.Drawing.Color.White;
            this.lb_stock_won.Location = new System.Drawing.Point(926, 21);
            this.lb_stock_won.Name = "lb_stock_won";
            this.lb_stock_won.Size = new System.Drawing.Size(119, 28);
            this.lb_stock_won.TabIndex = 8;
            this.lb_stock_won.Text = "₩202.405";
            // 
            // lb_stock_yen
            // 
            this.lb_stock_yen.AutoSize = true;
            this.lb_stock_yen.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_stock_yen.ForeColor = System.Drawing.Color.White;
            this.lb_stock_yen.Location = new System.Drawing.Point(294, 21);
            this.lb_stock_yen.Name = "lb_stock_yen";
            this.lb_stock_yen.Size = new System.Drawing.Size(110, 28);
            this.lb_stock_yen.TabIndex = 8;
            this.lb_stock_yen.Text = "¥202.405";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.y,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(709, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 362);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "x";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo", 7.8F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "SYMBOL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // y
            // 
            this.y.DataPropertyName = "y";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 7.8F);
            this.y.DefaultCellStyle = dataGridViewCellStyle2;
            this.y.HeaderText = "SHARES";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "z";
            this.price.HeaderText = "ASSET";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(43, 449);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.LabelFormat = "C2";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "x";
            series2.YValueMembers = "z";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(608, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Meiryo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(709, 449);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "x";
            series1.YValueMembers = "z";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(606, 300);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart1";
            // 
            // Asset_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1388, 777);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_stock_won);
            this.Controls.Add(this.lb_stock_yen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_updatetime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asset_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset_Form";
            this.Load += new System.EventHandler(this.Asset_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_updatetime;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_back;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_stock_yen;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_stock_won;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}