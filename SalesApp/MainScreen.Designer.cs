namespace SalesApp
{
    partial class MainScreen
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAddSale = new System.Windows.Forms.TabPage();
            this.addSaleControl = new SalesApp.AddSale();
            this.tabEditAssets = new System.Windows.Forms.TabPage();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.monthlyReportControl = new SalesApp.MonthlyReport();
            this.tabDisplaySales = new System.Windows.Forms.TabPage();
            this.displaySales1 = new SalesApp.DisplaySales();
            this.tabPrediction = new System.Windows.Forms.TabPage();
            this.predictionControl = new SalesApp.predictionControl1();
            this.tabControlMain.SuspendLayout();
            this.tabAddSale.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.tabDisplaySales.SuspendLayout();
            this.tabPrediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAddSale);
            this.tabControlMain.Controls.Add(this.tabEditAssets);
            this.tabControlMain.Controls.Add(this.tabMonthlyReport);
            this.tabControlMain.Controls.Add(this.tabDisplaySales);
            this.tabControlMain.Controls.Add(this.tabPrediction);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1045, 690);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabAddSale
            // 
            this.tabAddSale.Controls.Add(this.addSaleControl);
            this.tabAddSale.Location = new System.Drawing.Point(4, 25);
            this.tabAddSale.Margin = new System.Windows.Forms.Padding(4);
            this.tabAddSale.Name = "tabAddSale";
            this.tabAddSale.Padding = new System.Windows.Forms.Padding(4);
            this.tabAddSale.Size = new System.Drawing.Size(1037, 661);
            this.tabAddSale.TabIndex = 0;
            this.tabAddSale.Text = "Add Sale";
            this.tabAddSale.UseVisualStyleBackColor = true;
            // 
            // addSaleControl
            // 
            this.addSaleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSaleControl.Location = new System.Drawing.Point(4, 4);
            this.addSaleControl.Margin = new System.Windows.Forms.Padding(5);
            this.addSaleControl.Name = "addSaleControl";
            this.addSaleControl.Size = new System.Drawing.Size(1029, 653);
            this.addSaleControl.TabIndex = 0;
            // 
            // tabEditAssets
            // 
            this.tabEditAssets.Location = new System.Drawing.Point(4, 25);
            this.tabEditAssets.Margin = new System.Windows.Forms.Padding(4);
            this.tabEditAssets.Name = "tabEditAssets";
            this.tabEditAssets.Padding = new System.Windows.Forms.Padding(4);
            this.tabEditAssets.Size = new System.Drawing.Size(1037, 661);
            this.tabEditAssets.TabIndex = 1;
            this.tabEditAssets.Text = "Edit Assets";
            this.tabEditAssets.UseVisualStyleBackColor = true;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Controls.Add(this.monthlyReportControl);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 25);
            this.tabMonthlyReport.Margin = new System.Windows.Forms.Padding(4);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(4);
            this.tabMonthlyReport.Size = new System.Drawing.Size(1037, 661);
            this.tabMonthlyReport.TabIndex = 2;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // monthlyReportControl
            // 
            this.monthlyReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReportControl.Location = new System.Drawing.Point(4, 4);
            this.monthlyReportControl.Margin = new System.Windows.Forms.Padding(5);
            this.monthlyReportControl.Name = "monthlyReportControl";
            this.monthlyReportControl.Size = new System.Drawing.Size(1029, 653);
            this.monthlyReportControl.TabIndex = 0;
            // 
            // tabDisplaySales
            // 
            this.tabDisplaySales.Controls.Add(this.displaySales1);
            this.tabDisplaySales.Location = new System.Drawing.Point(4, 25);
            this.tabDisplaySales.Margin = new System.Windows.Forms.Padding(4);
            this.tabDisplaySales.Name = "tabDisplaySales";
            this.tabDisplaySales.Padding = new System.Windows.Forms.Padding(4);
            this.tabDisplaySales.Size = new System.Drawing.Size(1037, 661);
            this.tabDisplaySales.TabIndex = 3;
            this.tabDisplaySales.Text = "DisplaySales";
            this.tabDisplaySales.UseVisualStyleBackColor = true;
            // 
            // displaySales1
            // 
            this.displaySales1.Location = new System.Drawing.Point(0, 0);
            this.displaySales1.Margin = new System.Windows.Forms.Padding(4);
            this.displaySales1.Name = "displaySales1";
            this.displaySales1.Size = new System.Drawing.Size(1035, 658);
            this.displaySales1.TabIndex = 0;
            // 
            // tabPrediction
            // 
            this.tabPrediction.Controls.Add(this.predictionControl);
            this.tabPrediction.Location = new System.Drawing.Point(4, 25);
            this.tabPrediction.Name = "tabPrediction";
            this.tabPrediction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrediction.Size = new System.Drawing.Size(1037, 661);
            this.tabPrediction.TabIndex = 4;
            this.tabPrediction.Text = "Prediction";
            this.tabPrediction.UseVisualStyleBackColor = true;
            // 
            // predictionControl
            // 
            this.predictionControl.Location = new System.Drawing.Point(0, 0);
            this.predictionControl.Name = "predictionControl";
            this.predictionControl.Size = new System.Drawing.Size(730, 489);
            this.predictionControl.TabIndex = 0;

            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Add Sale";
            this.tabControlMain.ResumeLayout(false);
            this.tabAddSale.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabDisplaySales.ResumeLayout(false);
            this.tabPrediction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSale;
        private System.Windows.Forms.TabPage tabEditAssets;
        private AddSale addSaleControl;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private MonthlyReport monthlyReportControl;
        private System.Windows.Forms.TabPage tabDisplaySales;
        private DisplaySales displaySales1;
        private predictionControl1 predictionControl;
        private System.Windows.Forms.TabPage tabPrediction;
    }
}

