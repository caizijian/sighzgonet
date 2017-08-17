<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game_details.aspx.cs" Inherits="SightzGo.Game_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            height: 80px;
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
            <td rowspan="4" class="left_back" draggable="true" translate="no">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="right_back">
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="competitionname" HeaderText="比赛名称" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="title_back"><h2 class="title">公告栏</h2></td>
        </tr>
        <tr>
            <td class="right_back">&nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
