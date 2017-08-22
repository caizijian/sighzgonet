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
            if (check(content.Text))
            {
                string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
                MySqlConnection con = new MySqlConnection(str);//实例化链接
                con.Open();
                string strcmd = "update competition set content=?content  where id=?id";
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                cmd.Parameters.AddWithValue("?id", Session["id"]);
                cmd.Parameters.AddWithValue("?content", content.Text);
                Response.Redirect("launch5.aspx");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(FileUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(FileUpload.FileName).ToLower();
                string filepath = "/上传附件/";
                if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(Server.MapPath(filepath));
                }
                string virpath = filepath + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + Session["uid"] + fileExtension;//;//这是存到服务器上的虚拟路径
                string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                FileUpload.PostedFile.SaveAs(mappath);//保存图片
            }
        }

        protected void content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}