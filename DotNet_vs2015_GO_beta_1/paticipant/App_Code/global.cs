using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

    //显示主办方个人信息
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
        if (mysqlHelp.ExecuteScalar(sql,p) == null) return 0;
        else return ((int)mysqlHelp.ExecuteScalar(sql,p));
    }


    public static int Join(int id, string realname, string province, string city, string school, string major, string grade, string number, string email, string telephone, string wechat, string sex,string teachername,string teacherinfo,string competition_id)
    {
        int exist = isParticipantInfoExist(id);

        if (exist ==0)
        {
                string sql1 = "insert participant (id,realname,province,city,school,major,grade,number,email,telephone,wechat,sex) values(?id,?realname,?province,?city,?school,?major,?grade,?number,?email,?telephone,?wechat,?sex)";
                MySqlParameter[] p ={
                new MySqlParameter("?id",id),
                new MySqlParameter("?realname",realname),
                new MySqlParameter("?province", province),
                new MySqlParameter("?city", city),
                new MySqlParameter("?school", school),
                new MySqlParameter("?major", major),
                new MySqlParameter("?grade",grade),
                new MySqlParameter("?number",number),
                new MySqlParameter("?email", email),
                new MySqlParameter("?telephone", telephone),
                new MySqlParameter("?wechat", wechat),
                new MySqlParameter("?sex", sex)
                                 };
                if (mysqlHelp.ExecuteNonQuery(sql1, p) == 0) return -1;
        }
        else
        {
                string sql2 = "update participant set realname=?realname,province=?province,city=?city,school=?school,major=?major,grade=?grade,number=?number,email=?email,telephone=?telephone,wechat=?wechat,sex=?sex where id=?id";
                MySqlParameter[] p ={
                new MySqlParameter("?id",id),
                new MySqlParameter("?realname",realname),
                new MySqlParameter("?province", province),
                new MySqlParameter("?city", city),
                new MySqlParameter("?school", school),
                new MySqlParameter("?major", major),
                new MySqlParameter("?grade",grade),
                new MySqlParameter("?number",number),
                new MySqlParameter("?email", email),
                new MySqlParameter("?telephone", telephone),
                new MySqlParameter("?wechat", wechat),
                new MySqlParameter("?sex", sex)
                                    };
            if (mysqlHelp.ExecuteNonQuery(sql2, p) == -1) return -1;

        }


     
     RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
     byte[] buff = new byte[16];
     rng.GetBytes(buff);


        string team_id = Convert.ToBase64String(buff);
        string date = DateTime.Now.ToString();

        string sql = "insert team (id,teachername,teacherinfo)values(?id,?teachername,?teacherinfo)";
        MySqlParameter[] p3 ={
                    new MySqlParameter("?id",team_id),
                    new MySqlParameter("?teachername",teachername),
                    new MySqlParameter("?teacherinfo", teacherinfo) };
        if (mysqlHelp.ExecuteNonQuery(sql, p3) == 0) return -2;

        sql = "insert underling (participant_id,team_id,jointime)values(?participant_id,?team_id,?jointime)";
     MySqlParameter[] p2 ={
                    new MySqlParameter("?participant_id",id),
                    new MySqlParameter("?team_id",team_id),
                    new MySqlParameter("?jointime", date) };
     if (mysqlHelp.ExecuteNonQuery(sql, p2) == 0) return -3;



        string signupdate = DateTime.Now.ToString();
        string cmd = "insert takepartin (competition_id,team_id,signupdate)values(?competition_id,?team_id,?signupdate)";
        MySqlParameter[] p4 =
        {
            new MySqlParameter ("?competition_id",competition_id),
            new MySqlParameter("?team_id",team_id),
            new MySqlParameter ("?signupdate",signupdate)
        };
        if (mysqlHelp.ExecuteNonQuery(cmd, p4) == 0) return -4;
       

        return 1;
            }








    }




























