using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class _3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected bool check(string competitionname, string signupstarttime, string ddl,
            string starttime, string endtime, string maxbouns ,string minmember, string maxmember)
        {
            Regex obj = new Regex(@"^[1-9]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])\s+(20|21|22|23|[0-1]\d):[0-5]\d:[0-5]\d$");

            if (competitionname == "")
            {
                Response.Write("<script>alert('赛事名称不能为空')</script>");
                return false;
            }
            if (signupstarttime == "")
            {
                Response.Write("<script>alert('报名起止时间不能为空')</script>");
                return false;
            }
            if (ddl == "")
            {
                Response.Write("<script>alert('报名起止时间不能为空')</script>");
                return false;
            }
            if (starttime == "")
            {
                Response.Write("<script>alert('比赛起止时间不能为空')</script>");
                return false;
            }
            if (endtime == "")
            {
                Response.Write("<script>alert('比赛起止时间不能为空')</script>");
                return false;
            }
            if (maxbouns == "")
            {
                Response.Write("<script>alert('奖金不能为空')</script>");
                return false;
            }
            if (minmember == "")
            {
                Response.Write("<script>alert('团队人数不符合格式')</script>");
                return false;
            }
            if (maxmember == "")
            {
                Response.Write("<script>alert('团队人数不符合格式')</script>");
                return false;
            }
            return true;
        }

        private string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            
            if (check(competitionname.Text, signupstarttime.Text,ddl.Text,
           starttime.Text, endtime.Text,maxbouns.Text,minmember.Text,maxmember.Text))
            {
                string str = "Server=localhost;User ID=root;Password=1548936563ry?;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();//开启连接
                string strcmd = "insert into competition (id,competitionname,signupstarttime,ddl, starttime,endtime,maxbouns,minmember,maxmember,level_id,type_id)values (?id,?competitionname,?signupstarttime,?ddl,?starttime,?endtime,?maxbouns,?minmember,?maxmember,?level_id,?type_id)";
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                string id = GenerateId();
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?competitionname", competitionname.Text);
                cmd.Parameters.AddWithValue("?signupstarttime", signupstarttime.Text);
                cmd.Parameters.AddWithValue("?ddl", ddl.Text);
                cmd.Parameters.AddWithValue("?starttime", starttime.Text);
                cmd.Parameters.AddWithValue("?endtime", endtime.Text);
                cmd.Parameters.AddWithValue("?maxbouns", maxbouns.Text);
                cmd.Parameters.AddWithValue("?minmember", minmember.Text);
                cmd.Parameters.AddWithValue("?maxmember", maxmember.Text);
                cmd.Parameters.AddWithValue("?level_id", level_id.Text);
                cmd.Parameters.AddWithValue("?type_id", type_id.Text);
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine(i);
                con.Close();//关闭连接
                Response.Redirect("launch4.aspx");
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void bouns_TextChanged(object sender, EventArgs e)
        {

        }

        protected void minmember_TextChanged(object sender, EventArgs e)
        {

        }

        protected void signupstarttime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}