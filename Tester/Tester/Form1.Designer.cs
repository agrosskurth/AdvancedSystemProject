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
            this.btnUpEmp = new System.Windows.Forms.Button();
            this.btnDelTimeIO = new System.Windows.Forms.Button();
            this.btnUpTimeIO = new System.Windows.Forms.Button();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTimeIO = new System.Windows.Forms.Label();
            this.lblTimeSheet = new System.Windows.Forms.Label();
            this.buttonSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(12, 42);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(98, 49);
            this.btnCorrect.TabIndex = 0;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.Location = new System.Drawing.Point(12, 97);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(98, 49);
            this.btnIncorrect.TabIndex = 1;
            this.btnIncorrect.Text = "Incorrect";
            this.btnIncorrect.UseVisualStyleBackColor = true;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(116, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 49);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Select Employee";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(220, 42);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(98, 49);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "Select TimeIO";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Location = new System.Drawing.Point(116, 97);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(98, 49);
            this.btnInsertEmployee.TabIndex = 4;
            this.btnInsertEmployee.Text = "Insert Employee";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click_1);
            // 
            // BtnTimeSheet
            // 
            this.BtnTimeSheet.Location = new System.Drawing.Point(324, 42);
            this.BtnTimeSheet.Name = "BtnTimeSheet";
            this.BtnTimeSheet.Size = new System.Drawing.Size(98, 49);
            this.BtnTimeSheet.TabIndex = 5;
            this.BtnTimeSheet.Text = "Create Time Sheet";
            this.BtnTimeSheet.UseVisualStyleBackColor = true;
            this.BtnTimeSheet.Click += new System.EventHandler(this.BtnTimeSheet_Click);
            // 
            // btnInsertTime
            // 
            this.btnInsertTime.Location = new System.Drawing.Point(220, 97);
            this.btnInsertTime.Name = "btnInsertTime";
            this.btnInsertTime.Size = new System.Drawing.Size(98, 49);
            this.btnInsertTime.TabIndex = 6;
            this.btnInsertTime.Text = "Insert TimeIO";
            this.btnInsertTime.UseVisualStyleBackColor = true;
            this.btnInsertTime.Click += new System.EventHandler(this.btnInsertTime_Click);
            // 
            // btnUpEmp
            // 
            this.btnUpEmp.Location = new System.Drawing.Point(116, 152);
            this.btnUpEmp.Name = "btnUpEmp";
            this.btnUpEmp.Size = new System.Drawing.Size(98, 49);
            this.btnUpEmp.TabIndex = 7;
            this.btnUpEmp.Text = "Update Employee";
            this.btnUpEmp.UseVisualStyleBackColor = true;
            this.btnUpEmp.Click += new System.EventHandler(this.btnUpEmp_Click);
            // 
            // btnDelTimeIO
            // 
            this.btnDelTimeIO.Location = new System.Drawing.Point(220, 207);
            this.btnDelTimeIO.Name = "btnDelTimeIO";
            this.btnDelTimeIO.Size = new System.Drawing.Size(98, 49);
            this.btnDelTimeIO.TabIndex = 8;
            this.btnDelTimeIO.Text = "Delete TimeIO";
            this.btnDelTimeIO.UseVisualStyleBackColor = true;
            this.btnDelTimeIO.Click += new System.EventHandler(this.btnDelTimeIO_Click);
            // 
            // btnUpTimeIO
            // 
            this.btnUpTimeIO.Location = new System.Drawing.Point(220, 152);
            this.btnUpTimeIO.Name = "btnUpTimeIO";
            this.btnUpTimeIO.Size = new System.Drawing.Size(98, 49);
            this.btnUpTimeIO.TabIndex = 9;
            this.btnUpTimeIO.Text = "Update TimeIO";
            this.btnUpTimeIO.UseVisualStyleBackColor = true;
            this.btnUpTimeIO.Click += new System.EventHandler(this.btnUpTimeIO_Click);
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.AutoSize = true;
            this.lblAuthentication.Location = new System.Drawing.Point(25, 17);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(75, 13);
            this.lblAuthentication.TabIndex = 10;
            this.lblAuthentication.Text = "Authentication";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(140, 17);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 11;
            this.lblEmployee.Text = "Employee";
            // 
            // lblTimeIO
            // 
            this.lblTimeIO.AutoSize = true;
            this.lblTimeIO.Location = new System.Drawing.Point(251, 17);
            this.lblTimeIO.Name = "lblTimeIO";
            this.lblTimeIO.Size = new System.Drawing.Size(41, 13);
            this.lblTimeIO.TabIndex = 12;
            this.lblTimeIO.Text = "TimeIO";
            // 
            // lblTimeSheet
            // 
            this.lblTimeSheet.AutoSize = true;
            this.lblTimeSheet.Location = new System.Drawing.Point(346, 17);
            this.lblTimeSheet.Name = "lblTimeSheet";
            this.lblTimeSheet.Size = new System.Drawing.Size(61, 13);
            this.lblTimeSheet.TabIndex = 13;
            this.lblTimeSheet.Text = "Time Sheet";
            // 
            // buttonSpan
            // 
            this.buttonSpan.Location = new System.Drawing.Point(324, 97);
            this.buttonSpan.Name = "buttonSpan";
            this.buttonSpan.Size = new System.Drawing.Size(98, 49);
            this.buttonSpan.TabIndex = 14;
            this.buttonSpan.Text = "TimeSpan";
            this.buttonSpan.UseVisualStyleBackColor = true;
            this.buttonSpan.Click += new System.EventHandler(this.buttonSpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 273);
            this.Controls.Add(this.buttonSpan);
            this.Controls.Add(this.lblTimeSheet);
            this.Controls.Add(this.lblTimeIO);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.btnUpTimeIO);
            this.Controls.Add(this.btnDelTimeIO);
            this.Controls.Add(this.btnUpEmp);
            this.Controls.Add(this.btnInsertTime);
            this.Controls.Add(this.BtnTimeSheet);
            this.Controls.Add(this.btnInsertEmployee);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnIncorrect);
            this.Controls.Add(this.btnCorrect);
            this.Name = "Form1";
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.Button BtnTimeSheet;
        private System.Windows.Forms.Button btnInsertTime;
        private System.Windows.Forms.Button btnUpEmp;
        private System.Windows.Forms.Button btnDelTimeIO;
        private System.Windows.Forms.Button btnUpTimeIO;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTimeIO;
        private System.Windows.Forms.Label lblTimeSheet;
        private System.Windows.Forms.Button buttonSpan;
    }
}

