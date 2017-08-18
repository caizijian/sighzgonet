using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool check(string username,string password)
        {
            bool flag=true;
            if (username == "")
            {
                Response.Write("<script>alert('用户名不能为空')</script>");
                flag = false;
            }
            if (password == "")
            {
                Response.Write("<script>alert('密码不能为空')</script>");
                flag = false;
            }
            return flag;
        }
        protected void log_Click(object sender, EventArgs e)
        {
            if(check(username.Text, password.Text))
            {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select id from user where username='" + username.Text + "'and password='" + password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ada.Fill(ds, "gg");//查询结果填充数据集     
            if (ds == null || ds.Tables.Count == 0 || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
            else
            {
                    Session["uid"] = ds.Tables[0].Rows[0][0].ToString();
                    Session["userName"] = username.Text.Trim();
                    if (remember.Checked)
                    {
                        if (Request.Cookies["userName"].Value == "")
                        {
                            Request.Cookies["userName"].Value = username.Text.Trim();
                            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(30);
                            Request.Cookies["passWord"].Value = password.Text.Trim();
                            Response.Cookies["password"].Expires = DateTime.Now.AddDays(30);
                        }
                    }
                Response.Write("<script>alert('登陆成功')</script>");
             }
            con.Close();//关闭连接
            Response.Redirect("Home.html", false);
            }
        }

        protected void username_TextChanged(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null)
            {
                if (Request.Cookies["userName"].Value.Equals(username.Text.Trim()))
                {
                    password.Attributes["value"] = Request.Cookies["passWord"].Value;
                }
            }
        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}