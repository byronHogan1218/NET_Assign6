namespace BigBadBolts_Assign6
{
    partial class LineForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.formButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(13, 93);
            this.lineChart.Name = "lineChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.lineChart.Series.Add(series2);
            this.lineChart.Size = new System.Drawing.Size(775, 345);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lineChart";
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(222, 12);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(295, 75);
            this.formButton.TabIndex = 1;
            this.formButton.Text = "Return to Main Form";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.lineChart);
            this.Name = "LineForm";
            this.Text = "LineForm";
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button formButton;
    }
}