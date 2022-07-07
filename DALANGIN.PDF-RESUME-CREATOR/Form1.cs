using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void convertButton_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                ID = 03,
                Name = "Kate Anne Marie",
                DateOfBirth = DateTime.Now,
                HomeAddress = "San Pablo City"
            };

            string JsonOutput = JsonConvert.SerializeObject(data);
            outputTextBox.Text = JsonOutput;
        }
    }
}
