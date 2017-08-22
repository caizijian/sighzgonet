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
        public int saveedit(string managername, string companyname, string mainbusiness, string  wechat, string  telephone,int id)
        {
            //功能：保存编辑框数据
            //CZJ 392067117@qq.com 2017/08/22
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select certification from host where id='"+id+"'";// + username.Text + "'and password='" + password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds, "gg");//查询结果填充数据集    

            //判断是否 dataset为空，dataset不为空但不存在表，dataset不为空存在表且表的行数不为0
            //返回对应值，1为成功，0为失败
            //CZJ 392067117@qq.com 2017/08/22 
            if (ds == null || ds.Tables.Count == 0 || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
            {
                string strcmd1 = "insert into user (managername,companyname,mainbusiness,wechat,telephone,id) VALUES ('" + managername + " ','" + companyname + "','" + mainbusiness + "','" + wechat + "','" + telephone + "'"+id+"')";
                MySqlCommand cmd1 = new MySqlCommand(strcmd1, con);
                cmd1.ExecuteNonQuery();
                return 1;
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                string strcmd2 = "UPDATE host SET managername = '" + managername + "',wechat = '" + wechat + "',telephone = '" + telephone + "',companyname ='"+ companyname+ "',mainbusiness ='" + mainbusiness + "' WHERE id = '" +id+"'";
                MySqlCommand cmd2 = new MySqlCommand(strcmd2, con);
                cmd2.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }


        }
    }
