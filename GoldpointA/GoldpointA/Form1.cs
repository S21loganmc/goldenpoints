using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goldpoint1._0
{
    public partial class GoldPoint : Form
    {
        public GoldPoint()
        {
            InitializeComponent();
        }
        private int Players = 0;
        private double[] numbers = new double[10];
        private int[] socer = { 0,0,0,0,0,0,0,0,0,0,0};//new int [10];
        private double Sum = 0,min,temp,max;
        private int i, j;
        private int maxno, minno;

        private void button5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //重置
        {
            Players = 0;
            Sum = min = temp = max = 0;
            maxno = minno = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = 0;
                socer[i] = 0;
            }
            label2.Text = "玩家：";
            label5.Text = "G点:";
            label6.Text = " 玩家1 " + "玩家2 " + "玩家3 " + "玩家4 " + "玩家5 " + "玩家6 " + "玩家7 " + "玩家8 " + "玩家9 " + "玩家10 " + "\n" + "    " + Convert.ToString(socer[0]) + "       " + Convert.ToString(socer[1]) + "       " + Convert.ToString(socer[2]) + "       " + Convert.ToString(socer[3]) + "       " + Convert.ToString(socer[4]) + "       " + Convert.ToString(socer[5]) + "       " + Convert.ToString(socer[6]) + "       " + Convert.ToString(socer[7]) + "        " + Convert.ToString(socer[8]) + "       " + Convert.ToString(socer[9]) + "       ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Players = 0;
            Sum = min = temp = max = 0;
            maxno = minno = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = 0;
            }
            label2.Text = "玩家" + Convert.ToString(Players+1) + ":";
            textBox1.Enabled = true;
            label6.Text = " 玩家1 " + "玩家2 " + "玩家3 " + "玩家4 " + "玩家5 " + "玩家6 " + "玩家7 " + "玩家8 " + "玩家9 " + "玩家10 " + "\n" + "    " + Convert.ToString(socer[0]) + "       " + Convert.ToString(socer[1]) + "       " + Convert.ToString(socer[2]) + "       " + Convert.ToString(socer[3]) + "       " + Convert.ToString(socer[4]) + "       " + Convert.ToString(socer[5]) + "       " + Convert.ToString(socer[6]) + "       " + Convert.ToString(socer[7]) + "        " + Convert.ToString(socer[8]) + "       " + Convert.ToString(socer[9]) + "       ";
        }//开始

        private void button2_Click(object sender, EventArgs e)
        {
            if (Players <10)  //人数不到10个
            {
                numbers[Players] = Convert.ToDouble(textBox1.Text);
                Sum = Sum + numbers[Players];
                //button1_Click(this, e);
                Players++;
                if (Players<10)
                {
                    label2.Text = "玩家:" + Convert.ToString(Players+1);
                }
            }
        }//下一位

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(this, e);
            textBox1.Enabled = false;
            label5.Text = "G点：" +"\n"+ Convert.ToString(Sum * 0.0618);
            min = max = Math.Abs(numbers[i] - Sum * 0.0618);
            for (int pi = 0; pi < 10; pi++)
            {
                j = pi;
                temp = Math.Abs(numbers[i] - Sum * 0.0618);
                if (temp<min)
                {
                    min = temp;
                    minno = pi ;
                }
                if (temp>max)
                {
                    max = temp;
                    maxno = pi;
                }
                //max = Math.Abs(numbers[i] - Sum * 0.618);
            }
            socer[minno] = socer[minno] + 2;
            socer[maxno] = socer[maxno] - 1;
            
            label6.Text = " 玩家1 "  + "玩家2 "  + "玩家3 "  + "玩家4 "  + "玩家5 "  + "玩家6 "  + "玩家7 "  + "玩家8 "  + "玩家9 "  + "玩家10 "    + "\n" + "    " + Convert.ToString(socer[0]) + "       " + Convert.ToString(socer[1]) + "       " + Convert.ToString(socer[2]) + "       " + Convert.ToString(socer[3]) + "       " + Convert.ToString(socer[4]) +  "       " + Convert.ToString(socer[5]) + "       " + Convert.ToString(socer[6]) + "       " + Convert.ToString(socer[7]) + "        " + Convert.ToString(socer[8]) + "       " + Convert.ToString(socer[9]) + "       ";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }//统计
    }
}
