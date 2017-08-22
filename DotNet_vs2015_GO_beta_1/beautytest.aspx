<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="beautytest.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.beautytest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


.texttitle {
    font-size:14px;
    font-weight:bolder;
    color:#909090;

}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server"  >
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="正在报名" CssClass="game_status"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="赛事名称" CssClass="gametitle"></asp:Label>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                主办方名称<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <br />
                竞赛级别<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                报名时间<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                <br />
                比赛时间
             
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
