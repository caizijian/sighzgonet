<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jion_team.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.Jion_team" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main" style="display: block" class="auto-style1">
            <div>团队名称<asp:TextBox ID="teamname" runat="server"></asp:TextBox></div>
            <div>团队简介<asp:TextBox ID="teaminfo" runat="server"></asp:TextBox></div>
            <div>添加成员<asp:Button ID="addmenmber" runat="server" Text="添加成员" OnClientClick="return ShowBlock();" Style="height: 27px" /></div>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox2" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" Visible="False" />
                    <asp:BoundField DataField="realname" HeaderText="姓名" ReadOnly="True" />
                    <asp:BoundField DataField="school" HeaderText="学校" ReadOnly="True" />
                    <asp:BoundField DataField="number" HeaderText="学号" ReadOnly="True" />
                </Columns>
            </asp:GridView>
            <div>指导老师名字<asp:TextBox ID="teachername" runat="server"></asp:TextBox></div>
            <div>指导老师学校及学院<asp:TextBox ID="teacherinfo" runat="server"></asp:TextBox></div>
            <div>
                <asp:Button ID="joincompetition" runat="server" Text="参加比赛" OnClick="joincompetition_Click" />
            </div>
        </div>


        <!--弹出层，-->
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="divNewBlock" style="border: solid 5px; padding: 10px; width: 600px; z-index: 1001; position: absolute; display: none; top: 50%; left: 10%; margin: -50px;">
            <div style="padding: 3px 15px 3px 15px; text-align: left; vertical-align: middle;">
                <div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            请输入用户名呵呵
                            <asp:TextBox ID="membername" runat="server"></asp:TextBox><asp:Button ID="find" runat="server" Text="查找" OnClick="find_Click" />
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:TemplateField HeaderText="选择">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" Visible="False" />
                                    <asp:BoundField DataField="realname" HeaderText="姓名" ReadOnly="True" />
                                    <asp:BoundField DataField="school" HeaderText="学校" ReadOnly="True" />
                                    <asp:BoundField DataField="number" HeaderText="学号" ReadOnly="True" />
                                </Columns>
                            </asp:GridView>
                            <asp:Button ID="sureadd" runat="server" Text="确认添加" OnClick="sureadd_Click" />
                            <asp:Button ID="cancel" runat="server" Text="关闭" OnClientClick="return HideBlock();" />
                        </ContentTemplate>
                        <Triggers>
                            <asp:PostBackTrigger ControlID="sureadd" />
                            <asp:PostBackTrigger ControlID="cancel" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>


<script type="text/javascript">
    function HideBlock() {
        document.getElementById("divNewBlock").style.display = "none";
        document.getElementById("main").style.display = "block";
        return false;
    }


    function ShowBlock() {
        var set = SetBlock();
        document.getElementById("divNewBlock").style.display = "block";
        document.getElementById("main").style.display = "none";
        return false;
    }


    function SetBlock() {
        var top = document.body.scrollTop;
        var left = document.body.scrollLeft;
        var height = document.body.clientHeight;
        var width = document.body.clientWidth;


        if (top == 0 && left == 0 && height == 0 && width == 0) {
            top = document.documentElement.scrollTop;
            left = document.documentElement.scrollLeft;
            height = document.documentElement.clientHeight;
            width = document.documentElement.clientWidth;
        }
        return { top: top, left: left, height: height, width: width };
    }


    function Operate() {
        return false;
    }
</script>
</html>
