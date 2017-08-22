using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNet_vs2015_GO_beta_1
{
    public partial class beautytest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { showallcompetition(); }
        }
        protected void showallcompetition()
        {//显示该队目前的队员组成情况
            DataTable table = global.ShowAllCompetition();
            DataList1.DataSource = table;
       
            DataList1.DataBind();
        }

    }
}