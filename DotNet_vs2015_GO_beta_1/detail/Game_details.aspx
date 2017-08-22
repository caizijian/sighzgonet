<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game_details.aspx.cs" Inherits="SightzGo.Game_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/detail.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 80px;
            border-bottom:2px solid #808080
        }
        .auto-style2 {
            position: relative;
            left: -8px;
        }
        .auto-style3 {
            position: relative;
            left: 8px;
        }
        .auto-style4 {
            text-align: left;
            padding:0 20px;
        }
        .auto-style5 {
            height: 44px;
        }
        .auto-style6 {
            text-align: right;
            padding:0 20px;
            font-size:14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="back_left">
        <tr>
            <td draggable="true" class="auto-style1">
                <h2 class="title">赛事正文</h2>
            </td>
        </tr>
        <tr>
            <td draggable="true">
                <asp:Label ID="Label6" runat="server" Font-Size="X-Large" Text="这是比赛正文" style="position: relative"></asp:Label>
            </td>
        </tr>
        </table>
        <table class="back_right_top">
        <tr>
            <td draggable="true" class="auto-style1">
                <h2 class="title">摘要</h2>
                </td>
        </tr>
        <tr>
            <td draggable="true" class="text">
                &nbsp;</td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                比赛名称：<asp:Label ID="Label1" runat="server" Text="比赛名称"></asp:Label>
                </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                主办单位：<asp:Label ID="Label2" runat="server" Text="主办单位"></asp:Label>
                </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                比赛时间：<asp:Label ID="Label3" runat="server" Text="比赛时间"></asp:Label>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                最高奖金：<asp:Label ID="Label4" runat="server" Text="最高奖金"></asp:Label>
                </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                <span id="ddl_left" runat ="server">距离报名截止还有&nbsp;</span>
                <asp:Label ID="Label5" runat="server" Text="X"></asp:Label>
                <span id="ddl_right" runat ="server">&nbsp;天</span></td>
        </tr>
        <tr>
            <td draggable="true" class="text">
                <asp:Button ID="Button1" runat="server" Text="报名参赛" OnClick="Button1_Click" CssClass="auto-style2" />
                <asp:Button ID="Button2" runat="server" Text="上传作品" OnClick="Button2_Click" CssClass="auto-style3" />
                </td>
        </tr>
        <tr>
            <td draggable="true" class="text">
                &nbsp;</td>
        </tr>
        </table>
        <table class="back_right_down">
        <tr>
            <td draggable="true" class="auto-style1">
                <h2 class="title">公告栏</h2>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
               <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style4">
                <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        <tr>
            <td draggable="true" class="auto-style6">
                <a href="#">More&gt;&gt;</a>
            </td>
        </tr>
        </table>
    </form>
</body>
</html>
