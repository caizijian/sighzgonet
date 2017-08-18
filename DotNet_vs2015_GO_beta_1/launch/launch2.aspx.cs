﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Web.Security;

namespace WebApplication1
{
    public partial class _2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);

                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (pic_upload.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "/images/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        string virpath = filepath + Session["uid"];//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                        pic_upload.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic.ImageUrl = virpath;
                        //清空提示
                        lbl_pic.Text = "";
                    }
                    else
                    {
                        pic.ImageUrl = "";
                        lbl_pic.Text = "文件大小超出8M！请重新选择！";
                    }
                }
                else
                {
                    pic.ImageUrl = "";
                    lbl_pic.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic.ImageUrl = "";
                lbl_pic.Text = "请选择要上传的图片！";
            }
        }

        /// <summary>
        /// 验证是否指定的图片格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            //限定只能上传jpg和gif图片
            string[] allowExtension = { ".jpg", ".gif", ".bmp", ".png" };
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }


 


        protected bool check(string managername, string telephone ,string email)
        {
      
            if (managername == "")
            {
                Response.Write("<script>alert('公司名不能为空')</script>");
                return false;
            }
            if (telephone == "")
            {
                Response.Write("<script>alert('电话号码不能为空')</script>");
                return false;
            }
            if (email == "")
            {
                Response.Write("<script>alert('邮箱不能为空')</script>");
                return false;
            }
            return true;
        }
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (check(managername.Text, telephone.Text,email.Text))
            {
                //  string str = "Server=localhost;User ID=root;Password=1548936563ry?;Database=launch;CharSet=utf8;";
                string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();//开启连接
                string strcmd = "insert into host (id,managername,telephone,wechat)values (?id,?managername,?telephone,?wechat)";
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("?managername", managername.Text);
                cmd.Parameters.AddWithValue("?telephone", telephone.Text);
                 cmd.Parameters.AddWithValue("?wechat", wechat.Text);
                cmd.Parameters.AddWithValue("?id", Session["uid"]);
              //  cmd.Parameters.AddWithValue("?id", 1);
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine(i);
                Session["managername"] = managername.Text;
                con.Close();//关闭连接
                Response.Redirect("launch3.aspx");
            }
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
