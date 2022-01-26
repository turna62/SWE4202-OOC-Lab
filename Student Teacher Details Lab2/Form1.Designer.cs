namespace lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentidTxt = new System.Windows.Forms.TextBox();
            this.studentnameTxt = new System.Windows.Forms.TextBox();
            this.studentdepartmentTxt = new System.Windows.Forms.TextBox();
            this.semesterTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.teacheridTxt = new System.Windows.Forms.TextBox();
            this.teachernameTxt = new System.Windows.Forms.TextBox();
            this.teacherdepartmentTxt = new System.Windows.Forms.TextBox();
            this.designationTxt = new System.Windows.Forms.TextBox();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.studentsavebutton = new System.Windows.Forms.Button();
            this.Studentclearbutton = new System.Windows.Forms.Button();
            this.teachersavebutton = new System.Windows.Forms.Button();
            this.teacherclearbutton = new System.Windows.Forms.Button();
            this.studentlistbox = new System.Windows.Forms.ListBox();
            this.teacherlistbox = new System.Windows.Forms.ListBox();
            this.teacherlistbutton = new System.Windows.Forms.Button();
            this.studentlistbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // studentidTxt
            // 
            this.studentidTxt.Location = new System.Drawing.Point(111, 55);
            this.studentidTxt.Name = "studentidTxt";
            this.studentidTxt.Size = new System.Drawing.Size(100, 20);
            this.studentidTxt.TabIndex = 4;
            // 
            // studentnameTxt
            // 
            this.studentnameTxt.Location = new System.Drawing.Point(111, 81);
            this.studentnameTxt.Name = "studentnameTxt";
            this.studentnameTxt.Size = new System.Drawing.Size(100, 20);
            this.studentnameTxt.TabIndex = 5;
            // 
            // studentdepartmentTxt
            // 
            this.studentdepartmentTxt.Location = new System.Drawing.Point(111, 117);
            this.studentdepartmentTxt.Name = "studentdepartmentTxt";
            this.studentdepartmentTxt.Size = new System.Drawing.Size(100, 20);
            this.studentdepartmentTxt.TabIndex = 6;
            // 
            // semesterTxt
            // 
            this.semesterTxt.Location = new System.Drawing.Point(111, 154);
            this.semesterTxt.Name = "semesterTxt";
            this.semesterTxt.Size = new System.Drawing.Size(100, 20);
            this.semesterTxt.TabIndex = 7;
            this.semesterTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teacher ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Salary";
            // 
            // teacheridTxt
            // 
            this.teacheridTxt.Location = new System.Drawing.Point(433, 52);
            this.teacheridTxt.Name = "teacheridTxt";
            this.teacheridTxt.Size = new System.Drawing.Size(100, 20);
            this.teacheridTxt.TabIndex = 13;
            // 
            // teachernameTxt
            // 
            this.teachernameTxt.Location = new System.Drawing.Point(414, 88);
            this.teachernameTxt.Name = "teachernameTxt";
            this.teachernameTxt.Size = new System.Drawing.Size(100, 20);
            this.teachernameTxt.TabIndex = 14;
            // 
            // teacherdepartmentTxt
            // 
            this.teacherdepartmentTxt.Location = new System.Drawing.Point(433, 117);
            this.teacherdepartmentTxt.Name = "teacherdepartmentTxt";
            this.teacherdepartmentTxt.Size = new System.Drawing.Size(100, 20);
            this.teacherdepartmentTxt.TabIndex = 15;
            // 
            // designationTxt
            // 
            this.designationTxt.Location = new System.Drawing.Point(432, 154);
            this.designationTxt.Name = "designationTxt";
            this.designationTxt.Size = new System.Drawing.Size(100, 20);
            this.designationTxt.TabIndex = 16;
            this.designationTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(414, 194);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(100, 20);
            this.salaryTxt.TabIndex = 17;
            // 
            // studentsavebutton
            // 
            this.studentsavebutton.Location = new System.Drawing.Point(71, 209);
            this.studentsavebutton.Name = "studentsavebutton";
            this.studentsavebutton.Size = new System.Drawing.Size(75, 23);
            this.studentsavebutton.TabIndex = 18;
            this.studentsavebutton.Text = "Save";
            this.studentsavebutton.UseVisualStyleBackColor = true;
            this.studentsavebutton.Click += new System.EventHandler(this.studentsavebutton_Click);
            // 
            // Studentclearbutton
            // 
            this.Studentclearbutton.Location = new System.Drawing.Point(181, 209);
            this.Studentclearbutton.Name = "Studentclearbutton";
            this.Studentclearbutton.Size = new System.Drawing.Size(75, 23);
            this.Studentclearbutton.TabIndex = 19;
            this.Studentclearbutton.Text = "Clear";
            this.Studentclearbutton.UseVisualStyleBackColor = true;
            this.Studentclearbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // teachersavebutton
            // 
            this.teachersavebutton.Location = new System.Drawing.Point(352, 234);
            this.teachersavebutton.Name = "teachersavebutton";
            this.teachersavebutton.Size = new System.Drawing.Size(75, 23);
            this.teachersavebutton.TabIndex = 20;
            this.teachersavebutton.Text = "Save";
            this.teachersavebutton.UseVisualStyleBackColor = true;
            this.teachersavebutton.Click += new System.EventHandler(this.teachersavebutton_Click);
            // 
            // teacherclearbutton
            // 
            this.teacherclearbutton.Location = new System.Drawing.Point(479, 234);
            this.teacherclearbutton.Name = "teacherclearbutton";
            this.teacherclearbutton.Size = new System.Drawing.Size(75, 23);
            this.teacherclearbutton.TabIndex = 21;
            this.teacherclearbutton.Text = "Clear";
            this.teacherclearbutton.UseVisualStyleBackColor = true;
            this.teacherclearbutton.Click += new System.EventHandler(this.teacherclearbutton_Click);
            // 
            // studentlistbox
            // 
            this.studentlistbox.FormattingEnabled = true;
            this.studentlistbox.Location = new System.Drawing.Point(34, 272);
            this.studentlistbox.Name = "studentlistbox";
            this.studentlistbox.Size = new System.Drawing.Size(246, 121);
            this.studentlistbox.TabIndex = 22;
            // 
            // teacherlistbox
            // 
            this.teacherlistbox.FormattingEnabled = true;
            this.teacherlistbox.Location = new System.Drawing.Point(340, 272);
            this.teacherlistbox.Name = "teacherlistbox";
            this.teacherlistbox.Size = new System.Drawing.Size(278, 121);
            this.teacherlistbox.TabIndex = 23;
            // 
            // teacherlistbutton
            // 
            this.teacherlistbutton.Location = new System.Drawing.Point(418, 409);
            this.teacherlistbutton.Name = "teacherlistbutton";
            this.teacherlistbutton.Size = new System.Drawing.Size(115, 23);
            this.teacherlistbutton.TabIndex = 24;
            this.teacherlistbutton.Text = "Show Teacher Info";
            this.teacherlistbutton.UseVisualStyleBackColor = true;
            this.teacherlistbutton.Click += new System.EventHandler(this.teacherlistbutton_Click);
            // 
            // studentlistbutton
            // 
            this.studentlistbutton.Location = new System.Drawing.Point(78, 409);
            this.studentlistbutton.Name = "studentlistbutton";
            this.studentlistbutton.Size = new System.Drawing.Size(133, 23);
            this.studentlistbutton.TabIndex = 25;
            this.studentlistbutton.Text = "Show Student Info";
            this.studentlistbutton.UseVisualStyleBackColor = true;
            this.studentlistbutton.Click += new System.EventHandler(this.studentlistbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentlistbutton);
            this.Controls.Add(this.teacherlistbutton);
            this.Controls.Add(this.teacherlistbox);
            this.Controls.Add(this.studentlistbox);
            this.Controls.Add(this.teacherclearbutton);
            this.Controls.Add(this.teachersavebutton);
            this.Controls.Add(this.Studentclearbutton);
            this.Controls.Add(this.studentsavebutton);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.designationTxt);
            this.Controls.Add(this.teacherdepartmentTxt);
            this.Controls.Add(this.teachernameTxt);
            this.Controls.Add(this.teacheridTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.semesterTxt);
            this.Controls.Add(this.studentdepartmentTxt);
            this.Controls.Add(this.studentnameTxt);
            this.Controls.Add(this.studentidTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentidTxt;
        private System.Windows.Forms.TextBox studentnameTxt;
        private System.Windows.Forms.TextBox studentdepartmentTxt;
        private System.Windows.Forms.TextBox semesterTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox teacheridTxt;
        private System.Windows.Forms.TextBox teachernameTxt;
        private System.Windows.Forms.TextBox teacherdepartmentTxt;
        private System.Windows.Forms.TextBox designationTxt;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Button studentsavebutton;
        private System.Windows.Forms.Button Studentclearbutton;
        private System.Windows.Forms.Button teachersavebutton;
        private System.Windows.Forms.Button teacherclearbutton;
        private System.Windows.Forms.ListBox studentlistbox;
        private System.Windows.Forms.ListBox teacherlistbox;
        private System.Windows.Forms.Button teacherlistbutton;
        private System.Windows.Forms.Button studentlistbutton;
    }
}

