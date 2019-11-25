namespace BigBadBolts_Assign6
{
    partial class MainForm
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
            this.LineChart_Button = new System.Windows.Forms.Button();
            this.PointChart_Button = new System.Windows.Forms.Button();
            this.PieChart_Button = new System.Windows.Forms.Button();
            this.BarChart_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Chart to View!";
            // 
            // LineChart_Button
            // 
            this.LineChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineChart_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LineChart_Button.Location = new System.Drawing.Point(44, 84);
            this.LineChart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.LineChart_Button.Name = "LineChart_Button";
            this.LineChart_Button.Size = new System.Drawing.Size(232, 89);
            this.LineChart_Button.TabIndex = 1;
            this.LineChart_Button.Text = "Line Chart";
            this.LineChart_Button.UseVisualStyleBackColor = true;
            this.LineChart_Button.Click += new System.EventHandler(this.LineChart_Button_Click);
            // 
            // PointChart_Button
            // 
            this.PointChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointChart_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PointChart_Button.Location = new System.Drawing.Point(341, 84);
            this.PointChart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PointChart_Button.Name = "PointChart_Button";
            this.PointChart_Button.Size = new System.Drawing.Size(232, 89);
            this.PointChart_Button.TabIndex = 2;
            this.PointChart_Button.Text = "Point Chart";
            this.PointChart_Button.UseVisualStyleBackColor = true;
            this.PointChart_Button.Click += new System.EventHandler(this.PointChart_Button_Click);
            // 
            // PieChart_Button
            // 
            this.PieChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PieChart_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PieChart_Button.Location = new System.Drawing.Point(44, 249);
            this.PieChart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.PieChart_Button.Name = "PieChart_Button";
            this.PieChart_Button.Size = new System.Drawing.Size(232, 89);
            this.PieChart_Button.TabIndex = 3;
            this.PieChart_Button.Text = "Pie Chart";
            this.PieChart_Button.UseVisualStyleBackColor = true;
            this.PieChart_Button.Click += new System.EventHandler(this.PieChart_Button_Click);
            // 
            // BarChart_Button
            // 
            this.BarChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChart_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BarChart_Button.Location = new System.Drawing.Point(341, 249);
            this.BarChart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.BarChart_Button.Name = "BarChart_Button";
            this.BarChart_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BarChart_Button.Size = new System.Drawing.Size(232, 89);
            this.BarChart_Button.TabIndex = 4;
            this.BarChart_Button.Text = "Bar Chart";
            this.BarChart_Button.UseVisualStyleBackColor = true;
            this.BarChart_Button.Click += new System.EventHandler(this.BarChart_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(663, 426);
            this.Controls.Add(this.BarChart_Button);
            this.Controls.Add(this.PieChart_Button);
            this.Controls.Add(this.PointChart_Button);
            this.Controls.Add(this.LineChart_Button);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "View Charts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LineChart_Button;
        private System.Windows.Forms.Button PointChart_Button;
        private System.Windows.Forms.Button PieChart_Button;
        private System.Windows.Forms.Button BarChart_Button;
    }
}

