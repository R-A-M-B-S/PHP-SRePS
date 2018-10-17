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
            this.tabDisplaySales = new System.Windows.Forms.TabPage();
            this.displaySales1 = new SalesApp.DisplaySales();
            this.tabMonthlyReport = new System.Windows.Forms.TabPage();
            this.monthlyReportControl = new SalesApp.MonthlyReport();
            this.tabEditAssets = new System.Windows.Forms.TabPage();
            this.editAssets1 = new SalesApp.EditAssets();
            this.tabAddSale = new System.Windows.Forms.TabPage();
            this.addSaleControl = new SalesApp.AddSale();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.testyboi = new System.Windows.Forms.TabPage();
            this.tabDisplaySales.SuspendLayout();
            this.tabMonthlyReport.SuspendLayout();
            this.tabEditAssets.SuspendLayout();
            this.tabAddSale.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDisplaySales
            // 
            this.tabDisplaySales.Controls.Add(this.displaySales1);
            this.tabDisplaySales.Location = new System.Drawing.Point(4, 22);
            this.tabDisplaySales.Name = "tabDisplaySales";
            this.tabDisplaySales.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplaySales.Size = new System.Drawing.Size(776, 535);
            this.tabDisplaySales.TabIndex = 3;
            this.tabDisplaySales.Text = "DisplaySales";
            this.tabDisplaySales.UseVisualStyleBackColor = true;
            // 
            // displaySales1
            // 
            this.displaySales1.Location = new System.Drawing.Point(0, 0);
            this.displaySales1.Name = "displaySales1";
            this.displaySales1.Size = new System.Drawing.Size(776, 535);
            this.displaySales1.TabIndex = 0;
            // 
            // tabMonthlyReport
            // 
            this.tabMonthlyReport.Controls.Add(this.monthlyReportControl);
            this.tabMonthlyReport.Location = new System.Drawing.Point(4, 22);
            this.tabMonthlyReport.Name = "tabMonthlyReport";
            this.tabMonthlyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthlyReport.Size = new System.Drawing.Size(776, 535);
            this.tabMonthlyReport.TabIndex = 2;
            this.tabMonthlyReport.Text = "Monthly Report";
            this.tabMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // monthlyReportControl
            // 
            this.monthlyReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReportControl.Location = new System.Drawing.Point(3, 3);
            this.monthlyReportControl.Name = "monthlyReportControl";
            this.monthlyReportControl.Size = new System.Drawing.Size(770, 529);
            this.monthlyReportControl.TabIndex = 0;
            // 
            // tabEditAssets
            // 
            this.tabEditAssets.Controls.Add(this.editAssets1);
            this.tabEditAssets.Location = new System.Drawing.Point(4, 22);
            this.tabEditAssets.Name = "tabEditAssets";
            this.tabEditAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditAssets.Size = new System.Drawing.Size(776, 535);
            this.tabEditAssets.TabIndex = 1;
            this.tabEditAssets.Text = "Edit Assets";
            this.tabEditAssets.UseVisualStyleBackColor = true;
            // 
            // editAssets1
            // 
            this.editAssets1.Location = new System.Drawing.Point(0, 0);
            this.editAssets1.Name = "editAssets1";
            this.editAssets1.Size = new System.Drawing.Size(776, 533);
            this.editAssets1.TabIndex = 0;
            // 
            // tabAddSale
            // 
            this.tabAddSale.Controls.Add(this.addSaleControl);
            this.tabAddSale.Location = new System.Drawing.Point(4, 22);
            this.tabAddSale.Name = "tabAddSale";
            this.tabAddSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSale.Size = new System.Drawing.Size(776, 535);
            this.tabAddSale.TabIndex = 0;
            this.tabAddSale.Text = "Add Sale";
            this.tabAddSale.UseVisualStyleBackColor = true;
            // 
            // addSaleControl
            // 
            this.addSaleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSaleControl.Location = new System.Drawing.Point(3, 3);
            this.addSaleControl.Name = "addSaleControl";
            this.addSaleControl.Size = new System.Drawing.Size(770, 529);
            this.addSaleControl.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAddSale);
            this.tabControlMain.Controls.Add(this.tabEditAssets);
            this.tabControlMain.Controls.Add(this.tabMonthlyReport);
            this.tabControlMain.Controls.Add(this.tabDisplaySales);
            this.tabControlMain.Controls.Add(this.testyboi);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 561);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // testyboi
            // 
            this.testyboi.Location = new System.Drawing.Point(4, 22);
            this.testyboi.Name = "testyboi";
            this.testyboi.Padding = new System.Windows.Forms.Padding(3);
            this.testyboi.Size = new System.Drawing.Size(776, 535);
            this.testyboi.TabIndex = 4;
            this.testyboi.Text = "tabPage1";
            this.testyboi.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainScreen";
            this.Text = "Add Sale";
            this.tabDisplaySales.ResumeLayout(false);
            this.tabMonthlyReport.ResumeLayout(false);
            this.tabEditAssets.ResumeLayout(false);
            this.tabAddSale.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabDisplaySales;
        private DisplaySales displaySales1;
        private System.Windows.Forms.TabPage tabMonthlyReport;
        private MonthlyReport monthlyReportControl;
        private System.Windows.Forms.TabPage tabEditAssets;
        private EditAssets editAssets1;
        private System.Windows.Forms.TabPage tabAddSale;
        private AddSale addSaleControl;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage testyboi;
    }
}

