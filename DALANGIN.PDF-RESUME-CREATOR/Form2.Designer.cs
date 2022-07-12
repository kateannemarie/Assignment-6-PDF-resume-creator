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
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosefileButton
            // 
            this.choosefileButton.Location = new System.Drawing.Point(14, 66);
            this.choosefileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choosefileButton.Name = "choosefileButton";
            this.choosefileButton.Size = new System.Drawing.Size(113, 51);
            this.choosefileButton.TabIndex = 0;
            this.choosefileButton.Text = "Choose a file";
            this.choosefileButton.UseVisualStyleBackColor = true;
            this.choosefileButton.Click += new System.EventHandler(this.choosefileButton_Click);
            // 
            // datapreviewRichTextBox
            // 
            this.datapreviewRichTextBox.Location = new System.Drawing.Point(49, 123);
            this.datapreviewRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datapreviewRichTextBox.Name = "datapreviewRichTextBox";
            this.datapreviewRichTextBox.Size = new System.Drawing.Size(380, 163);
            this.datapreviewRichTextBox.TabIndex = 1;
            this.datapreviewRichTextBox.Text = "";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(358, 472);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(113, 51);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // secondformLabel
            // 
            this.secondformLabel.AutoSize = true;
            this.secondformLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondformLabel.Location = new System.Drawing.Point(87, 26);
            this.secondformLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondformLabel.Name = "secondformLabel";
            this.secondformLabel.Size = new System.Drawing.Size(295, 22);
            this.secondformLabel.TabIndex = 3;
            this.secondformLabel.Text = "Convert JSON File to PDF File";
            // 
            // fnTextBox
            // 
            this.fnTextBox.Location = new System.Drawing.Point(132, 351);
            this.fnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(222, 21);
            this.fnTextBox.TabIndex = 4;
            this.fnTextBox.TextChanged += new System.EventHandler(this.fnTextBox_TextChanged);
            // 
            // lnTextBox
            // 
            this.lnTextBox.Location = new System.Drawing.Point(132, 381);
            this.lnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lnTextBox.Name = "lnTextBox";
            this.lnTextBox.Size = new System.Drawing.Size(222, 21);
            this.lnTextBox.TabIndex = 5;
            this.lnTextBox.TextChanged += new System.EventHandler(this.lnTextBox_TextChanged);
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.BackColor = System.Drawing.Color.White;
            this.fnLabel.Location = new System.Drawing.Point(55, 354);
            this.fnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(70, 15);
            this.fnLabel.TabIndex = 6;
            this.fnLabel.Text = "First Name:";
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.BackColor = System.Drawing.Color.White;
            this.lnLabel.Location = new System.Drawing.Point(54, 384);
            this.lnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(70, 15);
            this.lnLabel.TabIndex = 7;
            this.lnLabel.Text = "Last Name:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.BackColor = System.Drawing.Color.White;
            this.noteLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(46, 322);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(359, 16);
            this.noteLabel.TabIndex = 8;
            this.noteLabel.Text = "Please input your first and last name before converting:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(238, 472);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 51);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(485, 538);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.lnTextBox);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.secondformLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.datapreviewRichTextBox);
            this.Controls.Add(this.choosefileButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Button backButton;
    }
}