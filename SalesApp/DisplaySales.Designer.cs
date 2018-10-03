namespace SalesApp
{
    partial class DisplaySales
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
            this.label1 = new System.Windows.Forms.Label();
            this.saleIDValue = new System.Windows.Forms.NumericUpDown();
            this.searchItemButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saleIDLabel = new System.Windows.Forms.Label();
            this.nowShowingLabel = new System.Windows.Forms.Label();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eftposLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubTotalValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TaxValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EftposValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CashValue = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SalesData = new System.Windows.Forms.DataGridView();
            this.SalesDataFocused = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.saleIDValue)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataFocused)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // saleIDValue
            // 
            this.saleIDValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleIDValue.Location = new System.Drawing.Point(51, 3);
            this.saleIDValue.Name = "saleIDValue";
            this.saleIDValue.Size = new System.Drawing.Size(120, 20);
            this.saleIDValue.TabIndex = 1;
            // 
            // searchItemButton
            // 
            this.searchItemButton.Location = new System.Drawing.Point(177, 3);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(75, 23);
            this.searchItemButton.TabIndex = 3;
            this.searchItemButton.Text = "Search Item";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saleIDLabel);
            this.flowLayoutPanel1.Controls.Add(this.saleIDValue);
            this.flowLayoutPanel1.Controls.Add(this.searchItemButton);
            this.flowLayoutPanel1.Controls.Add(this.nowShowingLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 24);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // saleIDLabel
            // 
            this.saleIDLabel.AutoSize = true;
            this.saleIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleIDLabel.Location = new System.Drawing.Point(3, 0);
            this.saleIDLabel.Name = "saleIDLabel";
            this.saleIDLabel.Size = new System.Drawing.Size(42, 29);
            this.saleIDLabel.TabIndex = 1;
            this.saleIDLabel.Text = "Sale ID";
            this.saleIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nowShowingLabel
            // 
            this.nowShowingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nowShowingLabel.AutoSize = true;
            this.nowShowingLabel.Location = new System.Drawing.Point(258, 8);
            this.nowShowingLabel.Name = "nowShowingLabel";
            this.nowShowingLabel.Size = new System.Drawing.Size(0, 13);
            this.nowShowingLabel.TabIndex = 4;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.MainLayout.Controls.Add(this.splitContainer1, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.77273F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.56264F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(585, 491);
            this.MainLayout.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.eftposLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubTotalValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TaxValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotalValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EftposValue, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CashValue, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(382, 342);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 125);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // eftposLabel
            // 
            this.eftposLabel.AutoSize = true;
            this.eftposLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eftposLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eftposLabel.Location = new System.Drawing.Point(4, 103);
            this.eftposLabel.Name = "eftposLabel";
            this.eftposLabel.Size = new System.Drawing.Size(92, 21);
            this.eftposLabel.TabIndex = 14;
            this.eftposLabel.Text = "Efpos";
            this.eftposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTotalValue
            // 
            this.SubTotalValue.AutoSize = true;
            this.SubTotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalValue.Location = new System.Drawing.Point(103, 1);
            this.SubTotalValue.Name = "SubTotalValue";
            this.SubTotalValue.Size = new System.Drawing.Size(93, 19);
            this.SubTotalValue.TabIndex = 1;
            this.SubTotalValue.Text = "0.0";
            this.SubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tax";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxValue.Location = new System.Drawing.Point(103, 21);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(93, 19);
            this.TaxValue.TabIndex = 3;
            this.TaxValue.Text = "0.0";
            this.TaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(103, 41);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(93, 19);
            this.TotalValue.TabIndex = 5;
            this.TotalValue.Text = "0.0";
            this.TotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cash";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EftposValue
            // 
            this.EftposValue.AutoSize = true;
            this.EftposValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EftposValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EftposValue.Location = new System.Drawing.Point(103, 103);
            this.EftposValue.Name = "EftposValue";
            this.EftposValue.Size = new System.Drawing.Size(93, 21);
            this.EftposValue.TabIndex = 8;
            this.EftposValue.Text = "0.0";
            this.EftposValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Payment Method";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashValue
            // 
            this.CashValue.AutoSize = true;
            this.CashValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CashValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashValue.Location = new System.Drawing.Point(103, 82);
            this.CashValue.Name = "CashValue";
            this.CashValue.Size = new System.Drawing.Size(93, 20);
            this.CashValue.TabIndex = 15;
            this.CashValue.Text = "0.0";
            this.CashValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SalesData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SalesDataFocused);
            this.splitContainer1.Size = new System.Drawing.Size(579, 303);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 7;
            // 
            // SalesData
            // 
            this.SalesData.AllowUserToAddRows = false;
            this.SalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesData.Location = new System.Drawing.Point(0, 0);
            this.SalesData.Name = "SalesData";
            this.SalesData.ReadOnly = true;
            this.SalesData.Size = new System.Drawing.Size(193, 303);
            this.SalesData.TabIndex = 8;
            this.SalesData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesData_CellEnter);
            // 
            // SalesDataFocused
            // 
            this.SalesDataFocused.AllowUserToAddRows = false;
            this.SalesDataFocused.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataFocused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesDataFocused.Location = new System.Drawing.Point(0, 0);
            this.SalesDataFocused.Name = "SalesDataFocused";
            this.SalesDataFocused.ReadOnly = true;
            this.SalesDataFocused.Size = new System.Drawing.Size(382, 303);
            this.SalesDataFocused.TabIndex = 7;
            // 
            // DisplaySales
            // 
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.label1);
            this.Name = "DisplaySales";
            this.Size = new System.Drawing.Size(585, 491);
            ((System.ComponentModel.ISupportInitialize)(this.saleIDValue)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.MainLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataFocused)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown saleIDValue;
        private System.Windows.Forms.Button searchItemButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label saleIDLabel;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SubTotalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TaxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EftposValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView SalesDataFocused;
        private System.Windows.Forms.DataGridView SalesData;
        private System.Windows.Forms.Label eftposLabel;
        private System.Windows.Forms.Label nowShowingLabel;
        private System.Windows.Forms.Label CashValue;
    }
}
