using System;
using System.Collections.Generic;
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
            save.Attributes["OnClick"] = "return confirm('您是否确认信息无误，若一经审核通过，将无法更改与公司相关的信息！')";
        }
        
        protected void menagername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void companyname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mainbusiness_TextChanged(object sender, EventArgs e)
        {

        }

        protected void wechat_TextChanged(object sender, EventArgs e)
        {

        }

        protected void telephone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            if (checknull())
            {
                EDITOR temp = new EDITOR();
               int flag= temp.saveedit(menagername.Text.Trim(),companyname.Text.Trim(),mainbusiness.Text.Trim(),wechat.Text.Trim(),telephone.Text.Trim());
                if (flag == 1 || flag == 2)
                    Response.Write("<script>alert('修改成功！')</script>");
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

        }
    }
}