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
    public partial class logform : Form
    {
        public logform()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            GoldPoint a = new GoldPoint();
            if (usrname_textbox.Text.Equals("admin") && usrpwd_textbox.Text.Equals("admin"))
            {
                this.Hide();
                a.ShowDialog();
            }
            else
                MessageBox.Show("密码错误");
        }
    }
}
