using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice0917
{
    public partial class Form1 : Form
    {
        //
        private cat mycat = new cat("JoA", 1);

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            mycat.play();
            catScreen.Text = mycat.express();

        }

        private void Feed_Click(object sender, EventArgs e)
        {
            mycat.eat();
            catScreen.Text = mycat.express();

        }

        //프로그램이 시작된 후 5초마다 타이머 작동
        private void CatTimer_Tick(object sender, EventArgs e)
        {
            mycat.borded();
            catScreen.Text = mycat.express();
        }
    }

}
