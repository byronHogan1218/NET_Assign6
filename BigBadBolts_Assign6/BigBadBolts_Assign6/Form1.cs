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
//*  Program Name:  Reddit                                           *
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
    }
}
