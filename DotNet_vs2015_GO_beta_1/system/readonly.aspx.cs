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

            //进入页面判断是否登录
            //如果未登录，则跳转到登录页面
            //
            //CZJ 392067117@qq.com 2017/08/22
            if (Session["uid"] == null)
                {
                    Response.Redirect("../system/login.aspx", false);
                    return;
                }
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";
                //id获取图片名称,从文件夹中拿出图片
                //由于计算机以二进制存储，因此与格式要求无关，统一成jpg

                // int host_id = 106;测试用
                int host_id = (int)Session["uid"];//将sesion id类型转化
                //   Response.Write("<scirpt>alert(host_id)</script>"); 
                
                //查找主办方个人资料
                MySqlDataReader reader = global.HostInfo(host_id);
                //判断reader是否为空，对应赋值
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
                    //通过获取certification的值来判断主办方当前证明文件状态 审核已通过 审核未通过
                    string temp = reader.GetString(2);
                   if (temp=="0")
                    {
                        Label4.Text = "未申请审核或审核未通过";
                    }
               
                   else if (temp=="1")
                {
                    //  Label4.Text = reader.GetString(1);
                    ///  Label4.Visible=false;
                    //  evidence.ImageUrl = "~/Img/host/" + Session["uid"] + ".jpg";
                    //  evidence.Visible = true;
                    Label4.Text = "审核已通过";
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
        //编辑按钮响应函数
        //跳转到编辑页面
        //CZJ 392067117@qq.com 2017/08/22
        protected void revise_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/edit.aspx", false);
        }
    }
}