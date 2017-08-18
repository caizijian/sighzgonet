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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void next_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();//开启连接
                string strcmd = "select id from user where username='" + username.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds, "gg");//查询结果填充数据集     
                if (ds == null || ds.Tables.Count == 0 || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
                {

                    string strcmd1 = "insert into user (username,password) VALUES ('" + username.Text.Trim() + " ','" + password.Text.Trim() + "')";
                    MySqlCommand cmd1 = new MySqlCommand(strcmd1, con);
                    cmd1.ExecuteNonQuery();
                    Response.Write("<script>alert('注册成功！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户名已存在！')</script>");
                }
            }
        }
        protected bool check()
        {
            bool flag = true; ;
            if (username.Text == "")
            {
                Response.Write("<script>alert('用户名不能为空!')</script>");
                flag = false;
            }
            if (password.Text == "")
            {
                Response.Write("<script>alert('密码不能为空!')</script>");
                flag = false;
            }
            if (password.Text == "")
            {
                Response.Write("<script>alert('密码不能为空!')</script>");
                flag = false;
            }
            if (password.Text != password1.Text)
            {
                Response.Write("<script>alert('两次密码不一致!')</script>");
                flag = false;
            }
            if (checkb.Checked == false)
            {
                Response.Write("<script>alert('请同意《赛事GO服务条款》后重试！')</script>");
                flag = false;
            }
            return flag;
        }
        protected void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void repassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {

        }

        protected void checkb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}