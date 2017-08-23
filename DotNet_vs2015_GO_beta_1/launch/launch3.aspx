<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="launch3.aspx.cs" Inherits="WebApplication1._3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 643px;
        }
        .auto-style2 {
            width: 100%;
            height: 650px;
        }
        .auto-style3 {
            height: 61px;
        }
        .auto-style4 {
            height: 396px;
        }
        .auto-style5 {
            width: 523px;
            height: 133px;
        }
        .auto-style6 {
            height: 61px;
            width: 173px;
        }
        .auto-style7 {
            height: 396px;
            width: 173px;
        }
        .auto-style8 {
            width: 173px;
        }
        .auto-style9 {
            height: 61px;
            width: 522px;
        }
        .auto-style10 {
            height: 396px;
            width: 522px;
        }
        .auto-style11 {
            width: 522px;
        }
        .auto-style12 {
            width: 100%;
            height: 300px;
        }
        .auto-style13 {
            width: 185px;
        }
        .auto-style16 {
            width: 185px;
            height: 191px;
        }
        
        .auto-style18 {
            width: 185px;
            height: 34px;
        }
        .auto-style19 {
            height: 34px;
        }

        .auto-style20 {
            width: 185px;
            height: 38px;
        }
        .auto-style21 {
            height: 38px;
        }
        .auto-style22 {
            width: 185px;
            height: 41px;
        }
        .auto-style23 {
            height: 41px;
        }

        .auto-style24 {
            height: 191px;
        }

    </style>
     <script type="text/JavaScript" src="My97DatePicker/WdatePicker.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <table class="auto-style2">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style9">
                    <img class="auto-style5" src="../images/launch.jpg" /></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style10">
                    <table class="auto-style12">
                        <tr>
                            <td class="auto-style18">
                                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                赛事名称：</td>
                            <td class="auto-style19">
                                <asp:TextBox ID="competitionname" runat="server" Height="19px" Width="236px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style22">
                                <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                赛事级别：</td>
                            <td class="auto-style23">
                                <asp:DropDownList ID="level_id" runat="server" Height="20px" Width="73px" OnSelectedIndexChanged="level_id_SelectedIndexChanged">
                                    <asp:ListItem>请选择</asp:ListItem>
                                    <asp:ListItem Value="1">国家级</asp:ListItem>
                                    <asp:ListItem Value="2">省级</asp:ListItem>
                                    <asp:ListItem Value="3">市级</asp:ListItem>
                                    <asp:ListItem Value="4">校级</asp:ListItem>
                                    <asp:ListItem Value="5">自由</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                      <tr>
                            <td class="auto-style16">
                                <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                赛事形式：</td>
                            <td class="auto-style24">
                                <asp:RadioButtonList runat="server" AutoPostBack="True" RepeatDirection="Horizontal"
ID="radiobuttonlistabc" OnSelectedIndexChanged="radiobuttonlistabc_SelectedIndexChanged">
<asp:ListItem Value="1">个人赛</asp:ListItem>
<asp:ListItem Value="2">团队赛</asp:ListItem>
</asp:RadioButtonList><br />
                                <asp:Panel ID="Panel1" runat="server" Width="238px" Visible="False" Height="41px"> 每组： <asp:TextBox ID="minmember" runat="server" OnTextChanged="minmember_TextChanged" Width="34px" onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;" Height="20px" TextMode="Number"></asp:TextBox>
                                &nbsp;— <asp:TextBox ID="maxmember" runat="server" Width="32px" onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;" Height="20px" OnTextChanged="maxmember_TextChanged" TextMode="Number"></asp:TextBox>
&nbsp;人</asp:Panel>
                          <asp:Panel ID="Panel2" runat="server" Width="147px" Visible="False">
</asp:Panel>      
&nbsp;<br />
                                <br />

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                赛事类型：</td>
                            <td class="auto-style21">
                                <asp:DropDownList ID="type_id" runat="server" Height="36px" Width="73px">
                                    <asp:ListItem>请选择</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                报名起止时间：</td>
                            <td>
                                <asp:TextBox ID="signupstarttime" runat="server" Height="19px" Width="143px" placeholder="yyyy/mm/dd-hh:mm" onfocus="WdatePicker({dateFmt:'yyyy/MM/dd HH:mm'})"></asp:TextBox>
                            &nbsp;
                                <asp:TextBox ID="ddl" runat="server" Height="19px" Width="143px" placeholder="yyyy/mm/dd-hh:mm" onfocus="WdatePicker({dateFmt:'yyyy/MM/dd HH:mm'})"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                比赛起止时间：</td>
                            <td>
                                <asp:TextBox ID="starttime" runat="server" Height="19px" Width="143px" placeholder="yyyy/mm/dd-hh:mm" OnTextChanged="TextBox5_TextChanged" onfocus="WdatePicker({dateFmt:'yyyy/MM/dd HH:mm'})"></asp:TextBox>
                            &nbsp;
                                <asp:TextBox ID="endtime" runat="server" Height="19px" Width="143px" placeholder="yyyy/mm/dd-hh:mm:ss" OnTextChanged="TextBox6_TextChanged" onfocus="WdatePicker({dateFmt:'yyyy/MM/dd HH:mm'})"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                最高奖金：</td>
                            <td>
                                <asp:TextBox ID="maxbouns" runat="server" Height="19px" Width="100px" placeholder="格式如10000" OnTextChanged="bouns_TextChanged" MaxLength="8"  TextMode="Number"></asp:TextBox>
&nbsp;元&nbsp;&nbsp; 
                           
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">&nbsp;</td>
                            <td id="d">
                                <asp:Button ID="Button1" runat="server" BackColor="#002D54" BorderWidth="0px" Font-Size="Large" ForeColor="White" Height="26px" Text="提交申请" Width="81px" OnClick="Button1_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

