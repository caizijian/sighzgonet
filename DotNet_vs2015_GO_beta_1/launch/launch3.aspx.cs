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
    
            if (competitionname == "")
            {
                Response.Write("<script>alert('赛事名称不能为空')</script>");
                return false;
            }
            if (Regex.IsMatch(competitionname, @"[^0-9a-zA-Z\u4e00-\u9fa5]"))
            {
                Response.Write("<script>alert('赛事名称不符合格式')</script>");
                return false;
            }
            if (minmember == "")
            {
                Response.Write("<script>alert('团队人数不能为空')</script>");
                return false;
            }
            if (minmember == "")
            {
                Response.Write("<script>alert('团队人数不能为空')</script>");
                return false;
            }
            int min = Convert.ToInt16(this.minmember.Text);
            int max = Convert.ToInt16(this.maxmember.Text);
            if (min<2||max<2)      
            {
                Response.Write("<script>alert('团队人数不符合格式')</script>");
                return false;
            }
            if (signupstarttime == "")
            {
                Response.Write("<script>alert('报名开始时间不能为空')</script>");
                return false;
            }
            if (ddl == "")
            {
                Response.Write("<script>alert('报名截止时间不能为空')</script>");
                return false;
            }
            if (starttime == "")
            {
                Response.Write("<script>alert('比赛开始时间不能为空')</script>");
                return false;
            }
            if (endtime == "")
            {
                Response.Write("<script>alert('比赛截止时间不能为空')</script>");
                return false;
            }
            if (maxbouns == "")
            {
                Response.Write("<script>alert('奖金不能为空')</script>");
                return false;
            }
            return true;
        }

     

        protected bool CompareDateTime(string starttime, string endtime)
        {
            DateTime date1 = Convert.ToDateTime(this.starttime.Text);
            DateTime date2 = Convert.ToDateTime(this.endtime.Text);
            if (date1> date2)
            {
                Response.Write("<script>alert('结束时间不应早于开始时间')</script>");
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

            if (check(competitionname.Text, signupstarttime.Text, ddl.Text,
           starttime.Text, endtime.Text, maxbouns.Text, minmember.Text, maxmember.Text))
                if (CompareDateTime(signupstarttime.Text, ddl.Text))
                {
                    if (CompareDateTime(starttime.Text, endtime.Text))
                    {
                            Console.WriteLine(Session["managername"]);
                            Response.Write(Session["managername"]);
                            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                            MySqlConnection con = new MySqlConnection(str);//实例化链接
                            con.Open();//开启连接                 
                            MySqlTransaction transaction = con.BeginTransaction();
                            MySqlCommand cmd2 = con.CreateCommand();
                            cmd2.Transaction = transaction;
                            try
                            {
                                string strcmd = "insert into competition (id,competitionname,signupstarttime,ddl, starttime,endtime,maxbouns,minmember,maxmember,level_id,type_id,createtime)values (?id,?competitionname,?signupstarttime,?ddl,?starttime,?endtime,?maxbouns,?minmember,?maxmember,?level_id,?type_id,?createtime)";
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
                                cmd.Parameters.AddWithValue("?createtime", DateTime.Now);
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

        protected void maxmember_TextChanged(object sender, EventArgs e)
        {

        }

        protected void level_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}