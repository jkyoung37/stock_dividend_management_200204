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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_updatetime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_totalStocks = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_totalDividend = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_div_yen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_stock_yen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_div_won = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_stock_won = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_yen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_won = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_rate = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(24, 486);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.LabelBorderWidth = 5;
            series4.LabelForeColor = System.Drawing.Color.Red;
            series4.LabelFormat = "$0.00";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1581, 383);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(24, 51);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.LabelBorderWidth = 5;
            series3.LabelForeColor = System.Drawing.Color.Red;
            series3.LabelFormat = "$0.00";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1581, 383);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // lb_updatetime
            // 
            this.lb_updatetime.AutoSize = true;
            this.lb_updatetime.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_updatetime.ForeColor = System.Drawing.Color.White;
            this.lb_updatetime.Location = new System.Drawing.Point(780, 450);
            this.lb_updatetime.Name = "lb_updatetime";
            this.lb_updatetime.Size = new System.Drawing.Size(75, 28);
            this.lb_updatetime.TabIndex = 8;
            this.lb_updatetime.Text = "Stock";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(760, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 28);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Dividend";
            // 
            // lb_totalStocks
            // 
            this.lb_totalStocks.AutoSize = true;
            this.lb_totalStocks.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_totalStocks.ForeColor = System.Drawing.Color.White;
            this.lb_totalStocks.Location = new System.Drawing.Point(19, 450);
            this.lb_totalStocks.Name = "lb_totalStocks";
            this.lb_totalStocks.Size = new System.Drawing.Size(185, 28);
            this.lb_totalStocks.TabIndex = 8;
            this.lb_totalStocks.Text = "Total : $202.405";
            // 
            // lb_totalDividend
            // 
            this.lb_totalDividend.AutoSize = true;
            this.lb_totalDividend.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_totalDividend.ForeColor = System.Drawing.Color.White;
            this.lb_totalDividend.Location = new System.Drawing.Point(19, 16);
            this.lb_totalDividend.Name = "lb_totalDividend";
            this.lb_totalDividend.Size = new System.Drawing.Size(185, 28);
            this.lb_totalDividend.TabIndex = 8;
            this.lb_totalDividend.Text = "Total : $202.405";
            // 
            // lb_div_yen
            // 
            this.lb_div_yen.AutoSize = true;
            this.lb_div_yen.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_div_yen.ForeColor = System.Drawing.Color.White;
            this.lb_div_yen.Location = new System.Drawing.Point(200, 16);
            this.lb_div_yen.Name = "lb_div_yen";
            this.lb_div_yen.Size = new System.Drawing.Size(110, 28);
            this.lb_div_yen.TabIndex = 8;
            this.lb_div_yen.Text = "¥202.405";
            // 
            // lb_stock_yen
            // 
            this.lb_stock_yen.AutoSize = true;
            this.lb_stock_yen.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_stock_yen.ForeColor = System.Drawing.Color.White;
            this.lb_stock_yen.Location = new System.Drawing.Point(200, 450);
            this.lb_stock_yen.Name = "lb_stock_yen";
            this.lb_stock_yen.Size = new System.Drawing.Size(110, 28);
            this.lb_stock_yen.TabIndex = 8;
            this.lb_stock_yen.Text = "¥202.405";
            // 
            // lb_div_won
            // 
            this.lb_div_won.AutoSize = true;
            this.lb_div_won.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_div_won.ForeColor = System.Drawing.Color.White;
            this.lb_div_won.Location = new System.Drawing.Point(336, 16);
            this.lb_div_won.Name = "lb_div_won";
            this.lb_div_won.Size = new System.Drawing.Size(119, 28);
            this.lb_div_won.TabIndex = 8;
            this.lb_div_won.Text = "₩202.405";
            // 
            // lb_stock_won
            // 
            this.lb_stock_won.AutoSize = true;
            this.lb_stock_won.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lb_stock_won.ForeColor = System.Drawing.Color.White;
            this.lb_stock_won.Location = new System.Drawing.Point(336, 450);
            this.lb_stock_won.Name = "lb_stock_won";
            this.lb_stock_won.Size = new System.Drawing.Size(119, 28);
            this.lb_stock_won.TabIndex = 8;
            this.lb_stock_won.Text = "₩202.405";
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
            this.btn_back.Location = new System.Drawing.Point(1524, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 42);
            this.btn_back.TabIndex = 9;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_yen
            // 
            this.tb_yen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_yen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_yen.ForeColor = System.Drawing.Color.White;
            this.tb_yen.HintForeColor = System.Drawing.Color.Empty;
            this.tb_yen.HintText = "";
            this.tb_yen.isPassword = false;
            this.tb_yen.LineFocusedColor = System.Drawing.Color.Blue;
            this.tb_yen.LineIdleColor = System.Drawing.Color.White;
            this.tb_yen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tb_yen.LineThickness = 3;
            this.tb_yen.Location = new System.Drawing.Point(948, 11);
            this.tb_yen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_yen.Name = "tb_yen";
            this.tb_yen.Size = new System.Drawing.Size(84, 33);
            this.tb_yen.TabIndex = 10;
            this.tb_yen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(926, 16);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(25, 28);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "¥";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(1090, 16);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(34, 28);
            this.bunifuCustomLabel7.TabIndex = 8;
            this.bunifuCustomLabel7.Text = "₩";
            // 
            // tb_won
            // 
            this.tb_won.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_won.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_won.ForeColor = System.Drawing.Color.White;
            this.tb_won.HintForeColor = System.Drawing.Color.Empty;
            this.tb_won.HintText = "";
            this.tb_won.isPassword = false;
            this.tb_won.LineFocusedColor = System.Drawing.Color.Blue;
            this.tb_won.LineIdleColor = System.Drawing.Color.White;
            this.tb_won.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tb_won.LineThickness = 3;
            this.tb_won.Location = new System.Drawing.Point(1122, 11);
            this.tb_won.Margin = new System.Windows.Forms.Padding(4);
            this.tb_won.Name = "tb_won";
            this.tb_won.Size = new System.Drawing.Size(84, 33);
            this.tb_won.TabIndex = 10;
            this.tb_won.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_rate
            // 
            this.btn_rate.Activecolor = System.Drawing.Color.DimGray;
            this.btn_rate.AllowDrop = true;
            this.btn_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_rate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rate.BorderRadius = 0;
            this.btn_rate.ButtonText = "";
            this.btn_rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_rate.Iconimage")));
            this.btn_rate.Iconimage_right = null;
            this.btn_rate.Iconimage_right_Selected = null;
            this.btn_rate.Iconimage_Selected = null;
            this.btn_rate.IconMarginLeft = 0;
            this.btn_rate.IconMarginRight = 0;
            this.btn_rate.IconRightVisible = true;
            this.btn_rate.IconRightZoom = 0D;
            this.btn_rate.IconVisible = true;
            this.btn_rate.IconZoom = 90D;
            this.btn_rate.IsTab = false;
            this.btn_rate.Location = new System.Drawing.Point(1230, 8);
            this.btn_rate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_rate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_rate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rate.selected = false;
            this.btn_rate.Size = new System.Drawing.Size(41, 37);
            this.btn_rate.TabIndex = 12;
            this.btn_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rate.Textcolor = System.Drawing.Color.White;
            this.btn_rate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            // 
            // Asset_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1626, 889);
            this.Controls.Add(this.btn_rate);
            this.Controls.Add(this.tb_won);
            this.Controls.Add(this.tb_yen);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lb_stock_yen);
            this.Controls.Add(this.lb_stock_won);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.lb_div_won);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.lb_div_yen);
            this.Controls.Add(this.lb_totalDividend);
            this.Controls.Add(this.lb_totalStocks);
            this.Controls.Add(this.lb_updatetime);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asset_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset_Form";
            this.Load += new System.EventHandler(this.Asset_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_updatetime;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_totalStocks;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_totalDividend;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_stock_yen;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_stock_won;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_div_won;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_div_yen;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_back;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_yen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_won;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_rate;
    }
}