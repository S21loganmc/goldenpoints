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
            /*
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\MyDataBase1.mdf;Integrated Security=True;User Instance=True");//数据库接口
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from T_Users where UserName='" + RID.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            //如果reader.Read()的结果不为空, 则说明输入的用户名存在   
            if (reader.Read())
            {
                MessageBox.Show("已有相同用户名账户存在！");
            }
            else
            {
                cmd.CommandText="INSERT INTO UserInformation VALUES ('Gates', 'Bill', 'Xuanwumen 10', 'Beijing');
                Success form2 = new Success();
                form.Show();
            }
            */
            Success form2 = new Success();
            form2.Show();



        }
    }
}
