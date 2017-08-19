using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

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
            Regex reg = new Regex(@"^[1-9]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])\s+(20|21|22|23|[0-1]\d):[0-5]\d:[0-5]\d$");
            if(!reg.IsMatch(starttime))
            {
                Response.Write("<script>alert('时间格式不正确,正确格式为: 2014-01-01 12:00:00')</script>");
                return false;
            }
            if (!reg.IsMatch(signupstarttime))
            {
                Response.Write("<script>alert('时间格式不正确,正确格式为: 2014-01-01 12:00:00')</script>");
                return false;
            }
            if (!reg.IsMatch(endtime))
            {
                Response.Write("<script>alert('时间格式不正确,正确格式为: 2014-01-01 12:00:00')</script>");
                return false;
            }
            if (!reg.IsMatch(ddl))
            {
                Response.Write("<script>alert('时间格式不正确,正确格式为: 2014-01-01 12:00:00')</script>");
                return false;
            }
            if (competitionname == "")
            {
                Response.Write("<script>alert('赛事名称不能为空')</script>");
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
              //  Console.WriteLine(Session["managername"]);
             //   Response.Write(Session["managername"]);
                string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();//开启连接
                           /*    string strcmd = "insert into competition (id,competitionname,signupstarttime,ddl, starttime,endtime,maxbouns,minmember,maxmember,level_id,type_id)values (?id,?competitionname,?signupstarttime,?ddl,?starttime,?endtime,?maxbouns,?minmember,?maxmember,?level_id,?type_id)";
                               string strcmd1 = "insert into launchcompetition (competition_id,host_id)values (?competition_id,1)";
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


                           MySqlCommand cmd1 = new MySqlCommand(strcmd1, con);
                           cmd1.Parameters.AddWithValue("?competition_id", id);

                           int i = cmd.ExecuteNonQuery();
                           int j = cmd1.ExecuteNonQuery();
                           Console.WriteLine(i);  
                  */

                MySqlTransaction transaction = con.BeginTransaction();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.Transaction = transaction;
                try
                {
                    string strcmd = "insert into competition (id,competitionname,signupstarttime,ddl, starttime,endtime,maxbouns,minmember,maxmember,level_id,type_id)values (?id,?competitionname,?signupstarttime,?ddl,?starttime,?endtime,?maxbouns,?minmember,?maxmember,?level_id,?type_id)";
                    string strcmd1 = "insert into launchcompetition (competition_id,host_id)values (?competition_id,1)";
                    MySqlCommand cmd = new MySqlCommand(strcmd, con);
                    string id = GenerateId();
                    Session["id"] = id;
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
                    MySqlCommand cmd1 = new MySqlCommand(strcmd1, con);
                    cmd1.Parameters.AddWithValue("?competition_id", id);
                    int i = cmd.ExecuteNonQuery();
                    int j = cmd1.ExecuteNonQuery();
                    Console.WriteLine(i);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
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