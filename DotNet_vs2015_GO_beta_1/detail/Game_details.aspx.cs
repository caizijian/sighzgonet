using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SightzGo
{
    public partial class Game_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = global.CompetitionInfo(4);
            if (reader.Read())
            {
                Label1.Text = reader.GetString(1);
                Label2.Text = reader.GetString(4);
                Label3.Text = reader.GetString(8)+"~"+reader.GetString(9);
                Label4.Text = reader.GetString(12);
                Label5.Text = "10";
                Label6.Text = "445549fdnhvsfdsfeaqivhregujdasvbfgnhjcdzsxvcbgkmckzAyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyydddddddddddddddddddhhhhhhhhhhhhhhhhhhhsssssssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaadddddddddddddddddddddddddddddddddwwwwwwwwwwwwwi";
            }
            //GridView1_SelectedIndexChanged(sender,e);
            //判断登录状态；
            /* if (Session["name"] == null || Session["name"] == "")
             {
                 Response.Write("<script>alert(\"请先登录！\");</script>");
                 Response.Redirect("../system/login.aspx");
                 return;
             }*/

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("../system/login.aspx");
                return;
            }
            else
            {
                Response.Redirect("../paticipant/Jion_single.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("../system/login.aspx");
                return;
            }
            else
            {
                Response.Redirect("#");
            }
        }

        /*protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);
            //打开数据库  
            con.Open();
            //定义查询的sql语句  
            string cmd = "select * from competition";
            //  GridView1.DataSource=mysqlHelp.ExecuteDataTable(cmd);
            //声明一个数据适配器对象  
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd, con);
            //声明一个数据集对象  
            DataSet ds = new DataSet();
            //填充数据  
            sda.Fill(ds);
            //绑定数据源  
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }*/
    }
}