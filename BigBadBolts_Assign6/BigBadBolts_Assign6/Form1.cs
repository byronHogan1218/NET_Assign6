using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///*******************************************************************
//*                                                                  *
//*  CSCI 473-1/504-1       Assignment 6                Fall   2019  *
//*                                                                  *
//*                                                                  *
//*  Program Name:  Chart - Form1                                    *
//*                                                                  *
//*  Programmer:    Byron Hogan,  z1825194                           *
//*                 Margaret Higginbotham, z1793581                  *
//*                                                                  *
//*******************************************************************/
namespace BigBadBolts_Assign6
{
    public partial class MainForm : Form
    {
        public static List<People> myPeople = new List<People>();
        public MainForm()
        {
            InitializeComponent();
            HelperFunctions.ReadInput();//read the data from the file
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BarChart_Button_Click(object sender, EventArgs e)
        {
            BarForm barForm = new BarForm(this);

            this.Hide();
            barForm.Show();
        }

        private void PieChart_Button_Click(object sender, EventArgs e)
        {
            PieForm pieForm = new PieForm(this);

            this.Hide();
            pieForm.Show();
        }

        private void PointChart_Button_Click(object sender, EventArgs e)
        {
            PointForm pointForm = new PointForm(this);

            this.Hide();
            pointForm.Show();
        }

        private void LineChart_Button_Click(object sender, EventArgs e)
        {
            LineForm lineForm = new LineForm(this);

            this.Hide();
            lineForm.Show();
        }

    }

}
