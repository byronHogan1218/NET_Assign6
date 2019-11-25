namespace BigBadBolts_Assign6
{
    partial class PieForm
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
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.formButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(12, 82);
            this.pieChart.Name = "pieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(776, 366);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "Pie Chart";
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(212, 13);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(316, 63);
            this.formButton.TabIndex = 1;
            this.formButton.Text = "Return to Main Form";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // PieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.pieChart);
            this.Name = "PieForm";
            this.Text = "PieForm";
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Button formButton;
    }
}