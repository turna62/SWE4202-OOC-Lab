using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System2_Lab_6
{
    internal class User
    {
        public string userid;
        public string name;
        public string contactno;
        public string address;

        public User(string userid, string name, string contactno, string address)
        {
            this.userid = userid;
            this.name = name;
            this.contactno = contactno;
            this.address = address;
        }
    }
}
