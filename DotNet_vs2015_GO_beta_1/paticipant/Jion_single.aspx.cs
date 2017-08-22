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
    {//个人参赛
        protected void Page_Load(object sender, EventArgs e)
        {//初始化页面时，展示已填的个人信息
           /* if (Session["uid"] == null)
            {
                Response.Redirect("../system/login.aspx", false);
                return;
            }*/

                if (!IsPostBack)
            {
                // int participant_id = Convert.ToInt32(Session["uid"]);
                //String competiton_id = Session["competiton_id"].ToString();
                int participant_id = 136;
                MySqlDataReader reader = global.ParticipantInfo(participant_id);
                if (reader.Read())
                {
                    if (reader.IsDBNull(1)) name.Text = "";
                    else     name.Text = reader.GetString(1);
                    if (reader.IsDBNull(2)) province.Text = "";
                    else province.Text = reader.GetString(2); 
                    if (reader.IsDBNull(3)) city.Text = "";
                    else city.Text = reader.GetString(3); 
                    if (reader.IsDBNull(4)) school.Text = "";
                    else school.Text = reader.GetString(4);
                    if (reader.IsDBNull(5)) major.Text = "";
                    else major.Text = reader.GetString(5); 
                    if (reader.IsDBNull(6))grade.Text = "";
                    else grade.Text = reader.GetString(6); 
                    if (reader.IsDBNull(7)) number.Text = "";
                    else number.Text = reader.GetString(7); 
                    if (reader.IsDBNull(8))email.Text = "";
                    else email.Text = reader.GetString(8); 
                    if (reader.IsDBNull(9))telephone.Text = "";
                    else  telephone.Text = reader.GetString(9); 
                    if (reader.IsDBNull(10)) wechat.Text = "";
                    else wechat.Text = reader.GetString(10);
                    if (reader.IsDBNull(11)) sex.Text = "";
                    else sex.Text = reader.GetString(11); 
                }
                else Server.Transfer("test.aspx");
            }
        }


        protected void sure_Click(object sender, EventArgs e)
        {//更新个人信息并参加比赛
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
            int participant_id = 136;
            int success=global.Join(participant_id, Realname, Province, City, School, Major, Grade, Number, Email, Telephone, Wechat, Sex, Teachername, Teacherinfo, "099c182ed2f041afb73a7c1145d3d789");
            if(success==1)
            {
                Response.Write("<script>alert('报名成功')</script>");
                Response.Redirect("/detail/Game_details.aspx");

            }
         
           
        }
       
     
    }
}