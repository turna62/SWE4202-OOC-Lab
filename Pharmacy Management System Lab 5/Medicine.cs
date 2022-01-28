using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System_Lab_5
{
    internal class Medicine
    {
        public string name;
        public string quantity;

        public Medicine(string name, string quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
    }
}
