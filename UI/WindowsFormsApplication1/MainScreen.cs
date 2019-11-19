using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class MainScreen : Form
    {
        int G;//用户输入的值
        double goldenpoint;//黄金点结果值
        static double score;//用户分数
        static int count = 0;
        string round="0";
        string NumSubMit;//数字提交个数
        static string TimeRound;//每回合时间
        string NumAllround;//总回合数
        string NumPlayer;//总人数
        string NumHouse;//房间号
        int count1 = 1;
        public MainScreen(TextBox id)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = false;
            Submit.Visible = false;
            PlayerName.Text = id.ToString() ;
            Times.Text = round.ToString();
           
            
        }
        public MainScreen()
        {
            InitializeComponent();
            Submit.Visible = false;
            timer1.Enabled = false;
            Num.Enabled = false;
            PlayerName.Text = GenerateRandomNumber(6);
        }
        private void ScoreCalculate(int G)// 计算得分
        {
            score+=System.Math.Abs(G - goldenpoint);
        }
        private static char[] constant =
     {
        '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
      };
        public static string GenerateRandomNumber(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record.DefaultCellStyle.BackColor = Color.Transparent;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void CreateRoom_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.TransfEventTimeRound += r_TransfEventTimeRound;
            r.TransfEventAllPlayer += r_TransfEventAllPlayer;
            r.TransfEventNumSubmit += r_TransfEventNumSubmit;
            r.TransfEventNumHouse += r_TransfEventNumHouse;
            Submit.Visible = true;
            CreateRoom.Enabled = false;
            r.ShowDialog();
            RoomNum.Text = NumHouse;
        }
        void r_TransfEventTimeRound(string value)
        {
            TimeRound = value;
        }
        void r_TransfEventNumSubmit(string value)
        {
            NumSubMit = value;
        }
        void r_TransfEventAllPlayer(string value)
        {
            NumPlayer = value;
        }
        void r_TransfEventNumHouse(string value)
        {
            NumHouse = value;
        }
        private void Num_TextChanged(object sender, EventArgs e)
        {
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入数字和小数点
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (Num.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(Num.Text, out oldf);
                    b2 = float.TryParse(Num.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void Num_Enter(object sender, EventArgs e)
        {
        }

        private void Num_Leave(object sender, EventArgs e)
        {
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void PlayerName_Click(object sender, EventArgs e)
        {

        }

        private void RoomNum_Click(object sender, EventArgs e)
        {

        }

        private void LeftTime_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num.Text))
            {
                G = int.Parse(Num.Text);
                count = int.Parse(Times.Text);
                count++;
                round = count.ToString();
                Num.Enabled = false;
            }
            else
                MessageBox.Show("输入不能为空");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Num.Enabled = true;
            this.timer1.Enabled = true;
            this.timer1.Start();
            this.Times.Text = round;
        }

        private void Times_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeftTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count1++;
            this.LeftTime.Text = (count1).ToString();
            if (count1 == int.Parse(TimeRound))
            {
                timer1.Stop();
                CreateRoom.Enabled = true;
                MessageBox.Show("本局游戏结束，请开始新的对局吧");
                this.Hide();
                MainScreen main = new MainScreen();
                main.Show();
               // MessageBox.Show("本次胜利者为{0}", PlayerName.ToString());
            }
        }
    }
}
