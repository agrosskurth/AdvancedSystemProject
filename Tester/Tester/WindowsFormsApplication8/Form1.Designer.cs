namespace WindowsFormsApplication8
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
            this.correctBtn = new System.Windows.Forms.Button();
            this.incorrectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correctBtn
            // 
            this.correctBtn.Location = new System.Drawing.Point(88, 63);
            this.correctBtn.Name = "correctBtn";
            this.correctBtn.Size = new System.Drawing.Size(100, 48);
            this.correctBtn.TabIndex = 0;
            this.correctBtn.Text = "Correct";
            this.correctBtn.UseVisualStyleBackColor = true;
            this.correctBtn.Click += new System.EventHandler(this.correctBtn_Click);
            // 
            // incorrectBtn
            // 
            this.incorrectBtn.Location = new System.Drawing.Point(88, 150);
            this.incorrectBtn.Name = "incorrectBtn";
            this.incorrectBtn.Size = new System.Drawing.Size(100, 48);
            this.incorrectBtn.TabIndex = 1;
            this.incorrectBtn.Text = "Incorrect";
            this.incorrectBtn.UseVisualStyleBackColor = true;
            this.incorrectBtn.Click += new System.EventHandler(this.incorrectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.incorrectBtn);
            this.Controls.Add(this.correctBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button correctBtn;
        private System.Windows.Forms.Button incorrectBtn;
    }
}

