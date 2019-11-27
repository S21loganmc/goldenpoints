using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate void TransfDelegate(String value);
    public partial class Room : Form
    {
        int NumSubMit=1;
        int TimeRound=5;
        int NumPlayer=10;
        int NumHouse;
        public Room()
        {
            InitializeComponent();
        }
       public event TransfDelegate TransfEventNumSubmit;
        public event TransfDelegate TransfEventTimeRound;
       public event TransfDelegate TransfEventAllPlayer;
        public event TransfDelegate TransfEventNumHouse;

        private void ConfirmRoom_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            NumHouse = ran.Next(5, 100);
            //NumSubMit = int.Parse(PlaySubmit.Text);
            TimeRound = int.Parse(RoundTime.Text);
           // NumPlayer = int.Parse(AllPlayer.Text);
            TransfEventNumSubmit(NumSubMit.ToString());
            TransfEventTimeRound(TimeRound.ToString());
            //TransfEventAllPlayer(AllPlayer.ToString());
            TransfEventNumHouse(NumHouse.ToString());
            this.Close();
            MessageBox.Show("创建成功");
        }
        private void PlaySubmit_TextChanged(object sender, EventArgs e)
        {
        }
        private void AllRounds_TextChanged(object sender, EventArgs e)
        {
        }
        private void AllPlayer_TextChanged(object sender, EventArgs e)
        {
        }
        private void RoundTime_TextChanged(object sender, EventArgs e)
        {
        }
        private void PlaySubmit_Leave(object sender, EventArgs e)
        {/*
            if (string.IsNullOrEmpty(PlaySubmit.Text))
            {
                PlaySubmit.ForeColor = Color.Red;
                this.PlaySubmit.Text = "默认为1";
            }
            */
        }
        private void PlaySubmit_Enter(object sender, EventArgs e)
        {/*
            if (PlaySubmit.Text == "默认为1")
            {
                this.PlaySubmit.Text = "";
            }

        */
        }


        private void AllPlayer_Leave(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(AllPlayer.Text))
            {
                AllPlayer.ForeColor = Color.Red;
                this.AllPlayer.Text = "默认为5";
            }*/
        }
        private void AllPlayer_Enter(object sender, EventArgs e)
        {
            /*
            if (AllPlayer.Text == "默认为5")
            {
                this.AllPlayer.Text = "";
            }
            */
        }
        private void RoundTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RoundTime.Text))
            {
                RoundTime.ForeColor = Color.Red;
                this.RoundTime.Text = "默认为60";
            }
        }
        private void RoundTime_Enter(object sender, EventArgs e)
        {
            if (RoundTime.Text == "默认为60")
            {
                this.RoundTime.Text = "";
            }
        }

        private void PlaySubmit_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PlaySubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            //只能输入1或者2
            if (!(e.KeyChar == '\b' || (e.KeyChar == '1' || e.KeyChar == '2')))
            {
                e.Handled = true;
            }
            if (PlaySubmit.Text.Length > 1)
                e.Handled = true;
                */
        }

        private void RoundTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制每回合时间为0-999
            if (!(e.KeyChar == '\b' || (e.KeyChar > '0' && e.KeyChar <='9')))
            {
                e.Handled = true;
            }
        }

        private void AllRounds_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void AllRounds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar > '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void AllPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar > '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {/*
            if (checkBox2.Checked)
                AllPlayer.ReadOnly = false;
            else
                AllPlayer.ReadOnly = true;
                */
        }

        private void AllPlayer_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
