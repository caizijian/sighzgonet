<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game_details.aspx.cs" Inherits="SightzGo.Game_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            height: 90px;
        }

    </style>
    <link href="../css/detail.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table class="back">
        <tr>
            <td class="auto-style1" draggable="true"><h2 class="title">赛事正文</h2></td>
            <td rowspan="2" class="title_back"><h2 class="title">摘要</h2></td>
        </tr>
        <tr>
            <td rowspan="9" class="left_back" draggable="true" translate="no">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                比赛名称：<asp:Label ID="Label1" runat="server" Text="比赛名称"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                主办单位：<asp:Label ID="Label2" runat="server" Text="主办单位"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                比赛时间：<asp:Label ID="Label3" runat="server" Text="比赛时间"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                最高奖金：<asp:Label ID="Label4" runat="server" Text="最高奖金"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                距离报名截止还有 
                <asp:Label ID="Label5" runat="server" Text="X"></asp:Label>
&nbsp;天</td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%; height: 45px;">
                <asp:Button ID="Button2" runat="server" Text="报名参赛" OnClick="Button1_Click" />
                <asp:Button ID="Button1" runat="server" Text="上传作品" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td class="title_back"><h2 class="title">公告栏</h2></td>
        </tr>
        <tr>
            <td class="right_back" style="width: 33%">&nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
