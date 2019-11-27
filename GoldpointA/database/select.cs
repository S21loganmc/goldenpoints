using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace database
{
    public class select
    {
        public SqlDataAdapter select_username()
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand com = new SqlCommand("select ID from usersinformation  ");
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            return da;

        }
        public bool select_password(string usrname, string pwd)
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string commtext = string.Format("select ID,password from Usersinformation where ID='{0}' and password='{1}'", usrname, pwd);
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandText = commtext;
            SqlDataReader sdr = comm.ExecuteReader();
            if (sdr.HasRows)
                return true;
            else
                return false;

        }
        public SqlDataAdapter select_gamedata(int times)
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand com = new SqlCommand("select * from gamedata  where times='" + times + "'");
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            return da;

        }
        public double[] returnGofNrounds(int n)
        {
            int tmpi;
            int rowvalue;
            double[] ng = new double[n+1];
            var list = new List<string>();
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string commandtext2 = "select * from gamedata";
            SqlCommand comm2 = new SqlCommand();
            comm2.Connection = con;
            comm2.CommandText = commandtext2;
            SqlDataReader sdr2 = comm2.ExecuteReader();
            //string rowvaluestring = sdr2[0].ToString();
            rowvalue = sdr2.FieldCount;
            sdr2.Close();
            string commandtext1 = "select TOP " + n + " G from gamedata";
            SqlCommand cmd = new SqlCommand(commandtext1, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int k = 0;
            while (rdr.Read())
            {
                list.Add(rdr[0].ToString());
            }
            int tmpk = list.Count;
            for (tmpi = 0; tmpi < rowvalue - tmpi; tmpi++)
            {
                list.Add("0");
            }
            for (; k < n; k++)
            {
                ng[k] = double.Parse(list[k]);
            }
            con.Close();
            return ng;
        }

    }
}
