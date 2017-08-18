using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace edit
{
    public partial class _readonly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("../system/login.aspx", false);
                return;
            }
            int host_id = 106;
            //String competiton_id = Session["competiton_id"].ToString();
            MySqlDataReader reader = global.HostInfo(host_id);
            if (reader.Read())
            {
                string managername = reader.GetString(4);
                Label1.Text = reader.GetString(4);
                Label2.Text = reader.GetString(1);
                Label5.Text = reader.GetString(3);
                Label6.Text = reader.GetString(7);
                Label7.Text = reader.GetString(5);
            }         
        }

        protected void revise_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/edit.aspx", false);
        }
    }
}