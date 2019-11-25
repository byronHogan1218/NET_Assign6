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
    public partial class PieForm : Form
    {
        MainForm form;
        private SortedList<string, int> pieChartData = new SortedList<string, int>();

        public PieForm(MainForm f)
        {
            string line;
            string[] tokens;

            InitializeComponent();

            form = f;

            using(StreamReader inFile = new StreamReader("..//..//PieData.txt"))
            {
                line = inFile.ReadLine();

                while(line != null)
                {
                    tokens = line.Split(' ');
                    pieChartData.Add(tokens[0], Convert.ToInt32(tokens[1]));
                    line = inFile.ReadLine();
                }

            }

            pieChart.Series.Remove(pieChart.Series["Series1"]);
            pieChart.Series.Add("Gaming Console Preference");
            pieChart.Series["Gaming Console Preference"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            pieChart.Series["Gaming Console Preference"].IsValueShownAsLabel = true;
            pieChart.Titles.Add("Gaming Console Preference");

            for (int i = 0; i < pieChartData.Count; i++)
            {
                pieChart.Series["Gaming Console Preference"].Points.AddXY(pieChartData.Keys[i], pieChartData.Values[i]);
            }

        }

        private void PieForm_FormClosing(object sender, FormClosingEventArgs e)
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
