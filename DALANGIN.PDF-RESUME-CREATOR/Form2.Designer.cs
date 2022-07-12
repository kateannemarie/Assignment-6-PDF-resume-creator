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
            this.convertButton = new System.Windows.Forms.Button();
            this.secondformLabel = new System.Windows.Forms.Label();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.lnTextBox = new System.Windows.Forms.TextBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosefileButton
            // 
            this.choosefileButton.Location = new System.Drawing.Point(12, 57);
            this.choosefileButton.Name = "choosefileButton";
            this.choosefileButton.Size = new System.Drawing.Size(97, 44);
            this.choosefileButton.TabIndex = 0;
            this.choosefileButton.Text = "Choose a file";
            this.choosefileButton.UseVisualStyleBackColor = true;
            this.choosefileButton.Click += new System.EventHandler(this.choosefileButton_Click);
            // 
            // datapreviewRichTextBox
            // 
            this.datapreviewRichTextBox.Location = new System.Drawing.Point(42, 107);
            this.datapreviewRichTextBox.Name = "datapreviewRichTextBox";
            this.datapreviewRichTextBox.Size = new System.Drawing.Size(326, 142);
            this.datapreviewRichTextBox.TabIndex = 1;
            this.datapreviewRichTextBox.Text = "";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(307, 409);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(97, 44);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // secondformLabel
            // 
            this.secondformLabel.AutoSize = true;
            this.secondformLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondformLabel.Location = new System.Drawing.Point(54, 18);
            this.secondformLabel.Name = "secondformLabel";
            this.secondformLabel.Size = new System.Drawing.Size(295, 22);
            this.secondformLabel.TabIndex = 3;
            this.secondformLabel.Text = "Convert JSON File to PDF File";
            // 
            // fnTextBox
            // 
            this.fnTextBox.Location = new System.Drawing.Point(113, 304);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(191, 20);
            this.fnTextBox.TabIndex = 4;
            // 
            // lnTextBox
            // 
            this.lnTextBox.Location = new System.Drawing.Point(113, 330);
            this.lnTextBox.Name = "lnTextBox";
            this.lnTextBox.Size = new System.Drawing.Size(191, 20);
            this.lnTextBox.TabIndex = 5;
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(47, 307);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(60, 13);
            this.fnLabel.TabIndex = 6;
            this.fnLabel.Text = "First Name:";
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(46, 333);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(61, 13);
            this.lnLabel.TabIndex = 7;
            this.lnLabel.Text = "Last Name:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(39, 279);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(265, 13);
            this.noteLabel.TabIndex = 8;
            this.noteLabel.Text = "Please input your first and last name before converting:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 466);
            this.ControlBox = false;
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.lnTextBox);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.secondformLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.datapreviewRichTextBox);
            this.Controls.Add(this.choosefileButton);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosefileButton;
        private System.Windows.Forms.RichTextBox datapreviewRichTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label secondformLabel;
        private System.Windows.Forms.TextBox fnTextBox;
        private System.Windows.Forms.TextBox lnTextBox;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label noteLabel;
    }
}