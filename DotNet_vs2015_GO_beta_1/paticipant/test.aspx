<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.WebSite.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <asp:TextBox ID="username" runat="server" ></asp:TextBox>
        <asp:TextBox ID="password" runat="server"  style="height: 23px"></asp:TextBox>
    
    </div>
        <p>
            <asp:Button ID="login" runat="server" OnClick="login_Click" Text="登录" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="join" runat="server" OnClick="Join_Click" Text="我要参赛" />
    </form>

</body>
</html>
