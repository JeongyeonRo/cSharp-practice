using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //데이터베이스와 c#을 연결 - 라이브러리 추가(using System.Data.SqlClient)
            SqlConnection con = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeongyeon\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter(
                "select count(*) from userinfo where username='" + ID_txt.Text + 
                "' and password='" + PW_txt.Text + "'", con);
            //데이터베이스에 있는 아이디와 비밀번호를 넣을 경우 1

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                //로그인 버튼을 클릭하면 로그인 폼을 숨김
                this.Hide();
                //메인폼을 띄움
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            //아이디와 비밀번호가 틀릴 경우
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            }

        }
    }
}
