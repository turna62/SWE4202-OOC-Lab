using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Car
    {
        public string carname;
        public string carmodel;
        public string carquantity;

        public Car (string carname, string carmodel, string carquantity)
        {
            this.carname = carname;
            this.carmodel = carmodel;
            this.carquantity = carquantity;
        }
    }
}
