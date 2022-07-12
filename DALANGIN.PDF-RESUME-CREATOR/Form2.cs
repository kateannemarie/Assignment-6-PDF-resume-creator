using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace DALANGIN.PDF_RESUME_CREATOR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string jsonFile;

        private void choosefileButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileexplorer = new OpenFileDialog();

            if (fileexplorer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                jsonFile = fileexplorer.FileName;
                datapreviewRichTextBox.Text = jsonFile;
            }
        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fnTextBox.Text + lnTextBox.Text))
            {
                MessageBox.Show("Please input your first and last name first!", "Caption",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string showJsonFile = File.ReadAllText(jsonFile);
                Data designPDF = JsonConvert.DeserializeObject<Data>(showJsonFile);

                Document CreateResume = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(CreateResume, new FileStream(@"C:\Users\kitka\source\repos\DALANGIN.PDF-RESUME-CREATOR\DALANGIN.PDF-RESUME-CREATOR\Important-Files\Template\resume-template.pdf", FileMode.Create));
                CreateResume.Open();

                var arial_italic_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ariali.ttf");
                var arial_italic_base = BaseFont.CreateFont(arial_italic_path, BaseFont.IDENTITY_H, false);
                var arial_italic = new iTextSharp.text.Font(arial_italic_base, 12);

                LineSeparator design = new LineSeparator(3f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, 2);

                LineSeparator smalldesign = new LineSeparator(2f, 75f, BaseColor.DARK_GRAY, Element.ALIGN_LEFT, 2);

                Paragraph FullName = new Paragraph(designPDF.Name + "\n\n");

                Paragraph Objective = new Paragraph("Objective:", arial_italic);

                Paragraph ObjectiveData = new Paragraph(designPDF.Objective + "\n\n");

                Paragraph PersonalInformation = new Paragraph("Personal Information:", arial_italic);

                Paragraph PersonalInfo = new Paragraph(designPDF.Address + "\n" + designPDF.ContactNumber + "\n" + designPDF.EmailAddress + "\n" + "Skills:" + "\n" + "•" + designPDF.Skill1 + "\n" + "•" + designPDF.Skill2 + "\n" + "•" + designPDF.Skill3 + "\n\n");

                Paragraph WorkExperiences = new Paragraph("Work Experiences:", arial_italic);

                Paragraph WorkExperiencesData1 = new Paragraph(designPDF.YearCompany1 + "\n" + designPDF.Company1 + "\n" + designPDF.Position1 + "\n\n");

                Paragraph WorkExperiencesData2 = new Paragraph(designPDF.YearCompany2 + "\n" + designPDF.Company2 + "\n" + designPDF.Position2 + "\n\n");

                Paragraph EducationalBg = new Paragraph("Educational Background:", arial_italic);

                Paragraph EducationalBackground1 = new Paragraph(designPDF.JHS + "\n" + designPDF.JHSYear + "\n\n");

                Paragraph EducationalBackground2 = new Paragraph(designPDF.SHS + "\n" + designPDF.SHSYear + "\n" + designPDF.SHSStrand + "\n\n");

                Paragraph EducationalBackground3 = new Paragraph(designPDF.College + "\n" + designPDF.CollegeYear + "\n" + designPDF.CollegeCourse + "\n\n");

                Paragraph Achievements = new Paragraph("Achievements & Acknowledgements:", arial_italic);

                Paragraph AchievementsData = new Paragraph(designPDF.Achievement1 + "\n" + designPDF.Achievement2 + "\n" + designPDF.Achievement3 + "\n\n");



                Objective.Alignment = Element.ALIGN_JUSTIFIED;
                FullName.Font.Size = 20;

                CreateResume.Add(FullName);
                CreateResume.Add(design);
                CreateResume.Add(Objective);
                CreateResume.Add(ObjectiveData);
                CreateResume.Add(design);
                CreateResume.Add(PersonalInformation);
                CreateResume.Add(PersonalInfo);
                CreateResume.Add(design);
                CreateResume.Add(WorkExperiences);
                CreateResume.Add(WorkExperiencesData1);
                CreateResume.Add(smalldesign);
                CreateResume.Add(WorkExperiencesData2);
                CreateResume.Add(design);
                CreateResume.Add(EducationalBg);
                CreateResume.Add(EducationalBackground1);
                CreateResume.Add(smalldesign);
                CreateResume.Add(EducationalBackground2);
                CreateResume.Add(smalldesign);
                CreateResume.Add(EducationalBackground3);
                CreateResume.Add(smalldesign);
                CreateResume.Add(design);
                CreateResume.Add(Achievements);
                CreateResume.Add(AchievementsData);
                CreateResume.Close();

                string fileName = "resume-template.pdf";
                string changeName = @"C:\Users\kitka\source\repos\DALANGIN.PDF-RESUME-CREATOR\DALANGIN.PDF-RESUME-CREATOR\Important-Files\PDF-Files\resume-template.pdf";
                string sourcePath = @"C:\Users\kitka\source\repos\DALANGIN.PDF-RESUME-CREATOR\DALANGIN.PDF-RESUME-CREATOR\Important-Files\Template";
                string targetPath = @"C:\Users\kitka\source\repos\DALANGIN.PDF-RESUME-CREATOR\DALANGIN.PDF-RESUME-CREATOR\Important-Files\PDF-Files\";


                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, fileName);

                Directory.CreateDirectory(targetPath);

                File.Copy(sourceFile, destFile, true);


                if (Directory.Exists(sourcePath))
                {
                    string[] files = Directory.GetFiles(sourcePath);


                    foreach (string s in files)
                    {

                        fileName = Path.GetFileName(s);
                        destFile = Path.Combine(targetPath, fileName);
                        File.Copy(s, destFile, true);
                    }
                }

                else
                {
                    MessageBox.Show("Source path does not exist!");
                }

                File.Move(changeName, targetPath + lnTextBox.Text + "_" + fnTextBox.Text + ".pdf");
                MessageBox.Show("Done!");

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 resumecreator = new Form1();
            resumecreator.Show();
            this.Close();
        }

        private void fnTextBox_TextChanged(object sender, EventArgs e)
        {
            fnTextBox.SelectionStart = fnTextBox.Text.Length;
            fnTextBox.Text = fnTextBox.Text.ToUpper();
        }

        private void lnTextBox_TextChanged(object sender, EventArgs e)
        {
            lnTextBox.SelectionStart = lnTextBox.Text.Length;
            lnTextBox.Text = lnTextBox.Text.ToUpper();
        }
    }
}
