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
//*  Program Name:  Chart - PieForm                                  *
//*                                                                  *
//*  Programmer:    Byron Hogan,  z1825194                           *
//*                 Margaret Higginbotham, z1793581                  *
//*                                                                  *
//*******************************************************************/

namespace BigBadBolts_Assign6
{
    //need to add: x label, y label
    public partial class LineForm : Form
    {
        MainForm form;
        private SortedList<string, int> lineChartData = new SortedList<string, int>();

        public LineForm(MainForm f)
        {
            string line;
            string[] tokens;

            InitializeComponent();

            form = f;

            using (StreamReader inFile = new StreamReader("..//..//LineData.txt"))
            {
                line = inFile.ReadLine();

                while (line != null)
                {
                    tokens = line.Split(' ');
                    lineChartData.Add(tokens[0], Convert.ToInt32(tokens[1]));
                    line = inFile.ReadLine();
                }

            }

            lineChart.Series.Remove(lineChart.Series["Series1"]);
            lineChart.Series.Add("Average Temperature of This Week (F)");
            lineChart.Series["Average Temperature of This Week (F)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            lineChart.Series["Average Temperature of This Week (F)"].IsValueShownAsLabel = true;
            lineChart.Titles.Add("Average Temperature of This Week (F)");

            for (int i = 0; i < lineChartData.Count; i++)
            {
                lineChart.Series["Average Temperature of This Week (F)"].Points.AddXY(lineChartData.Keys[i], lineChartData.Values[i]);
            }

        }

        private void LineForm_FormClosing(object sender, FormClosingEventArgs e)
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
