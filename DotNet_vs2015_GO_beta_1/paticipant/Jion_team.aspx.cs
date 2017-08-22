using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1
{
    public partial class Jion_team : System.Web.UI.Page
    {//组队并参赛
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {//第一次进入该页面时创建队伍ID
                string team_id = global.CreateTeam();
                Session["team_id"] = team_id;
            }

        }

        protected void find_Click(object sender, EventArgs e)
        {//通过用户真实姓名寻找队友
            string Username = membername.Text;
            DataTable table = global.FindParticipant(Username);
            if (table.Rows.Count == 0) {
                Label1.Text="该成员不存在";return; }
            GridView1.DataSource = table;
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();

        }

        protected void showteammember()
        {//显示该队目前的队员组成情况
            string team_id = Session["team_id"].ToString();
            DataTable table = global.ShowTeamMenber(team_id);
            GridView2.DataSource = table;
            GridView2.DataKeyNames = new string[] { "id" };
            GridView2.DataBind();
        }




        protected void sureadd_Click(object sender, EventArgs e)
        {//添加某队员
            string team_id = Session["team_id"].ToString();
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked == true)
                {
                    int participant_id = (int)GridView1.DataKeys[i].Value;
                    int success = global.JionTeam(team_id, participant_id);
                    if (success == -1)
                    {
                        Response.Write("<script>alert('添加失败')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('成功添加')</script>");
                        showteammember();
                    }
                }
            }
        }

        protected void joincompetition_Click(object sender, EventArgs e)
        {//组队参赛
            string team_id = Session["team_id"].ToString();
            //string competition_id = Session["competition_id"].ToString();
            string competition_id = "7b4007f0412d43e7";


            string Teamname = teamname.Text;
            string Teaminfo = teaminfo.Text;
            string Teachername = teachername.Text;
            string Teacherinfo = teacherinfo.Text;
            if (Teamname == null || Teamname == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Teaminfo == null || Teaminfo == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Teachername == null || Teachername == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Teacherinfo == null || Teacherinfo == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }

            if (global.isTeamnameExist(competition_id, Teamname) == 1)
            {
                Response.Write("<script>alert('该队名已存在')</script>");
                return; }


            global.UpdateTeam(team_id, Teamname, Teaminfo, Teachername, Teacherinfo);


            int success = global.JoinCompetition(competition_id, team_id);
            if (success == -1) { Response.Write("<script>alert('未能成功参赛')</script>"); }
          
             else { Response.Write("<script>alert('成功参赛');location.href='../detail/Game_details.aspx';</script>"); }
        }


    }
}


