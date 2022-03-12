using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System2_Lab_6
{
    public partial class Form1 : Form

    {
        List<User> users=new List<User>();
        List<HMS> hMs=new List<HMS>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HMS.bookingid++;
            int staytime = Convert.ToInt32(dateTimePicker2.Value.Day) - Convert.ToInt32(dateTimePicker1.Value.Day);
            int roomchoice = 1;

            if (roomchoicecombo.SelectedItem.ToString()=="Single")
            {
                roomchoice = 1;
            }
            if (roomchoicecombo.SelectedItem.ToString() == "Double")
            {
                roomchoice = 2;
            }

            foreach (User user in users)
            {
               if(user.userid==userid1txt.Text)
                {
                    HMS hms = new HMS(user.userid, user.name, user.contactno, user.address, roomchoice, staytime, Convert.ToInt32(quantitycombo.SelectedItem));

                    hms.bookingID = HMS.bookingid;
                    hms.amount = Convert.ToInt32(quantitycombo.SelectedItem) * staytime * 500 * roomchoice;
                    HMS.totalamount = HMS.totalamount + hms.amount;
                    hMs.Add(hms);
                   MessageBox.Show("Booking placed for confirmation.Your booking id is " + HMS.bookingid);
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User(useridtxt.Text, nametxt.Text, contacttxt.Text, addresstxt.Text);
            users.Add(user);
            MessageBox.Show("User added successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HMS hms in hMs)
            {
                if (hms.bookingID == Convert.ToInt32(bookingidtxt.Text))
                {
                    hms.status = bookingidcombo.SelectedItem.ToString();
                    MessageBox.Show("Booking status updated");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           foreach(HMS hms in hMs)
            {
                if(hms.bookingID==Convert.ToInt32(bookingid1txt.Text))
                {
                    useridlbl.Text = hms.userid;
                    addresslbl.Text = hms.address;
                    usernamelbl.Text = hms.name;
                    statuslbl.Text = hms.status;
                    noofroomslbl.Text = hms.quantity.ToString();
                    amountlbl.Text=hms.amount.ToString();


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("User name" + "\t" + "No. of Rooms" + "\t" + "Amount");
            foreach (HMS hms in hMs)
            {
                listBox1.Items.Add(hms.name + "\t" + "\t" + hms.quantity + "\t" + "\t" + hms.amount);
                amount1lbl.Text = HMS.totalamount.ToString();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
