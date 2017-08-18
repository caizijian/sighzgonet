using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1.WebSite
{
    public partial class Jion_single : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int participant_id = Convert.ToInt32(Session["participant_id"]);
            //String competiton_id = Session["competiton_id"].ToString();
            MySqlDataReader reader = global.ParticipantInfo(participant_id);
            if (reader.Read())
            {
                name.Text = reader.GetString(1);
                province.Text = reader.GetString(2);
                city.Text = reader.GetString(3);
                school.Text = reader.GetString(4);
                major.Text = reader.GetString(5);
                grade.Text = reader.GetString(6);
                number.Text = reader.GetString(7);
                email.Text = reader.GetString(8);
                telephone.Text = reader.GetString(9);
                wechat.Text = reader.GetString(10);
                sex.Text = reader.GetString(11);
            }
            else Server.Transfer("test.aspx");
        }


        protected void sure_Click(object sender, EventArgs e)
        {
            String Realname = name.Text;
            String Province = province.Text;
            String City = city.Text;
            String School = school.Text;
            String Major = major.Text;
            String Grade = grade.Text;
            String Number = number.Text;
            String Email = email.Text;
            String Telephone = telephone.Text;
            String Wechat = wechat.Text;
            String Sex = sex.Text;
            String Teachername = teachername .Text;
            String Teacherinfo = teacherinfo.Text;


            if (Realname == null||Realname == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Province == null || Province == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (City == null || City == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (School == null || School == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Major == null || Major == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Grade == null || Grade == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Number == null || Number == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Email == null || Email == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Telephone == null || Telephone == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Wechat == null || Wechat == "")
            {
                Response.Write("<script>alert('请完善报名信息')</script>");
                return;
            }
            if (Sex == null || Sex == "")
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
        }

     
    }
}