using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

///*******************************************************************
//*                                                                  *
//*  CSCI 473-1/504-1       Assignment 6                Fall   2019  *
//*                                                                  *
//*                                                                  *
//*  Program Name:  Chart - PointForm                                *
//*                                                                  *
//*  Programmer:    Byron Hogan,  z1825194                           *
//*                 Margaret Higginbotham, z1793581                  *
//*                                                                  *
//*******************************************************************/

namespace BigBadBolts_Assign6
{
    //need to add: x label, y label
  
    public partial class PointForm : Form
    {
        MainForm form;
        private SortedList<double, double> pointChartData = new SortedList<double, double>();

        public PointForm(MainForm f)
        {
            string line;
            string[] tokens;

            InitializeComponent();

            form = f;

            using (StreamReader inFile = new StreamReader("..//..//PointData.txt"))
            {
                line = inFile.ReadLine();

                while (line != null)
                {
                    tokens = line.Split(' ');
                    pointChartData.Add(Convert.ToDouble(tokens[0]), Convert.ToDouble(tokens[1]));
                    line = inFile.ReadLine();
                }

            }

            pointChart.Series.Remove(pointChart.Series["Series1"]);
            pointChart.Series.Add("Relationship Between a Star's Magnitude and Distance");
            pointChart.Series["Relationship Between a Star's Magnitude and Distance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            pointChart.Series["Relationship Between a Star's Magnitude and Distance"].IsValueShownAsLabel = true;
            pointChart.Titles.Add("Relationship Between a Star's Magnitude and Distance");

            for (int i = 0; i < pointChartData.Count; i++)
            {
                pointChart.Series["Relationship Between a Star's Magnitude and Distance"].Points.AddXY(pointChartData.Keys[i], pointChartData.Values[i]);
            }
        }

        private void PointForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            this.Hide();
            mainForm.Show();
        }
    }
}
