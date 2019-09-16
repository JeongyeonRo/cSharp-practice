using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0914Hello
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello c#";

            //int number1 = 1;
            //int number2 = 2;

            //int sum = number1 + number2;

            //label1.Text = sum.ToString(); 


        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            //데이터 타입을 변경하기 위해 - convert 툴을 사용
            //텍스트박스의 문자열을 숫자로 변경
            int number1 = Convert.ToInt32(sum1.Text);
            int number2 = Convert.ToInt32(sum2.Text);

            int sum = number1 + number2;

            //sumResult.Text = Convert.ToString(sum);
            sumResult.Text = sum.ToString();
        }
    }
}
