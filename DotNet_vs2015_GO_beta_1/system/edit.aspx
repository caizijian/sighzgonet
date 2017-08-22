<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="edit.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../css/head&foot.css" type="text/css" />
    <style type="text/css">
        div.list{
    position:relative;
    float:left;
    top:80px;
    width: 15%;
    height: 298px;
    margin: 10px;
    overflow: hidden;
}
        div.list li a {
    display: block;
    margin-left:30%;
    padding:0px;
    font-family: 微软雅黑;
    font-style: normal;
    font-weight: 200;
    font-size:18px ;
    text-align: center;
    color: #a0a0a0;
    text-decoration: none;
}
div.list li:hover > a{
    font-size:20px ;
    color:#ffffff ;
}
div.content{
    position:relative;
    float: left;
    top:80px;
    width: 60%;
    margin-left: 5%;
}
div.content h3{
    display: block;
    margin-left:2%;
    padding:0;
    font-family: 微软雅黑;
    font-style: normal;
    font-weight: 200;
    font-size:18px ;
    text-align: left;
    color: #ffffff;
    text-decoration: none;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header">

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

        <div class="search">
            <img src="../images/search.jpg" alt="赛事go" />
            <input type="search" id="user_name" name="user_name" placeholder="搜索赛事或内容"/>
        </div>

        <div class="information">
            <div class="me">
                <img src="../images/me.png" />
                <ul>
                    <li><a href="me_for_sponsor_readonly.html">个人资料</a></li>
                    <li><br/></li>
                    <li><a href="Resetpassword.html">账号安全</a></li>
                    <li><br/></li>
                    <li><a href="#" onclick="logout()">退出账号</a></li>
                </ul>
            </div>

     

            <div class="e-mail">
                <img src="../images/information.png"/>
                <ul>
                    <li><a href="#">私信</a></li>
                    <li><br/></li>
                    <li><a href="#">评论</a></li>
                    <li><br/></li>
                    <li><a href="#">系统消息</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div>
    <div class="list">
        <nav>
            <ul>
                <li >
                    <a href="#">个人资料</a>
                    <div class="line"></div><br />
                </li>
                <li>
                    <a href="#">账号安全</a>
                    <div class="line"></div><br />
                </li>
                <li>
                    <a href="#">退出登录</a>
                    <div class="line"></div>
                </li>
            </ul>
        </nav>
    </div>
   <div class="content">
    <br/>
        <br /><h3>个人头像</h3>
        <div class="lineone"></div><hr />
        <br /><br />
         <span class="sl-custom-file">
             <p><asp:Image ID="head" runat="server" style="height:100px;margin-left:300px;margin-bottom:10px;"/></p>
         <asp:Button ID="changehead" runat="server" Text="更改头像" OnClick="changehead_Click" style="margin-left:300px;margin-right:50px;" /><asp:FileUpload ID="FileUpload1" runat="server" />
         </span>
        <!--<input type="file" name="head" class="" accept="image/*" >-->
        <br /><br /><br /><br /><br />
        <h3>基本资料</h3>
        <div class="lineone"></div><hr />
        <div class="text">
            <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>负责人姓名：</p></div>
            <div style="width:280px;display:inline;"><asp:TextBox ID="menagername" runat="server" style="margin-left:20px; width :240px;display:inline;"  MaxLength="30"></asp:TextBox></div></div>

            <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>公司/组织名称：</p></div>
            <div style="width:280px;display:inline;"><asp:TextBox ID="companyname" runat="server" style="margin-left:20px; width :240px;display:inline;"  MaxLength="30"></asp:TextBox></div></div>

            <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>营业执照(或其他证明文件)：</p></div>
            <div style="width:280px;display:inline;">
                <asp:Button ID="update" runat="server" Text="上传" style="margin-left:20px; width :80px;display:inline;" OnClick="update_Click" /><asp:FileUpload ID="FileUpload2" runat="server" style="margin-left:20px;" /></div></div>



            <div style="margin-top:10px;float:left;width:100%;height:170px;"><div style="width:240px;text-align:right;float:left;display:inline;"><p>主营业务：</p></div>
            <div style="width:280px;display:inline;height:170px;"><asp:TextBox ID="mainbusiness" runat="server" style="margin-left:20px; width :240px;height:168px; display:inline;"  MaxLength="150" TextMode="MultiLine"></asp:TextBox></div></div>

            <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>微信号：</p></div>
            <div style="width:280px;display:inline;"><asp:TextBox ID="wechat" runat="server" style="margin-left:20px; width :240px;display:inline;"  MaxLength="20"></asp:TextBox></div></div>

             <div style="margin-top:10px;float:left;width:100%"><div style="width:240px;text-align:right;float:left;display:inline;"><p>联系电话：</p></div>
            <div style="width:280px;display:inline;"><asp:TextBox ID="telephone" runat="server" style="margin-left:20px; width :240px;display:inline;"  MaxLength="11" TextMode="Phone"></asp:TextBox></div></div>

             <div style="margin-top:10px;float:left;width:100%">
             <asp:Button ID="save" runat="server" Text="保存" OnClick="save_Click" /> <asp:Button ID="cancel" runat="server" Text="取消" OnClick="cancel_Click" /></div>
        </div>
       
</div>





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
        </div>>
    </form>
</body>
</html>
