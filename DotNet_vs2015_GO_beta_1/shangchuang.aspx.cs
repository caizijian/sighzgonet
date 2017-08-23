using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1
{
    public partial class shangchuang : System.Web.UI.Page
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
                    string filepath = "/上传文件/";
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
    }
}