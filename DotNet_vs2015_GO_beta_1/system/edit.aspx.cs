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
                //进入页面判断是否登录
                //如果未登录，则跳转到登录页面
                //
                //CZJ 392067117@qq.com 2017/08/22
                if (Session["uid"] == null)
                {
                    Response.Redirect("../system/login.aspx", false);
                    return;
                }

                //初始化页面
                //获取头像head
                //给按钮附加对应确认弹窗
                //CZJ 392067117@qq.com 2017/08/22
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";
                save.Attributes["OnClick"] = "return confirm('您是否确认信息无误，若一经审核通过，将无法更改与公司相关的信息！')";
                cancel.Attributes["OnClick"] = "return confirm('您是否确认取消编辑，您的修改将不会有改动！')";
                int host_id = (int)Session["uid"];
                MySqlDataReader reader = global.HostInfo(host_id);
                //初始化页面
                //给对应的文本框显示已存数据
                //CZJ 392067117@qq.com 2017/08/22
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

        //保存按钮相应函数，保存编辑框数据
        //CZJ 392067117@qq.com 2017/08/22
        protected void save_Click(object sender, EventArgs e)
        {
            //checknull判断格式是否正确
            //CZJ 392067117@qq.com 2017/08/22
            if (checknull())
            {
                //初始化实例对象
                //CZJ 392067117@qq.com 2017/08/22
                EDITOR temp = new EDITOR();
                //保存数据返回对应值
                //CZJ 392067117@qq.com 2017/08/22
               int flag= temp.saveedit(menagername.Text.Trim(),companyname.Text.Trim(),mainbusiness.Text.Trim(),wechat.Text.Trim(),telephone.Text.Trim(),(int)Session["uid"]);
                //判断返回值
                //1为成功，0为失败
                //对应提示弹窗，保存成功跳转到读个人资料页面
                //CZJ 392067117@qq.com 2017/08/22
                if (flag == 1)
                {
                    Response.Write("<script>alert('修改成功！')</script>");
                    Response.Redirect("~/system/readonly.aspx", false);
                }
                else
                    Response.Write("<script>alert('修改失败！')</script>");
            }
        }

        //检查是否不符合格式要求
        //返回bool
        //bug弹窗过多，稍后将通过更改样式，通过控件的显示隐藏来提示用户
        //CZJ 392067117@qq.com 2017/08/22
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
            else if(mainbusiness.Text.Length>150)
            {
                Response.Write("<script>alert('主营业务字数限制150字！')</script>");
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

        //取消按钮响应函数
        //确认取消后跳转读个人资料页面
        //CZJ 392067117@qq.com 2017/08/22
        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/system/readonly.aspx", false);
        }

        //更改头像按钮响应函数
        //CZJ 392067117@qq.com 2017/08/22
        protected void changehead_Click(object sender, EventArgs e)
        {
            //保存上传的头像，路径为~/Img/user/ + id.jpg
            //CZJ 392067117@qq.com 2017/08/22
            string pictureName = FileUpload1.FileName;               //获取文件名称                                                           
            string lastName = pictureName.Substring(pictureName.LastIndexOf(".") + 1); //获取上传文件的后缀名
            if (lastName.ToLower() == "jpg" || lastName.ToLower() == "bmp" || lastName.ToLower() == "gif" || lastName.ToLower() == "png") //限制上传格式为图片格式
            {
                string SavePath = Server.MapPath("~/Img/user/");     //设置保存路径
                string Newname = Session["uid"] + ".jpg" ;
                if (!Directory.Exists(SavePath))//判断路径是否存在
                {
                    Directory.CreateDirectory(SavePath);//如果不存在创建文件夹           
                }
                FileUpload1.PostedFile.SaveAs(SavePath + Newname); //保存上传的图片
                Response.Write("<script>alert('上传成功！')</script>");//提示成功
                head.ImageUrl = "~/Img/user/" + Session["uid"] + ".jpg";//重新获取头像
            }
            else
            {
                Response.Write("<script>alert('图片格式不正确！！请用jpg/bmp/gif/png格式！')</script>");//提示
            }
        }

        //上传营业执照及证明文件
        //保存上传的证明图片
        //bug 数据库还没开存储 证明文件名 字段，不能通过 文件名 取出，审核只能手动访问文件夹，并且手动更改数据库审核字段
        //CZJ 392067117@qq.com 2017/08/22
        protected void update_Click(object sender, EventArgs e)
        {
            //保存上传的证明图片
            //路径为~/Img/host/ + id- +上传时间（201708221753）
            //CZJ 392067117@qq.com 2017/08/22
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