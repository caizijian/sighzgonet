<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uglyallgame.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.uglyallgame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="选择" OnClick="Button1_Click" />
    </form>
</body>
</html>
