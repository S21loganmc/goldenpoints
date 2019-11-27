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
using database;

namespace WindowsFormsApplication1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void Sqlopreate(string c)
        {
            //C为数据库命令
            SqlConnection con = new SqlConnection("server=.;database=data1220;user=sa;pwd=123");//数据库连接
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = c;
            con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void login2_Click(object sender, EventArgs e)
        {
            add a = new add();
            if (a.add_user(RID.Text, Rpassword.Text))
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
            else
                MessageBox.Show("用户名已存在");
           // Success form2 = new Success();
           // form2.Show();



        }

        private void RID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
