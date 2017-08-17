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

        }
        public void changelabel(DataSet ds)
        {
        }
        protected void revise_Click(object sender, EventArgs e)
        {
            Response.Redirect("/edit.aspx", false);
        }
    }
}