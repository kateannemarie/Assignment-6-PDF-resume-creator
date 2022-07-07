namespace DALANGIN.PDF_RESUME_CREATOR
{
    partial class Form1
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
            this.jsonLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonLabel
            // 
            this.jsonLabel.AutoSize = true;
            this.jsonLabel.Location = new System.Drawing.Point(35, 66);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(83, 13);
            this.jsonLabel.TabIndex = 0;
            this.jsonLabel.Text = "JSON OUTPUT";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(38, 92);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(425, 171);
            this.outputTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(362, 269);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(101, 47);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert to JSON";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.jsonLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

