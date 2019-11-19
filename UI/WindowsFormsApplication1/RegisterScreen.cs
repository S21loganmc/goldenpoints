using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginScreen form = new LoginScreen();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登录成功!");
            MainScreen m = new MainScreen(ID);
            m.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登录成功!");
            MainScreen m = new MainScreen();
            m.Show();
        }
    }
}
