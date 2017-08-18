using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1.WebSite
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void login_Click(object sender, EventArgs e)
        {
                   int id = global.Login(username.Text, password.Text);

            if (id == 0)
            {
                Response.Write("<script>alert('帐号或密码错误')</script>");
                return;
            }

            Response.Write("<script>alert('登陆成功')</script>");
        }

        protected void Join_Click(object sender, EventArgs e)
        {
            Session["competition_id"] = "099c182ed2f041afb73a7c1145d3d789";
            Session["participant_id"] = 1;
            Server.Transfer("Jion_single.aspx");
        }
    }
}