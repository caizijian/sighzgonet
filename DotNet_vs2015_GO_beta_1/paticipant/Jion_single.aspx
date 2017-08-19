<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jion_single.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.WebSite.Jion_single" %>



   
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="../css/head&foot.css" type="text/css" />
    <style type="text/css"></style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div class="logo">
            <a href="Home.html"><img  class="logo" src="../images/logo.jpg" alt="赛事go" /></a>
        </div>

        <div class="title">
            <h1>赛事go</h1>
        </div>

              <div class="nav">
            <ul >
                <li><a href="launch.html">发起比赛</a></li>
                <li><a href="#">比赛管控</a></li>
                <li><a href="Game_all.html">赛事资讯</a></li>
                <li><a href="SignIn.html">登录与注册</a></li>
            </ul>
        </div>


                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>姓名</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>性别</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="sex" runat="server"></asp:TextBox>
                 </div>
            </div>
 
                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>省</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="province" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>市</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="city" runat="server"></asp:TextBox>
                 </div>
            </div>

                  <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>学校</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="school" runat="server"></asp:TextBox>
                 </div>
            </div>

                         <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>专业</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="major" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>年级</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="grade" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>学号</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="number" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>邮箱</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                 </div>
            </div>
     
                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>手机</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="telephone" runat="server" ></asp:TextBox>
                 </div>
            </div>
    
                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>微信</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="wechat" runat="server"></asp:TextBox>
                 </div>
            </div>

                 <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>指导老师姓名</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="teachername" runat="server"></asp:TextBox>
                 </div>
            </div>
 
                  <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>指导老师所在学校及学院</p></div>
            <div style="width:280px;display:inline;"></div>
                 <div style="width:280px;display:inline;">
                    <asp:TextBox ID="teacherinfo" runat="server"></asp:TextBox>
                 </div>
            </div>

            <div style="margin-top:10px;float:left;width:100%">
            <asp:Button ID="sure" runat="server" OnClick="sure_Click" Text="确定" /></div>
        
    
    <div id="footer">
        <div class="footBack">
            <div class="footText1">
                <a href="#"><h4>关于我们</h4></a>
                <a href="#"><p>了解我们</p></a>
                <a href="#"><p>联系我们</p></a>
                <a href="#"><p>公众号</p></a>
            </div>
            <div class="footText2">
                <a href="#"><h4>帮助中心</h4></a>
                <a href="#"><p>常见问题</p></a>
                <a href="#"><p>社区规范</p></a>
                <a href="#"><p>产品介绍</p></a>
            </div>
            <div class="footText3">
                <a href="#"><h4>合作伙伴</h4></a>
                <a href="#"><p>敬请期待</p></a>
                <a href="#"><p>敬请期待</p></a>
                <a href="#"><p>敬请期待</p></a>
            </div>
        </div>
        </div>



        </div>
    </form>
</body>
</html>
