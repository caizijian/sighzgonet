using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace edit
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";
                if (Session["uid"] == null)
                {
                    Response.Redirect("../system/login.aspx", false);
                    return;
                }
                save.Attributes["OnClick"] = "return confirm('您是否确认信息无误，若一经审核通过，将无法更改与公司相关的信息！')";
                cancel.Attributes["OnClick"] = "return confirm('您是否确认取消编辑，您的修改将不会有改动！')";
                int host_id = (int)Session["uid"];
                MySqlDataReader reader = global.HostInfo(host_id);
                if (reader.Read())
                {
                    if (reader.IsDBNull(1))
                    {
                        menagername.Text = "";
                    }
                    else
                    {
                        menagername.Text = reader.GetString(4);
                    }
                    if (reader.IsDBNull(1))
                    {
                        companyname.Text = "";
                    }
                    else
                    {
                        companyname.Text = reader.GetString(1);
                    }
                    if (reader.IsDBNull(1))
                    {
                        mainbusiness.Text = "";
                    }
                    else
                    {
                        mainbusiness.Text = reader.GetString(3);
                    }
                    if (reader.IsDBNull(1))
                    {
                        wechat.Text = "";
                    }
                    else
                    {
                        wechat.Text = reader.GetString(7);
                    }
                    if (reader.IsDBNull(1))
                    {
                        telephone.Text = "";
                    }
                    else
                    {
                        telephone.Text = reader.GetString(5);
                    }
                }
            }
        }

    protected void save_Click(object sender, EventArgs e)
        {
            if (checknull())
            {
                EDITOR temp = new EDITOR();
               int flag= temp.saveedit(menagername.Text.Trim(),companyname.Text.Trim(),mainbusiness.Text.Trim(),wechat.Text.Trim(),telephone.Text.Trim(),(int)Session["uid"]);
                if (flag == 1 || flag == 2)
                {
                    Response.Write("<script>alert('修改成功！')</script>");
                    Response.Redirect("~/system/readonly.aspx", false);
                }
                else
                    Response.Write("<script>alert('修改失败！')</script>");
            }
        }

        protected bool checknull()
        {
            bool flag = true;
            if (menagername.Text == "")
            {
                Response.Write("<script>alert('负责人姓名不能为空')</script>");
                flag = false;
            }
            if (companyname.Text == "")
            {
                Response.Write("<script>alert('公司/组织名称不能为空')</script>");
                flag = false;
            }
            if (mainbusiness.Text == "")
            {
                Response.Write("<script>alert('主营业务不能为空')</script>");
                flag = false;
            }
            if (wechat.Text == "")
            {
                Response.Write("<script>alert('微信号不能为空')</script>");
                flag = false;
            }
            if (telephone.Text == "")
            {
                Response.Write("<script>alert('电话号码不能为空')</script>");
                flag = false;
            }
            return flag;
        }
        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/readonly.aspx", false);
        }

        protected void changehead_Click(object sender, EventArgs e)
        {

            string pictureName = FileUpload1.FileName;               //获取文件名称
                                                                        //获取上传文件的后缀名
            string lastName = pictureName.Substring(pictureName.LastIndexOf(".") + 1);
            if (lastName.ToLower() == "jpg" || lastName.ToLower() == "bmp" || lastName.ToLower() == "gif" || lastName.ToLower() == "png")
            {
                string SavePath = Server.MapPath("~/Img/user/");     //设置保存路径
                string Newname = Session["uid"] + ".jpg" ;
                if (!Directory.Exists(SavePath))//判断路径是否存在
                {
                    Directory.CreateDirectory(SavePath);//如果不存在创建文件夹           
                }
                FileUpload1.PostedFile.SaveAs(SavePath + Newname);                   //保存上传的图片
                                                                                     // string sqlIns = "insert into tb_pictureSend(Name,pictureName,dateSend) values('"
                                                                                     //     + Name + "','" + pictureName + "','" + dateSend + "')";
                                                                                     // SqlConnection con = createCon();
                                                                                     // con.Open();
                                                                                     // SqlCommand com = new SqlCommand(sqlIns, con);
                                                                                     // com.ExecuteNonQuery();
                                                                                     // gvBind();
                                                                                     // con.Close();
                Response.Write("<script>alert('上传成功！')</script>");
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";
            }
            else
            {
                Response.Write("<script>alert('图片格式不正确！！请用jpg/bmp/gif/png格式！')</script>");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string pictureName = FileUpload2.FileName;               //获取文件名称
            string dateSend = DateTime.Now.ToString("yyyyMMddhhmmss");                  //获取当前时间                                                         
            string lastName = pictureName.Substring(pictureName.LastIndexOf(".") + 1); //获取上传文件的后缀名
            if (lastName.ToLower() == "jpg" || lastName.ToLower() == "bmp" || lastName.ToLower() == "gif" || lastName.ToLower() == "png")
            {
                string SavePath = Server.MapPath("~/Img/host/");     //设置保存路径
                string Newname = Session["uid"]+"-"+dateSend+"."+lastName;
                if (!Directory.Exists(SavePath))//判断路径是否存在
                {
                    Directory.CreateDirectory(SavePath);//如果不存在创建文件夹           
                }
                FileUpload2.PostedFile.SaveAs(SavePath + Newname);                   //保存上传的图片
                Response.Write("<script>alert('上传成功！')</script>");
            }
            else
            {
                Response.Write("<script>alert('图片格式不正确！！请用jpg/bmp/gif/png格式！')</script>");
            }
        }
    }
}