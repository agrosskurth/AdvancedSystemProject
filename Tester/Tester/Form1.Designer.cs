namespace Tester
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
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.BtnTimeSheet = new System.Windows.Forms.Button();
            this.btnInsertTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(12, 12);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(98, 49);
            this.btnCorrect.TabIndex = 0;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.Location = new System.Drawing.Point(12, 67);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(98, 49);
            this.btnIncorrect.TabIndex = 1;
            this.btnIncorrect.Text = "Incorrect";
            this.btnIncorrect.UseVisualStyleBackColor = true;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(149, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 49);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Select Employee";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(12, 122);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(98, 49);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "Select TimeIO";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Location = new System.Drawing.Point(149, 67);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(98, 49);
            this.btnInsertEmployee.TabIndex = 4;
            this.btnInsertEmployee.Text = "Insert Employee";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click_1);
            // 
            // BtnTimeSheet
            // 
            this.BtnTimeSheet.Location = new System.Drawing.Point(149, 122);
            this.BtnTimeSheet.Name = "BtnTimeSheet";
            this.BtnTimeSheet.Size = new System.Drawing.Size(98, 49);
            this.BtnTimeSheet.TabIndex = 5;
            this.BtnTimeSheet.Text = "Create TimeSheet";
            this.BtnTimeSheet.UseVisualStyleBackColor = true;
            this.BtnTimeSheet.Click += new System.EventHandler(this.BtnTimeSheet_Click);
            // 
            // btnInsertTime
            // 
            this.btnInsertTime.Location = new System.Drawing.Point(12, 177);
            this.btnInsertTime.Name = "btnInsertTime";
            this.btnInsertTime.Size = new System.Drawing.Size(98, 49);
            this.btnInsertTime.TabIndex = 6;
            this.btnInsertTime.Text = "Insert TimeIO";
            this.btnInsertTime.UseVisualStyleBackColor = true;
            this.btnInsertTime.Click += new System.EventHandler(this.btnInsertTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 271);
            this.Controls.Add(this.btnInsertTime);
            this.Controls.Add(this.BtnTimeSheet);
            this.Controls.Add(this.btnInsertEmployee);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnIncorrect);
            this.Controls.Add(this.btnCorrect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.Button BtnTimeSheet;
        private System.Windows.Forms.Button btnInsertTime;
    }
}

