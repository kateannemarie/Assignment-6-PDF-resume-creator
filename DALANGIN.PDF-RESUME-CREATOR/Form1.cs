using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DALANGIN.PDF_RESUME_CREATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstnameTextBox.Clear();
            middlenameTextBox.Clear();
            lastnameTextBox.Clear();
            addressTextBox.Clear();
            contactnumTextBox.Clear();
            emailaddTextBox.Clear();
            objectiveTextBox.Clear();
            skill1TextBox.Clear();
            skill2TextBox.Clear();
            skill3TextBox.Clear();
            year1TextBox.Clear();
            companyname1TextBox.Clear();
            position1TextBox.Clear();
            year2TextBox.Clear();
            companyname2TextBox.Clear();
            position2TextBox.Clear();
            jhsTextBox.Clear();
            yearjhsTextBox.Clear();
            shsTextBox.Clear();
            yearshsTextBox.Clear();
            strandTextbox.Clear();
            collegeTextBox.Clear();
            yearcollegeTextBox.Clear();
            courseTextBox.Clear();
            achievement1TextBox.Clear();
            achievement2TextBox.Clear();
            achievement3TextBox.Clear();

        }
    }
}
