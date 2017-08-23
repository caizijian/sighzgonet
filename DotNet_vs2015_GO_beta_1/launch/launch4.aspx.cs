using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
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
        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if (pic_upload.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
                //对上传文件的大小进行检测，限定文件最大不超过8M
                if (pic_upload.PostedFile.ContentLength < 8192000)
                {
                    string filepath = "/上传附件/";
                    if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                    {
                        Directory.CreateDirectory(Server.MapPath(filepath));
                    }
                    string virpath = filepath + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + Session["uid"] + fileExtension;//;//这是存到服务器上的虚拟路径
                    string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                    pic_upload.PostedFile.SaveAs(mappath);//保存图片
                    //清空提示
                    lbl_pic.Text = "上传成功";
                }
                else
                {
                    lbl_pic.Text = "文件大小超出8M！请重新选择！";
                    return;
                }
            }
            else
            {
                lbl_pic.Text = "请选择要上传的附件！";
                return;
            }

        }
        protected bool check(string content)
        {
            if (content == "")
            {
                Response.Write("<script>alert('内容不能为空')</script>");
                return false;
            }
            return true;
        }
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (check(FCKeditor1.Value))
            {
                string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();
                string strcmd = "update competition set text=?text  where id=?id";
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("?id", Session["id"]);
                cmd.Parameters.AddWithValue("?text", FCKeditor1.Value);
                Response.Redirect("launch5.aspx");
            }
            
        }

      
      

        protected void content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}