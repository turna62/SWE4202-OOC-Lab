using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Lab_4
{
    public partial class Form1 : Form
    {
        List<SingleRoom> singles = new List<SingleRoom>();
        List<DoubleRoom> doubles = new List<DoubleRoom>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            SingleRoom singleRoom = new SingleRoom();
            singleRoom.name = SingleNameTxt.Text;
            singleRoom.quantity = Convert.ToInt32(SingleQuantityTxt.Text);
            singleRoom.cost = 2000;
            if (SingleGameComb.SelectedItem.ToString()=="YES")
            {
                singleRoom.cost = singleRoom.cost + 1000;
            }
            if (SingleAcComb.SelectedItem.ToString()=="YES")
            {
                singleRoom.cost = singleRoom.cost + 500;
            }

            singles.Add(singleRoom);
            MessageBox.Show("You have ceated" + SingleQuantityTxt.Text + "single room. Each will cost" + singleRoom.cost);


        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            DoubleRoom doubleRoom = new DoubleRoom();
            doubleRoom.name = DoubleNameTxt.Text;
            doubleRoom.quantity= Convert.ToInt32(DoubleQuantityTxt.Text);
            doubleRoom.cost = 3500;

            if(DoubleAcComb.SelectedItem.ToString()=="YES")
            {
                doubleRoom.cost= doubleRoom.cost + 500;
            }
            if( DoubleBkfComb.SelectedItem.ToString()=="YES")
            {
                doubleRoom.cost=doubleRoom.cost + 500;
            }
            if( ExtraTvComb.SelectedItem.ToString()=="YES")
            {
                doubleRoom.cost=doubleRoom.cost+500;
            }
            doubles.Add(doubleRoom);
            MessageBox.Show("You have created" + DoubleQuantityTxt.Text + "double room. Each will cost" + doubleRoom.cost);
            
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            string rentname = RentNameTxt.Text;
            int quantity =Convert.ToInt32(RentQuantityTxt.Text);
            foreach(SingleRoom singleRoom in singles)
            {
                if(singleRoom.name == rentname)
                {
                    singleRoom.quantity = quantity-1;
                    MessageBox.Show("Room booking is successful and will cost you" + quantity * singleRoom.cost);
                }
            }
            foreach(DoubleRoom doubleRoom in doubles)
            {
                if(doubleRoom.name == rentname)
                {
                    doubleRoom.quantity = quantity-1;
                    MessageBox.Show("Room booking is successful and will cost you"+ quantity * doubleRoom.cost);
                }
            }


        }

        private void AvailableButton_Click(object sender, EventArgs e)
        {
            string name=AvailableNameTxt.Text;
            foreach (SingleRoom singleRoom in singles)
            {
                if(singleRoom.name == name)
                {
                    if(singleRoom.quantity>0)
                    {
                        AvailableRoomLabel.Text = singleRoom.quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Room unavailable!");
                    }
                }
            }

            foreach (DoubleRoom doubleRoom in doubles)
            {
                if(doubleRoom.name == name)
                {
                    if(doubleRoom.quantity>0)
                    
                    { AvailableRoomLabel.Text=doubleRoom.quantity.ToString();}
                
                  else
                  {
                        MessageBox.Show("Room Unavailable!");
                  }
                }
            }
        }
    }
}
