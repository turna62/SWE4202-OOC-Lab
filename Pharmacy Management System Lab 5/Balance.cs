using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System_Lab_5
{
    internal class Balance
    {
        public string prevbalance;
        public string name;
        public string quantity;
        public string add;
        public string priceperpiece;

        public Balance(string prevbalance, string name, string quantity, string add, string priceperpiece)
            {
            this.prevbalance = prevbalance;
            this.name = name;
            this.quantity = quantity;
            this.add = add;
            this.priceperpiece = priceperpiece;
            }
    }
}
