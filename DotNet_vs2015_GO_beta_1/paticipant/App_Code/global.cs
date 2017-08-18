using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class global{

    static global()
    {
      
    }


    //登录成功返回id，失败返回0
    public static int Login(string username, string password)
    {
        //加判断输入+是否存在
        string sql= "select id from user where username=?username and password=?password";
        MySqlParameter[] p ={
    new MySqlParameter("?username",username),
    new MySqlParameter("?password",password)
                             };

        if (mysqlHelp.ExecuteScalar(sql, p) == null) return 0;
        else return((int)mysqlHelp.ExecuteScalar(sql, p));

    }


//注册成功返回1，账号已被注册返回-1,失败返回0
    public static int AddUser(string username, string password, string type)
   {

    string permission = " 1";
    string date = DateTime.Now.ToString("yyyy-MM-dd");

    string sql = "select username from user where username=?username";
    new MySqlParameter("?username", username);
    if (mysqlHelp.ExecuteNonQuery(sql) != 0) return -1;
    else
    {
        sql = "insert into user (username,password,type,permission,signupdate) values (?username,?password,?type,?permission,?signupdate";
        MySqlParameter[] p ={
    new MySqlParameter("?username",username),
    new MySqlParameter("?password",password),
    new MySqlParameter("?type", type),
    new MySqlParameter("?permission", permission),
    new MySqlParameter("?signupdate", date)
                             };
        return (mysqlHelp.ExecuteNonQuery(sql, p));

    }
   }


    //显示参赛者个人信息
    public static MySqlDataReader ParticipantInfo(int id)
    {
        //加判断输入+是否存在
        string sql = "select * from participant where id=?id";
        MySqlParameter[] p ={
        new MySqlParameter("?id",id) };
        return mysqlHelp.ExecuteReader(sql,p);
    }

    //显示参赛者个人信息
    public static MySqlDataReader HostInfo(int id)
    {
        //加判断输入+是否存在
        string sql = "select * from host where id=?id";
        MySqlParameter[] p ={
        new MySqlParameter("?id",id) };
        return mysqlHelp.ExecuteReader(sql, p);
    }

    public static int isParticipantInfoExist(int id)
    {
        string sql = "select * from participant where id=?id";
        MySqlParameter[] p ={
        new MySqlParameter("?id",id) };
        return mysqlHelp.ExecuteNonQuery(sql, p);
    }


    public static int UpdataParticipantInfo(int id)
    {
        int exist = isParticipantInfoExist(id);
        if (exist == 0)
        {
            string sql = "insert participant (id,realname,province,city,school_id,major,garde,number,email,telephone,wechat,sex)where id=?id";

        }


        return 1;
    }



















}








