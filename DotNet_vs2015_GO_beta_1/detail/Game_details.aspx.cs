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
            //String competiton_id = Session["competiton_id"].ToString();
            String competiton_id = "099c182ed2f041afb73a7c1145d3d789";
            MySqlDataReader reader = global.CompetitionInfo(competiton_id);
            //查询比赛详情，需要提交[赛事ID]
            //传入赛事ID需为int型
            //如果传入参数不为int型，将会发生错误，无法运行
            //LG 289855991@qq.com 2017/08/19
            if (reader.Read())
            {
                Label1.Text = reader.GetString(1);
                Label2.Text = reader.GetString(4);
                Label3.Text = reader.GetDateTime(8)+"<br />~"+reader.GetDateTime(9);
                Label4.Text = reader.GetString(12);

                //计算报名截止剩余天数，无需传参
                //暂时未加入[判断]是否为负数
                //LG 289855991@qq.com 2017/08/19
                {
                    DateTime ddl = reader.GetDateTime(8);
                    DateTime dt = DateTime.Now;
                    System.TimeSpan time = ddl - dt;
                    string timeStr_tran = time.TotalDays.ToString();
                    string timeStr = Math.Floor(Convert.ToDouble(timeStr_tran)).ToString();
                    Label5.Text = timeStr;
                }                
                Label6.Text = reader.GetString(4);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //判断用户是否登录，读取session
            //如果session["uid"]为空，跳转到登陆页面
            //LG 289855991@qq.com 2017/08/19
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