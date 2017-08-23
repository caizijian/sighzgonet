<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my_game.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.my_game.my_game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
            height: auto;
            position: absolute;
            top: 15px;
            left: 200px;
        }

        .button {
            width:50px;
            height:30px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CssClass="auto-style1" OnPageIndexChanging="GridView1_PageIndexChanging"  PageSize="5" style="z-index: 1" CellPadding="4" ForeColor="#333333" GridLines="None"  AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="赛事ID" Visible="false"/>
                <asp:BoundField DataField="competitionname" HeaderText="比赛名称" Visible="true"/>
                <asp:BoundField DataField="content" HeaderText="比赛动态" Visible="true"/>
                <asp:ButtonField ButtonType="Button" HeaderText="操作" />
                
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    
    </div>

        
    </form>
</body>
</html>
