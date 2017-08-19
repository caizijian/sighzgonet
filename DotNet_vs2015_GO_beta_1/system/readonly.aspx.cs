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
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";
                //id获取图片名称,从文件夹中拿出图片
                //bug未记住图片名因此无法知道图片后缀

                // int host_id = 106;
                int host_id = (int)Session["uid"];
                //   Response.Write("<scirpt>alert(host_id)</script>");          
                MySqlDataReader reader = global.HostInfo(host_id);

                if (reader.Read())
                {
                    if (reader.IsDBNull(4))
                    {
                        Label1.Text = "";
                    }
                    else
                    {
                        Label1.Text = reader.GetString(4);
                    }
                    if (reader.IsDBNull(1))
                    {
                        Label2.Text = "";
                    }
                    else
                    {
                        Label2.Text = reader.GetString(1);
                    }
                    if (reader.IsDBNull(3))
                    {
                        Label5.Text = "";
                    }
                    else
                    {
                        Label5.Text = reader.GetString(3);
                    }
                    if (reader.IsDBNull(7))
                    {
                        Label6.Text = "";
                    }
                    else
                    {
                        Label6.Text = reader.GetString(7);
                    }
                    if (reader.IsDBNull(5))
                    {
                        Label7.Text = "";
                    }
                    else
                    {
                        Label7.Text = reader.GetString(5);
                    }
                }
            
        }

        protected void revise_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/edit.aspx", false);
        }
    }
}