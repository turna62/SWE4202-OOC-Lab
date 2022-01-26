using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class User
    {
        public string userid;
        public string username;
        public string useraddress;
        public string userdestination;
        public string rentedcarname;
        
        public User (string userid, string username, string useraddress, string userdestination)
        {
            this.userid = userid;
            this.username = username;
            this.useraddress = useraddress;
            this.userdestination = userdestination;
        }
        
    }
}
