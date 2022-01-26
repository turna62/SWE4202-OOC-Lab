using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
       List<car1> Cars = new List<car1>();
       List<user1> Users = new List<user1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveb_Click(object sender, EventArgs e)
        {
            user1 user = new user1(UserIDTextbox.Text, UserNameTextbox.Text, AddressTextbox.Text, DestinationTextbox.Text);
            Users.Add(user);
            MessageBox.Show("User has been added successfully");
        }

        private void rentcar_Click(object sender, EventArgs e)
        {
            string userid = UserID2Textbox.Text;
            string carname= CarName1Textbox.Text;
            foreach(car1 car in Cars)
            {
                 foreach(user1 user in Users)
                {
                    if(userid==user.userid)
                    {
                        user.rentedcarname = CarName1Textbox.Text;
                    }
                    if(carname==car.carname)
                    {
                        car.carquantity = car.carquantity - 1;
                    }
                }
            }
            MessageBox.Show("Car rented successfully");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carname1l_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveCarButton_Click(object sender, EventArgs e)
        {
            car1 car = new car1(CarNameTextbox.Text, CarModelTextbox.Text,Convert.ToInt32(CarQuantityTextbox.Text));
            Cars.Add(car);
            MessageBox.Show("Car has been added successfully");
        }

        private void UserHistoryButton_Click(object sender, EventArgs e)
        {
            string uid=UserID1Textbox.Text;
            foreach(user1 user in Users)
            {
                if(uid==user.userid)
                {
                    UserNameLabel.Text = user.username;
                    AddressLabel.Text = user.useraddress;
                    RentedCarLebel.Text = user.rentedcarname;
                    DestinationLabel.Text = user.userdestination;
                }
            }
        }

        private void CarHistoryButton_Click(object sender, EventArgs e)
        {
            string carname = CarName2Textbox.Text;
            string carmodel= CarModel1Textbox.Text;
            foreach(car1 car in Cars)
            {
                if(carname==car.carname)
                {
                    CarQuantity1Textbox.Text = car.carquantity.ToString();
                }
            }
        }

        private void UserID1Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
