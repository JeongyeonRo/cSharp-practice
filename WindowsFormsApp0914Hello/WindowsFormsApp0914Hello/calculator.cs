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
    //연산자 열거형 데이터 선언
    public enum operators {add, sub, mul, div };


    public partial class calculator : Form
    {
        //더하기 값을 저장하기 위한 변수
        public int result = 0;
        //숫자의 시작을 알기 위한 변수 설정
        public bool isNewNum = true;

        public operators opt = operators.add;


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
            int number1, number2 = 0;

            //텍스트 박스의 유효성 검사
            //텍스트 박스에 공백으로 작성하거나 빈칸이 있을 경우 경고 창을 출력
            //문자를 작성할 경우 경고 창을 출력

            //string객체 안의 함수 - 매개변수로 String 을 받아서 리턴값은 bool
            //WhiteSpace - 공백문자열, tab
            //String.IsNullOrWhiteSpace();

            //텍스트박스안이 빈 문자열이면 경고창 발생
            //if(sum1.Text.Trim() == "" || sum2.Text.Trim() == "")
            if (String.IsNullOrWhiteSpace(sum1.Text) || 
                    String.IsNullOrWhiteSpace(sum2.Text))
            {
                MessageBox.Show("더할 숫자를 입력해주세요");
                return;
            }

            //텍스트 박스의 문자열을 숫자 데이터 타입으로 변경
            if(int.TryParse(sum1.Text,out number1) == false)
            {
                //텍스트 박스의 문자열에 문자가 있을 경우
                MessageBox.Show("숫자만 입력해주세요");
                //포커스를 이동
                sum1.Focus();
                //작성된 문자열을 선택
                sum1.SelectAll();
                return;
            }
            if (int.TryParse(sum2.Text, out number2) == false)
            {
                //텍스트 박스의 문자열에 문자가 있을 경우
                MessageBox.Show("숫자만 입력해주세요");
                //포커스를 이동
                sum2.Focus();
                //작성된 문자열을 선택
                sum2.SelectAll();
                return;
            }

            //다른 방법으로 유효성 검사를 하는 방법
            //-입력창에 제한

            //데이터 타입을 변경하기 위해 - convert 툴을 사용
            //텍스트박스의 문자열을 숫자로 변경
            number1 = Convert.ToInt32(sum1.Text);
            number2 = Convert.ToInt32(sum2.Text);

            //int sum = number1 + number2;

            //add 함수를 생성해서 사용하기
            int sum = add(number1, number2);

            //sumResult.Text = Convert.ToString(sum);
            sumResult.Text = sum.ToString();
        }

        //함수의 프로토 타입 - 데이터 타입을 맞추기
        public int add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        //함수의 오버로딩 - 메소드 중복정의
        public float add(float num1, float num2)
        {
            float sum = num1 + num2;
            return sum;
        }

        public int sub(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            /*
            if(numResult.Text == "0")
            {
                numResult.Text = "1";
            }else
            numResult.Text = numResult.Text + "1";
            */

            Button button1 = (Button)sender;
            setNum(button1.Text);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            if(numResult.Text == "0")
            {
                numResult.Text = "2";
            }else
            numResult.Text = numResult.Text + "2";
            */
            
            setNum("2");
        }

        public void setNum(string num)
        {
            if (isNewNum)
            {
                //isNewNum의 값이 true일 경우-처음화면 또는 연산버튼이 클릭된 경우
                // 실행하는 코드 작성

                //새로운 숫자의 시작이 num
                numResult.Text = num;
                //새로운 숫자의 시작이 아님을 나타내기 위해 false로 변경
                isNewNum = false;
            }
            else
            {
                if (numResult.Text == "0")
                {
                    numResult.Text = num;
                }
                else
                {
                    numResult.Text = numResult.Text + num;

                }
            }
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                //int num = Convert.ToInt32(numResult.Text);
                int num = int.Parse(numResult.Text);
                if (opt == operators.add)
                    result = result + num;
                else if (opt == operators.sub)
                    result = result - num;

                numResult.Text = result.ToString();

                //새로운 숫자를 입력받기 위해 변수 값 변경
                isNewNum = true;
            }

            Button optBtn = (Button)sender;
            if (optBtn.Text == "+")
                opt = operators.add;
            else if (optBtn.Text == "-")
                opt = operators.sub;
        }

        //계산식을 초기화 시키는 메소드
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            result = 0;
            isNewNum = true;
            opt = operators.add;
            numResult.Text = "0";
        }
    }
}
