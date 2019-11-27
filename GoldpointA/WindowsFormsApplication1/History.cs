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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string contain = "select * from gamedata"; //获取TestSave表的数据信息
            SqlCommand cmd = new SqlCommand(contain, con); //执行sqlcommand命令，就可以执行sql命令了
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);  //ds=sda.Fill(ds);
            Record.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
