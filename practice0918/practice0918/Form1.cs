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
        public Customer cus1;
        public Customer cus2;

        public List<Customer> customers = new List<Customer>();

        /*
        Customer customerOne;
        Customer[] customerArray = new Customer[5];
        
        public int customerArrayIndex = 0;
        */


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            cus1 = new Customer(cusNewFirstName.Text, cusNewLastName.Text,
                DateTime.Parse(cusNewBirth.Text));
           
            cus1.address = cusNewAddress.Text;
            cus1.description = cusNewAddress.Text;

            cusFirstName.Text = cus1.firstName;
            cusLastName.Text = cus1.lastName;

            //숫자(int) -> 텍스트(string) 으로 변환
            //cusAge.Text = cus.getAge().ToString();

            //cusFullName.Text = cus.getFullName();
            cusFullName.Text = cus1.fullName;

            cusAge.Text = cus1.Age.ToString();


            cusAddress.Text = cus1.address;
            cusDescription.Text = cus1.description;

            cusIsQualified.Text = cus1.isQualified.ToString();

            //bool test = cus.getIsQualified();
            bool test = cus1.isQualified;

            DateTime date = new DateTime(2019, 9, 18);
            DateTime current = DateTime.Now;

            currentDay.Text = current.ToString();



            /*
            customerArray[0] = new Customer("firstName", "lastName",new DateTime(1994, 05, 17));
            customerArray[1] = new Customer("firstName", "lastName", new DateTime(1994, 05, 17));
            customerArray[2] = new Customer("firstName", "lastName", new DateTime(1994, 05, 17));
            customerArray[3] = new Customer("firstName", "lastName", new DateTime(1994, 05, 17));
            customerArray[4] = new Customer("firstName", "lastName", new DateTime(1994, 05, 17));
            */

            //반복문을 사용하기
            //for(초기식; 조건식; 증감식){ }

            /*
            customerArray[customerArrayIndex] = new Customer(cusFirstName.Text, cusNewLastName.Text,
                DateTime.Parse(cusNewBirth.Text));
            customerArray[customerArrayIndex].address = cusNewAddress.Text;
            customerArray[customerArrayIndex].description = cusNewDescription.Text;

            customerList.Items.Add(customerArray[customerArrayIndex].firstName);

            customerArrayIndex++;
            */

            Customer cus = new Customer(cusFirstName.Text, cusNewLastName.Text,
               DateTime.Parse(cusNewBirth.Text));
            cus.address = cusNewAddress.Text;
            cus.description = cusNewDescription.Text;

            customerList.Items.Add(cus.firstName);

            customers.Add(cus);

            //cusList.Rows.Add("name", 12, true);
            cusList.Rows.Add(cus.firstName, cus.Age, cus.isQualified);


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

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void showDetails(Customer cus)
        {
            cusFullName.Text = cus.fullName;
            cusAge.Text = cus.Age.ToString();
            cusAddress.Text = cus.address;
            cusDescription.Text = cus.description;
            cusIsQualified.Text = cus.isQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = customerList.SelectedItem.ToString();

            //이름을 가지고 고객 데이터 가져오기
            /*
            for(int i=0; i<customerArrayIndex; i++)
            {
                if(customerArray[i].firstName == firstName)
                {
                    showDetails(customerArray[i]);
                    break;
                }
            }
            */

            foreach(Customer cus in customers)
            {
                if(cus.firstName == firstName)
                {
                    showDetails(cus);
                    break;
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택된 열의 인덱스를 이용해서 클릭이벤트 처리
            string firstName = (string)cusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in customers)
            {
                if (cus.firstName == firstName)
                {
                    showDetails(cus);
                    break;
                }
            }
        }
    }
}
