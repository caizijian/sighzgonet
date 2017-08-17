using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace edit
{
    public class EDITOR
    {
        public int saveedit(string managername, string companyname, string mainbusiness, string  wechat, string  telephone)
        {
            string str = "Server=localhost;User ID=root;Password=1234qwer;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select sertification from host where id=105";// + username.Text + "'and password='" + password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds, "gg");//查询结果填充数据集     
            if (ds == null || ds.Tables.Count == 0 || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
            {
                string strcmd1 = "insert into user (managername,companyname,mainbusiness,wechat,telephone) VALUES ('" + managername + " ','" + companyname + "','" + mainbusiness + "','" + wechat + "','" + telephone + "')";
                MySqlCommand cmd1 = new MySqlCommand(strcmd1, con);
                cmd1.ExecuteNonQuery();
                return 1;
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                string strcmd2 = "UPDATE host SET managername = '" + managername + "',wechat = '" + wechat + "',telephone = '" + telephone + "' WHERE id = '105'";
                MySqlCommand cmd2 = new MySqlCommand(strcmd2, con);
                cmd2.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int show()
        {
            string str = "Server=localhost;User ID=root;Password=1234qwer;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select * from host where id=106";// + username.Text + "'and password='" + password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds, "gg");//查询结果填充数据集     
            if (ds == null || ds.Tables.Count == 0 || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
            {
                return 1;
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                //_readonly.changelabel(ds);
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}