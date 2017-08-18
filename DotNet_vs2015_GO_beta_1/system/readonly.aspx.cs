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
            EDITOR SH = new EDITOR();
            int temp=SH.show();
            if (temp == 1)
                Response.Write("<script>alert('请您尽快编辑并提交个人资料！')</script>");
            if (temp == 0)
                Response.Write("<script>alert('查询不到您的资料，发生错误！')</script>");
        }
        public  void  changelabel(MySqlDataReader reader)
        {
            Label1.Text = reader.GetString(4);
            Label2.Text = reader.GetString(1);
            Label5.Text = reader.GetString(3);
            Label6.Text = reader.GetString(7);
            Label7.Text = reader.GetString(5);
            //ds.Tables[0].Rows[0]["telephone"].ToString();
        }
        protected void revise_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/edit.aspx", false);
        }
    }
}