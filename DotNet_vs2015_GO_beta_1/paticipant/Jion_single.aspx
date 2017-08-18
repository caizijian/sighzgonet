<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jion_single.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.WebSite.Jion_single" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
            姓名<asp:TextBox ID="name" runat="server" ></asp:TextBox>
            性别<asp:TextBox ID="sex" runat="server"></asp:TextBox>
        </p>
        <p>
            省<asp:TextBox ID="province" runat="server" Width="83px"></asp:TextBox>
            市 
            <asp:TextBox ID="city" runat="server"  Width="72px"></asp:TextBox>
&nbsp;学校<asp:TextBox ID="school" runat="server"></asp:TextBox>
&nbsp;专业<asp:TextBox ID="major" runat="server" Width="143px"></asp:TextBox>
        </p>
        <p>
            年级
            <asp:TextBox ID="grade" runat="server" Width="53px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 学号<asp:TextBox ID="number" runat="server"></asp:TextBox>
        </p>
        <p>
            邮箱<asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            手机<asp:TextBox ID="telephone" runat="server" ></asp:TextBox>
        </p>
        <p>
            微信<asp:TextBox ID="wechat" runat="server"></asp:TextBox>
        </p>
        <p>
            指导老师姓名<asp:TextBox ID="teachername" runat="server"></asp:TextBox>
        </p>
        <p>
            指导老师所在学校及学院<asp:TextBox ID="teacherinfo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="sure" runat="server" OnClick="sure_Click" Text="确定" />
        </p>
    
    </div>
    </form>
</body>
</html>
