using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book
    {
        public int id;
        public string tittle;
        public string author;
        public string publisher;
        public int quantity;


        public Book(int id, string tittle, string author, string publisher, int quantity)
        {
            this.id = id;
            this.tittle = tittle;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
        }

        public string history()
        {
            return this.id.ToString() + "\t" + this.tittle;
        }
    }
}
