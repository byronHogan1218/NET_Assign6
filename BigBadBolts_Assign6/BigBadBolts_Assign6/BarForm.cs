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
//*  Program Name:  Chart - BarForm                                  *
//*                                                                  *
//*  Programmer:    Byron Hogan,  z1825194                           *
//*                 Margaret Higginbotham, z1793581                  *
//*                                                                  *
//*******************************************************************/

namespace BigBadBolts_Assign6

    //need to add: x label, y label
{
    public partial class BarForm : Form
    {
        MainForm form;
        private SortedList<int, int> chartData = new SortedList<int, int>();

        public BarForm(MainForm f)
        {
            string line;
            string[] tokens;

            InitializeComponent();

            form = f;

            using (StreamReader inFile = new StreamReader("..//..//BarData.txt"))
            {
                line = inFile.ReadLine();

                while(line != null)
                {
                    tokens = line.Split(' ');
                    chartData.Add(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]));
                    line = inFile.ReadLine();
                }

            }

            barChart.Series.Remove(barChart.Series["Series1"]);
            barChart.Series.Add("Grades Percentage");
            barChart.Series["Grades Percentage"].IsValueShownAsLabel = true;
            barChart.Titles.Add("Average Grades");

            for (int i = 0; i < chartData.Count; i++)
            {
                barChart.Series["Grades Percentage"].Points.AddXY(chartData.Keys[i], chartData.Values[i]);

            }

        }

        private void BarForm_FormClosing(object sender, FormClosingEventArgs e)
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
