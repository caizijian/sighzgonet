using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SightzGo
{
    public partial class Game_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Server=localhost;User ID=root;Password=```111qqqAAA;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select * from competition";
            //声明一个数据适配器对象  
            SqlDataAdapter sda = new SqlDataAdapter(strcmd,str);
            //声明一个数据集对象  
            DataSet ds = new DataSet();
            //填充数据  
            sda.Fill(ds);
            //绑定数据源  
            GridView1.DataSource = ds.Tables["competition"];
            GridView1.DataBind();
            con.Close();
        }
    }
}