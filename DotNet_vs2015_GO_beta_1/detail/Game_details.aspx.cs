﻿using System;
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

            test();
            //判断登录状态；
            /* if (Session["name"] == null || Session["name"] == "")
             {
                 Response.Write("<script>alert(\"请先登录！\");</script>");
                 Response.Redirect("../system/login.aspx");
                 return;
             }*/

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*if (Session["name"] == null || Session["name"] == "")
            {
                Response.Write("<script>alert(\"请先登录！\");</script>");
                Response.Redirect("../system/login.aspx");
                return;
            }
            else*/
            {
                Response.Redirect("#");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            /*if (Session["name"] == null || Session["name"] == "")
            {
                Response.Write("<script>alert(\"请先登录！\");</script>");
                Response.Redirect("../system/login.aspx");
                return;
            }
            else*/
            {
                Response.Redirect("#");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);
            //打开数据库  
            con.Open();
            //定义查询的sql语句  
            string cmd = "select * from competition";
            //声明一个数据适配器对象  
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd, con);
            //声明一个数据集对象  
            DataSet ds = new DataSet();
            //填充数据  
            sda.Fill(ds);
            //绑定数据源  
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }

        public void test()
        {
            string str = "Server=10.10.11.108;User ID=root;Password=GNzhengxun11;Database=sighzgo;CharSet=utf8;";
            MySqlConnection con = new MySqlConnection(str);
            //打开数据库  
            con.Open();
            //定义查询的sql语句  
            string cmd = "select * from competition";
          //  GridView1.DataSource=mysqlHelp.ExecuteDataTable(cmd);
            //声明一个数据适配器对象  
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd, con);
            //声明一个数据集对象  
            DataSet ds = new DataSet();
            //填充数据  
            sda.Fill(ds);
            //绑定数据源  
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }


    }
}