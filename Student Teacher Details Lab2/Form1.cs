using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        List<Teacher> teachers=new List<Teacher>();
        List<Student> students=new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentidTxt.Text = "";
            studentnameTxt.Text = "";
            studentdepartmentTxt.Text = "";
            semesterTxt.Text = "";
            MessageBox.Show("Details are cleared successfully");
        }

        private void studentsavebutton_Click(object sender, EventArgs e)
        {
            Student s=new Student();

            s.setstudentinfo(studentidTxt.Text, studentnameTxt.Text, studentdepartmentTxt.Text, semesterTxt.Text);
            students.Add(s);
            MessageBox.Show("Details are saved successfully");
        }

        private void teachersavebutton_Click(object sender, EventArgs e)
        {
            Teacher t= new Teacher();
            t.setteacherinfo(teacheridTxt.Text, teachernameTxt.Text,teacherdepartmentTxt.Text,designationTxt.Text,salaryTxt.Text);
            teachers.Add(t);
            MessageBox.Show("Details are saved successfully");
        }

        private void teacherclearbutton_Click(object sender, EventArgs e)
        {
            teacheridTxt.Text = "";
            teachernameTxt.Text = "";
            teacherdepartmentTxt.Text = "";
            designationTxt.Text = "";
            salaryTxt.Text = "";
            MessageBox.Show("Details are cleared successfully");
        }

        private void studentlistbutton_Click(object sender, EventArgs e)
        {
            studentlistbox.Items.Clear();
            for (int i = 0; i < students.Count;i++)
            {
                studentlistbox.Items.Add(students[i].getstudentinfo());
            }
        }

        private void teacherlistbutton_Click(object sender, EventArgs e)
        {
            teacherlistbox.Items.Clear();
            for(int i = 0;i < students.Count;i++)
            {
                teacherlistbox.Items.Add(teachers[i].getteacherinfo());
            }
        }
    }
}
