
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.btnTestTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SchoolName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Twitter";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(125, 12);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(125, 27);
            this.txtSchoolName.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(125, 104);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 27);
            this.txtCity.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(125, 27);
            this.txtAddress.TabIndex = 16;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(125, 153);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(125, 27);
            this.txtState.TabIndex = 17;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(125, 196);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(125, 27);
            this.txtZip.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 259);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 27);
            this.txtPhone.TabIndex = 19;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(125, 314);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(125, 27);
            this.txtTwitter.TabIndex = 20;
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(113, 361);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(137, 31);
            this.btnPushToTest.TabIndex = 21;
            this.btnPushToTest.Text = "Push To Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.btnPushToTest_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(139, 398);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(94, 29);
            this.btnTestStudent.TabIndex = 22;
            this.btnTestStudent.Text = "TestStudent";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.btnTestStudent_Click);
            // 
            // btnTestTeacher
            // 
            this.btnTestTeacher.Location = new System.Drawing.Point(139, 423);
            this.btnTestTeacher.Name = "btnTestTeacher";
            this.btnTestTeacher.Size = new System.Drawing.Size(94, 29);
            this.btnTestTeacher.TabIndex = 23;
            this.btnTestTeacher.Text = "TestTeacher";
            this.btnTestTeacher.UseVisualStyleBackColor = true;
            this.btnTestTeacher.Click += new System.EventHandler(this.btnTestTeacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestTeacher);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Button btnPushToTest;
        private System.Windows.Forms.Button btnTestStudent;
        private System.Windows.Forms.Button btnTestTeacher;
    }
}

