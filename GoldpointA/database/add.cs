using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace database
{
    public class add
    {
        public bool add_user(string ID,string password)
        {

            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            string time = DateTime.Now.ToLongDateString().ToString();

            SqlCommand cmd = new SqlCommand();
            //指定连接对象
            cmd.Connection = con;
            //执行SQL命令
            cmd.CommandText = "insert into usersinformation(ID,password,time,usertype) values ('"+ ID + "','" + password + "','" + time + "','p')";
            //数据库执行后返回受影响部门的行数
            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                return true;
            }
            else
                return false;
            //关闭数据库的连接
            con.Close();
                }
        public bool add_logintimes(string username)
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Usersinformation set logintimes=logintimes+1 where ID='"+username+"'"; 

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool add_score(string username,int playernumber)
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Usersinformation set score=score+'"+playernumber+"' where ID='" + username + "'";

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool reduce_score(string username)
        {
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Usersinformation set score=score-2 where ID='" + username + "'";

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool add_usrgamedata(string[] usrname, int[] usrG, double G)
        {
            int i;
            i = usrname.Count();
            string constr = "Server=tcp:goldpoint.database.windows.net,1433;Initial Catalog=goldenpoint;Persist Security Info=False;User ID=admin1;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            int r = 1;
            //for (int n = 0; n < i; n++,r++)
            //{
            //    cmd.CommandText = "insert into gamedata(" + "username" + r + ",predition" + r + ",playertype" + r + ") values('" + usrname[n] + "','" + usrG[n] + "','" + usrtype[n] + "')";
            //   if (cmd.ExecuteNonQuery() == 1)
            //        boolg[n] = true;
            //}
            cmd.CommandText = "insert into gamedata(username1,prediction1,username2,prediction2,username3,prediction3,username4,prediction4,username5,prediction5,username6,prediction6,username7,prediction7,G) VALUES ('" + usrname[0] + "','" + usrG[0]  + "','" + usrname[1] + "','" + usrG[1] + "','"  + usrname[2] + "','" + usrG[2] +  "','" + usrname[3] + "','" + usrG[3] + "','" + usrname[4] + "','" + usrG[4] + "','"  + usrname[5] + "','" + usrG[5] + "','" + usrname[6] + "','" + usrG[6] + "','"  + G + "')";

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
