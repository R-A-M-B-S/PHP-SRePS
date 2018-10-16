namespace SalesApp
{
    partial class predictionControl1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Prediction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Predict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Prediction)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Prediction
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Prediction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Prediction.Legends.Add(legend1);
            this.chart_Prediction.Location = new System.Drawing.Point(0, 0);
            this.chart_Prediction.Name = "chart_Prediction";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.MarkerBorderWidth = 10;
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Sales";
            this.chart_Prediction.Series.Add(series1);
            this.chart_Prediction.Size = new System.Drawing.Size(730, 489);
            this.chart_Prediction.TabIndex = 0;
            this.chart_Prediction.Text = "Prediction Model";
            // 
            // btn_Predict
            // 
            this.btn_Predict.Location = new System.Drawing.Point(611, 399);
            this.btn_Predict.Name = "btn_Predict";
            this.btn_Predict.Size = new System.Drawing.Size(96, 59);
            this.btn_Predict.TabIndex = 1;
            this.btn_Predict.Text = "Predict Next Month";
            this.btn_Predict.UseVisualStyleBackColor = true;
            this.btn_Predict.Click += new System.EventHandler(this.button1_Click);
            // 
            // predictionControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Predict);
            this.Controls.Add(this.chart_Prediction);
            this.Name = "predictionControl1";
            this.Size = new System.Drawing.Size(730, 489);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Prediction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Prediction;
        private System.Windows.Forms.Button btn_Predict;
    }
}
