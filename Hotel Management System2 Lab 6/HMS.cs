using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System2_Lab_6
{
    internal class HMS:User
    {
        public static int bookingid=0;
        public int bookingID;
        public int roomchoice;
        public int quantity;
        public int staytime;
        public int amount;
        public string status="pending";
        public static int totalamount;

        public HMS(string userid, string name, string contactno, string address, int roomchoice, int quantity, int staytime):base(userid, name, contactno, address)
        {
            this.roomchoice = roomchoice;
            this.quantity = quantity;
            this.staytime = staytime;

        }
    }
}
