using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();    


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDTextBox.Text);
            string title = BookTittleTextBox.Text;
            string author = AuthorTextBox.Text;
            string publisher=PublisherTextBox.Text;
            int quantity=Convert.ToInt32(QuantityTextBox.Text);

            if(quantity<0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Book dummy=new Book(id,title,author,publisher,quantity);

            books.Add(dummy);
            MessageBox.Show("Book has been added successfully!");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDTextBox.Text);
            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;

            User dummy = new User(id, name, address);
            users.Add(dummy);
            MessageBox.Show("User has been added successfully!");
        }
    }
}
