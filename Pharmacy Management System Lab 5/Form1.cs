using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System_Lab_5
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        List<Balance> balances = new List<Balance>();

            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicineName1Txt.Text = "";
            QuantityTxt.Text = "";
        }

        private void MedicineButton_Click(object sender, EventArgs e)
        {
            string prevbalance = PreviousBalanceTxt.Text;
            string name = MedicineNameTxt.Text;
            string quantity=NoofMedicineTxt.Text;
            string add=AddTxt.Text;
            string priceperpiece=PricePerPieceTxt.Text;

            Balance b = new Balance(prevbalance, name, quantity, add, priceperpiece);
            balances.Add(b);
            MessageBox.Show("Inventory has been updated");


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name=MedicineName1Txt.Text;
            string quantity=QuantityTxt.Text;

            Medicine m=new Medicine(name, quantity);
            medicines.Add(m);
            MessageBox.Show("Medicine has been sold");
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MedicineNameLabel.Text=MedicineNameTxt.Text;

            int balance;
            int quantity;
            int remaining;

            foreach(Balance b in balances)
            {
                if (MedicineNameTxt.Text==MedicineName1Txt.Text)
                {
                    balance=Convert.ToInt32(PreviousBalanceTxt.Text)+Convert.ToInt32(QuantityTxt.Text)*Convert.ToInt32(PricePerPieceTxt.Text);
                    CurrentBalanceLabel.Text=Convert.ToString(balance);
                    remaining = Convert.ToInt32(NoofMedicineTxt.Text) - Convert.ToInt32(QuantityTxt.Text) + Convert.ToInt32(AddTxt.Text);
                    QuantityRemainingLabel.Text=Convert.ToString(remaining);

                }
            }

        }
    }
}
