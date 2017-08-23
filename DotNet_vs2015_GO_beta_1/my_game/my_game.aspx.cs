using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace DotNet_vs2015_GO_beta_1.my_game
{
    public partial class my_game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            show();
            /*
            if(IsPostBack)
            {
                DataTable dt = new DataTable();
                //新增自定义的4列
                dt.Columns.Add("id");
                dt.Columns.Add("competitionname");
                dt.Columns.Add("status");
                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                }
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                //如果数据为空则重新构造Gridview
                if (GridView1.Rows.Count == 1 && GridView1.Rows[0].Cells[0].Text == "没有记录")
                {
                    int columnCount = GridView1.Columns.Count;
                    GridView1.Rows[0].Cells.Clear();
                    GridView1.Rows[0].Cells.Add(new TableCell());
                    GridView1.Rows[0].Cells[0].ColumnSpan = columnCount;
                    GridView1.Rows[0].Cells[0].Text = "没有记录";
                    GridView1.Rows[0].Cells[0].Style.Add("text-align", "center");
                }
            }
            */
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //获取当前分页的索引值
            GridView1.PageIndex = e.NewPageIndex;
            //重新绑定数据
            GridView1.DataBind();
            
        }
        public void show()
        {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);
            //打开数据库  
            con.Open();
            //定义查询的sql语句  
            string cmd = "select * from follow,competition,competitionstatus where follow.competition_id=competition.id and competition.status=competitionstatus.id";
            //  GridView1.DataSource=mysqlHelp.ExecuteDataTable(cmd);
            //声明一个数据适配器对象  
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd, con);
            //声明一个数据集对象  
            DataSet ds = new DataSet();

            /*
            //记录为空重新构造Gridview
            if (dt.Rows.Count == 0)
            {
                dt = dt.Clone();
                dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                int columnCount = dt.Columns.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columnCount;
                GridView1.Rows[0].Cells[0].Text = "Empty Text";
                GridView1.Rows[0].Cells[0].Style.Add("text-align", "center");
            }
            else
            {
                //数据不为空直接绑定
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            */
            //填充数据  
            sda.Fill(ds);
            //绑定数据源  
            GridView1.DataSource = ds;
            GridView1.DataKeyNames = new string[] { "id" };
            GridView1.DataBind();
            con.Close();

        }


        /*
        public void GridViewEmptyData()
        {
            DataTable dt = new DataTable();
            //新增自定义的4列
            dt.Columns.Add("id");
            dt.Columns.Add("competitionname");
            dt.Columns.Add("status");
            if (dt.Rows.Count==0)
            {
                dt.Rows.Add(dt.NewRow());
            }
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
            //如果绑定数据为空，则创建GridView表头并显示提示信息
            int columnCount = dt.Columns.Count;
            GridView1.Rows[0].Cells.Clear();
            GridView1.Rows[0].Cells.Add(new TableCell());
            GridView1.Rows[0].Cells[0].ColumnSpan = columnCount;
            GridView1.Rows[0].Cells[0].Text = "无报名比赛";
            GridView1.Rows[0].Cells[0].Style.Add("text-align","center");


        }
        */

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}