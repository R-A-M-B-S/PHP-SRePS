namespace SalesApp
{
    partial class AddSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SalesData = new System.Windows.Forms.DataGridView();
            this.FinaliseButton = new System.Windows.Forms.Button();
            this.TotalsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalValue = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxValue = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.EftposLabel = new System.Windows.Forms.Label();
            this.CashValue = new System.Windows.Forms.NumericUpDown();
            this.EftposValue = new System.Windows.Forms.NumericUpDown();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.assetLabel = new System.Windows.Forms.Label();
            this.assetValue = new System.Windows.Forms.NumericUpDown();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyValue = new System.Windows.Forms.NumericUpDown();
            this.addItemButton = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).BeginInit();
            this.TotalsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EftposValue)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.SalesData, 0, 1);
            this.MainLayout.Controls.Add(this.FinaliseButton, 0, 3);
            this.MainLayout.Controls.Add(this.TotalsTable, 0, 2);
            this.MainLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(658, 519);
            this.MainLayout.TabIndex = 1;
            // 
            // SalesData
            // 
            this.SalesData.AllowUserToAddRows = false;
            this.SalesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesData.Location = new System.Drawing.Point(3, 33);
            this.SalesData.Name = "SalesData";
            this.SalesData.ReadOnly = true;
            this.SalesData.Size = new System.Drawing.Size(652, 287);
            this.SalesData.TabIndex = 0;
            // 
            // FinaliseButton
            // 
            this.FinaliseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinaliseButton.Location = new System.Drawing.Point(3, 472);
            this.FinaliseButton.Name = "FinaliseButton";
            this.FinaliseButton.Size = new System.Drawing.Size(652, 44);
            this.FinaliseButton.TabIndex = 1;
            this.FinaliseButton.Text = "Finalise Sale";
            this.FinaliseButton.UseVisualStyleBackColor = true;
            this.FinaliseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.finalise_sale);
            // 
            // TotalsTable
            // 
            this.TotalsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TotalsTable.ColumnCount = 2;
            this.TotalsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalsTable.Controls.Add(this.SubTotalLabel, 0, 0);
            this.TotalsTable.Controls.Add(this.SubTotalValue, 1, 0);
            this.TotalsTable.Controls.Add(this.TaxLabel, 0, 1);
            this.TotalsTable.Controls.Add(this.TaxValue, 1, 1);
            this.TotalsTable.Controls.Add(this.TotalLabel, 0, 2);
            this.TotalsTable.Controls.Add(this.TotalValue, 1, 2);
            this.TotalsTable.Controls.Add(this.CashLabel, 0, 4);
            this.TotalsTable.Controls.Add(this.EftposLabel, 0, 5);
            this.TotalsTable.Controls.Add(this.CashValue, 1, 4);
            this.TotalsTable.Controls.Add(this.EftposValue, 1, 5);
            this.TotalsTable.Controls.Add(this.PaymentMethod, 0, 3);
            this.TotalsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalsTable.Location = new System.Drawing.Point(455, 326);
            this.TotalsTable.Name = "TotalsTable";
            this.TotalsTable.RowCount = 6;
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TotalsTable.Size = new System.Drawing.Size(200, 140);
            this.TotalsTable.TabIndex = 2;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalLabel.Location = new System.Drawing.Point(4, 1);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(92, 24);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "Sub Total";
            this.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTotalValue
            // 
            this.SubTotalValue.AutoSize = true;
            this.SubTotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotalValue.Location = new System.Drawing.Point(103, 1);
            this.SubTotalValue.Name = "SubTotalValue";
            this.SubTotalValue.Size = new System.Drawing.Size(93, 24);
            this.SubTotalValue.TabIndex = 1;
            this.SubTotalValue.Text = "0.0";
            this.SubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxLabel.Location = new System.Drawing.Point(4, 26);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(92, 24);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax";
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxValue.Location = new System.Drawing.Point(103, 26);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(93, 24);
            this.TaxValue.TabIndex = 3;
            this.TaxValue.Text = "0.0";
            this.TaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalLabel.Location = new System.Drawing.Point(4, 51);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(92, 24);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(103, 51);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(93, 24);
            this.TotalValue.TabIndex = 5;
            this.TotalValue.Text = "0.0";
            this.TotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CashLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashLabel.Location = new System.Drawing.Point(4, 97);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(92, 20);
            this.CashLabel.TabIndex = 6;
            this.CashLabel.Text = "Cash";
            this.CashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EftposLabel
            // 
            this.EftposLabel.AutoSize = true;
            this.EftposLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EftposLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EftposLabel.Location = new System.Drawing.Point(4, 118);
            this.EftposLabel.Name = "EftposLabel";
            this.EftposLabel.Size = new System.Drawing.Size(92, 21);
            this.EftposLabel.TabIndex = 8;
            this.EftposLabel.Text = "Eftpos";
            this.EftposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashValue
            // 
            this.CashValue.DecimalPlaces = 2;
            this.CashValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashValue.Location = new System.Drawing.Point(103, 100);
            this.CashValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CashValue.Name = "CashValue";
            this.CashValue.Size = new System.Drawing.Size(93, 20);
            this.CashValue.TabIndex = 3;
            this.CashValue.ValueChanged += new System.EventHandler(this.CashChanged);
            // 
            // EftposValue
            // 
            this.EftposValue.DecimalPlaces = 2;
            this.EftposValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EftposValue.Location = new System.Drawing.Point(103, 121);
            this.EftposValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.EftposValue.Name = "EftposValue";
            this.EftposValue.Size = new System.Drawing.Size(93, 20);
            this.EftposValue.TabIndex = 4;
            this.EftposValue.ValueChanged += new System.EventHandler(this.EftposChanged);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalsTable.SetColumnSpan(this.PaymentMethod, 2);
            this.PaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(4, 76);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(192, 20);
            this.PaymentMethod.TabIndex = 12;
            this.PaymentMethod.Text = "Payment Method";
            this.PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.assetLabel);
            this.flowLayoutPanel1.Controls.Add(this.assetValue);
            this.flowLayoutPanel1.Controls.Add(this.qtyLabel);
            this.flowLayoutPanel1.Controls.Add(this.qtyValue);
            this.flowLayoutPanel1.Controls.Add(this.addItemButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 24);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // assetLabel
            // 
            this.assetLabel.AutoSize = true;
            this.assetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetLabel.Location = new System.Drawing.Point(3, 0);
            this.assetLabel.Name = "assetLabel";
            this.assetLabel.Size = new System.Drawing.Size(33, 29);
            this.assetLabel.TabIndex = 1;
            this.assetLabel.Text = "Asset";
            this.assetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetValue
            // 
            this.assetValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetValue.Location = new System.Drawing.Point(42, 3);
            this.assetValue.Name = "assetValue";
            this.assetValue.Size = new System.Drawing.Size(120, 20);
            this.assetValue.TabIndex = 1;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qtyLabel.Location = new System.Drawing.Point(168, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(46, 29);
            this.qtyLabel.TabIndex = 2;
            this.qtyLabel.Text = "Quantity";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyValue
            // 
            this.qtyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.qtyValue.Location = new System.Drawing.Point(220, 3);
            this.qtyValue.Name = "qtyValue";
            this.qtyValue.Size = new System.Drawing.Size(120, 20);
            this.qtyValue.TabIndex = 2;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(346, 3);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItem);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayout);
            this.Name = "AddSale";
            this.Size = new System.Drawing.Size(658, 519);
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesData)).EndInit();
            this.TotalsTable.ResumeLayout(false);
            this.TotalsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EftposValue)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView SalesData;
        private System.Windows.Forms.Button FinaliseButton;
        private System.Windows.Forms.TableLayoutPanel TotalsTable;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SubTotalValue;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TaxValue;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.Label EftposLabel;
        private System.Windows.Forms.NumericUpDown CashValue;
        private System.Windows.Forms.NumericUpDown EftposValue;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label assetLabel;
        private System.Windows.Forms.NumericUpDown assetValue;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.NumericUpDown qtyValue;
        private System.Windows.Forms.Button addItemButton;
    }
}
