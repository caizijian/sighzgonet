using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1
{
    public partial class uglyallgame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { showallcompetition(); }
            
        }

        protected void showallcompetition()
        {//显示该队目前的队员组成情况
          
            DataTable table = global.ShowAllCompetition();
            GridView1.DataSource = table;
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked == true)
                {
                    Session["competition_id"] = (string)GridView1.DataKeys[i].Value;
                    break;
                }
            }
            //string test = Session["competition_id"].ToString();
          //  Response.Write("<script>alert('选择成功')</script>");
            Response.Redirect("~/detail/Game_details.aspx");
        }
    }
}