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
            if (Session["uid"] == null)
            {
                Response.Redirect("../system/login.aspx", false);
                return;
            }

                if (!IsPostBack)
            {
                int participant_id = Convert.ToInt32(Session["uid"]);
                //String competiton_id = Session["competiton_id"].ToString();
                MySqlDataReader reader = global.ParticipantInfo(135);
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
        }


        protected void sure_Click(object sender, EventArgs e)
        {
            string Realname = name.Text;
            string Province = province.Text;
            string City = city.Text;
            string School = school.Text;
            string Major = major.Text;
            string Grade = grade.Text;
            string Number = number.Text;
            string Email = email.Text;
            string Telephone = telephone.Text;
            string Wechat = wechat.Text;
            string Sex = sex.Text;
            string Teachername = teachername .Text;
            string Teacherinfo = teacherinfo.Text;


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
            //int participant_id = Convert.ToInt32(Session["participant_id"]);
            //String competiton_id = Session["competiton_id"].ToString();
            int success=global.Join(1, Realname, Province, City, School, Major, Grade, Number, Email, Telephone, Wechat, Sex, Teachername, Teacherinfo, "099c182ed2f041afb73a7c1145d3d789");
            if(success==1)
            {
                Response.Write("<script>alert('报名成功')</script>");
                return;
            }


        }
       
     
    }
}