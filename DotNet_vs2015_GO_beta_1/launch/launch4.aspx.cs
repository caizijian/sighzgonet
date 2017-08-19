using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();
            string strcmd = "update competition set content=?content  where id=?id";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            cmd.Parameters.AddWithValue("?id", Session["id"]);
            cmd.Parameters.AddWithValue("?content", content.Text);
            Response.Redirect("launch5.aspx");
        }
    }
}