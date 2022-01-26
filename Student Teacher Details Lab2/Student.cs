using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Student
    {
        private string studentid;
        private string studentname;
        private string studentdepartment;
        private string semester;

        public void setstudentinfo(string studentid, string studentname, string studentdepartment, string semester)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.studentdepartment = studentdepartment;
            this.semester = semester;
        }

        public string getstudentinfo()
        {
            string studentinfo = studentid + "\t" + studentname + "\t" + studentdepartment + "\t" + semester;
            return studentinfo;
        }
    }
}
