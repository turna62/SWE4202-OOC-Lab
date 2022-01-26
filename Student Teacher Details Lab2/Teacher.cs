using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Teacher
    {
        private string teacherid;
        private string teachername;
        private string teacherdepartment;
        private string designation;
        private string salary;

        public void setteacherinfo(string teacherid, string teachername, string teacherdepartment, string designation, string salary)
        {
            this.teacherid = teacherid;
            this.teachername = teachername;
            this.teacherdepartment = teacherdepartment;
            this.designation = designation;
            this.salary = salary;
        }

        public string getteacherinfo()
        {
            string teacherinfo= teacherid + "\t" + teachername + "\t" + teacherdepartment + "\t" + designation + "\t" + salary;    
            return teacherinfo;
        }
    }
}
