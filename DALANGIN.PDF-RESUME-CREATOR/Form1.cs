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
        public static Form1 instance;
        public TextBox lastname;
        public TextBox firstname;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            lastname = lastnameTextBox;
            firstname = firstnameTextBox;
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
            savejsonButton.Enabled = true;
        }

        private void savejsonButton_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                Name = firstnameTextBox.Text + " " + middlenameTextBox.Text + " " + lastnameTextBox.Text,
                Address = addressTextBox.Text,
                ContactNumber = contactnumTextBox.Text,
                EmailAddress = emailaddTextBox.Text,
                Objective = objectiveTextBox.Text,
                Skill1 = skill1TextBox.Text,
                Skill2 = skill2TextBox.Text,
                Skill3 = skill3TextBox.Text,
                YearCompany1 = year1TextBox.Text,
                Company1 = companyname1TextBox.Text,
                Position1 = position1TextBox.Text,
                YearCompany2 = year2TextBox.Text,
                Company2 = companyname2TextBox.Text,
                Position2 = position2TextBox.Text,
                JHS = jhsTextBox.Text,
                JHSYear = yearjhsTextBox.Text,
                SHS = shsTextBox.Text,
                SHSYear = yearshsTextBox.Text,
                SHSStrand = strandTextbox.Text,
                College = collegeTextBox.Text,
                CollegeYear = yearcollegeTextBox.Text,
                CollegeCourse = courseTextBox.Text,
                Achievement1 = achievement1TextBox.Text,
                Achievement2 = achievement2TextBox.Text,
                Achievement3 = achievement3TextBox.Text,
            };

            string JsonOutput = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(@"C:\Users\kitka\source\repos\DALANGIN.PDF-RESUME-CREATOR\DALANGIN.PDF-RESUME-CREATOR\Important-Files\JSON-Files\" + lastnameTextBox.Text + "_" + firstnameTextBox.Text + ".json", JsonOutput);

            savejsonButton.Enabled = false;
        }

        private void convertjsonButton_Click(object sender, EventArgs e)
        {
            Form2 converttoPDF = new Form2();
            converttoPDF.Show();
            this.Hide();
        }
    }
}
