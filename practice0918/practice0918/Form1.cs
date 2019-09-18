using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice0918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer("Jeongyeon", "Ro", new DateTime(2000, 01, 01), 26);
            cus.address = "Seoul 1234";

            cusFirstName.Text = cus.firstName;
            cusLastName.Text = cus.lastName;

            //숫자(int) -> 텍스트(string) 으로 변환
            //cusAge.Text = cus.getAge().ToString();

            //cusFullName.Text = cus.getFullName();
            cusFullName.Text = cus.fullName;

            cusAge.Text = cus.Age.ToString();


            cusAddress.Text = cus.address;
            cusDescription.Text = cus.description;

            cusIsQualified.Text = cus.isQualified.ToString();

            //bool test = cus.getIsQualified();
            bool test = cus.isQualified;

            DateTime date = new DateTime(2019, 9, 18);
            DateTime current = DateTime.Now;

            currentDay.Text = current.ToString();

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
