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

        private string maxmember;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["competition_id"] == null)
            {
                Response.Write("<script>alert('查询不到此比赛！');location.href='../system/Home.html';</script>");
                return;
            }
            else
            {
                String competition_id = Session["competition_id"].ToString();
                MySqlDataReader reader = global.CompetitionInfo(competition_id);
                MySqlDataReader reader_com_to_host = global.com_hostInfo(competition_id);
                //查询比赛详情，需要提交[赛事ID]
                //传入赛事ID需为String型
                //如果传入参数不为String型，将会发生错误，无法运行
                //LG 289855991@qq.com 2017/08/19
                if (reader.Read() && reader_com_to_host.Read())
                {
                    Label1.Text = reader.GetString(1);
                    Label2.Text = reader_com_to_host.GetString(0);
                    int host_id = reader_com_to_host.GetInt32(0);
                    MySqlDataReader reader_host = global.HostInfo(host_id);
                    if (reader_host.Read())
                    {
                        Label2.Text = reader_host.GetString(1);
                    }
                    Label3.Text = reader.GetDateTime(8)
                        + "<br/>~" + reader.GetDateTime(9);
                    Label4.Text = reader.GetString(12);
                    maxmember = reader.GetString(11);

                    //计算报名截止剩余天数，无需传参
                    //LG 289855991@qq.com 2017/08/19
                    {
                        DateTime ddl = reader.GetDateTime(7);
                        DateTime end = reader.GetDateTime(9);
                        DateTime dt = DateTime.Now;

                        //计算并判断时间差是否为负值，输出不同内容
                        //无需传参
                        //注意所有对比均为时间型
                        //LG 289855991@qq.com 2017/08/22
                        if (DateTime.Compare(ddl, dt) > 0)
                        {
                            System.TimeSpan time = ddl - dt;
                            string timeStr_tran = time.TotalDays.ToString();
                            string timeStr = Math.Floor(Convert.ToDouble(timeStr_tran)).ToString();
                            Label5.Text = timeStr;
                        }
                        else
                        {
                            ddl_left.InnerText = null;
                            ddl_right.InnerText = null;
                            Label5.Style["font-size"] = "20px";
                            Label5.Text = "报名已截止";
                            Button1.Style["display"] = "none";
                            Button2.Style["left"] = "0";
                        }
                        if (DateTime.Compare(end, dt) < 0)
                        {
                            Button2.Style["display"] = "none";
                        }
                    }
                    //由于[发起比赛]未上传正文，暂时注销掉，便于测试
                    //Label6.Text = reader.GetString(4);
                }
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
            //判断最多参赛选手，跳转到相应报名界面
            //无需传参
            //maxmember为String型
            //LG 289855991@qq.com 2017/08/22
            else if ( maxmember == "1" )
            {
                Response.Redirect("../paticipant/Jion_single.aspx");
            }
            else
            {
                Response.Redirect("../paticipant/Jion_team.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //判断用户是否登录，读取session
            //如果session["uid"]为空，跳转到登陆页面，否则跳转到上传作品界面
            //LG 289855991@qq.com 2017/08/19
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
    }
}