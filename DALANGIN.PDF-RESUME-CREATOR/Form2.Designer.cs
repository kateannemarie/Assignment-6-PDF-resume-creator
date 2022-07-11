namespace DALANGIN.PDF_RESUME_CREATOR
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosefileButton = new System.Windows.Forms.Button();
            this.datapreviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // choosefileButton
            // 
            this.choosefileButton.Location = new System.Drawing.Point(42, 51);
            this.choosefileButton.Name = "choosefileButton";
            this.choosefileButton.Size = new System.Drawing.Size(97, 44);
            this.choosefileButton.TabIndex = 0;
            this.choosefileButton.Text = "Choose a file";
            this.choosefileButton.UseVisualStyleBackColor = true;
            this.choosefileButton.Click += new System.EventHandler(this.choosefileButton_Click);
            // 
            // datapreviewRichTextBox
            // 
            this.datapreviewRichTextBox.Location = new System.Drawing.Point(42, 101);
            this.datapreviewRichTextBox.Name = "datapreviewRichTextBox";
            this.datapreviewRichTextBox.Size = new System.Drawing.Size(326, 293);
            this.datapreviewRichTextBox.TabIndex = 1;
            this.datapreviewRichTextBox.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datapreviewRichTextBox);
            this.Controls.Add(this.choosefileButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choosefileButton;
        private System.Windows.Forms.RichTextBox datapreviewRichTextBox;
    }
}