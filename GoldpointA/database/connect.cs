using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class connect
    {
        string constr = "Server=ASUS;DataBase=goldenpoint;Trusted_Connection=SSPI";
        // 建立SqlConnection对象

        // 打开连接
        public void opendatabase()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

        }

        public void closedatabase()
        {

            SqlConnection con = new SqlConnection(constr);
            con.Close();
        }
    }
}

