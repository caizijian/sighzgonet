<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="launch2.aspx.cs" Inherits="WebApplication1._2" %>

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
            height: 558px;
        }
        .auto-style3 {
            height: 61px;
        }
        .auto-style4 {
            height: 366px;
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
            height: 366px;
            width: 173px;
        }
        .auto-style8 {
            width: 173px;
        }
        .auto-style9 {
            height: 61px;
            width: 580px;
        }
        .auto-style10 {
            height: 366px;
            width: 580px;
        }
        .auto-style11 {
            width: 580px;
        }
        .auto-style12 {
            width: 127%;
            height: 300px;
        }
        .auto-style13 {
            width: 185px;
        }
        .auto-style14 {
            width: 185px;
            height: 164px;
        }
        .auto-style15 {
            height: 164px;
        }
        .auto-style16 {
            width: 185px;
            height: 46px;
        }
        .auto-style17 {
            height: 46px;
        }
        .auto-style18 {
            width: 185px;
            height: 40px;
        }
        .auto-style19 {
            height: 40px;
        }
        .auto-style20 {
            width: 185px;
            height: 41px;
        }
        .auto-style21 {
            height: 41px;
        }
        .auto-style22 {
            width: 185px;
            height: 50px;
        }
        .auto-style23 {
            height: 50px;
        }
        </style>
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
                            <td class="auto-style22">
                                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                主办方名称：</td>
                            <td class="auto-style23">
                                &nbsp;<asp:DropDownList ID="bind_Province" CssClass="styled" runat="server" AutoPostBack="True" onselectedindexchanged="bind_Province_SelectedIndexChanged" Height="24px" Width="77px"> 
                                </asp:DropDownList>&nbsp;省 <asp:DropDownList ID="bind_City" CssClass="styled" runat="server" AutoPostBack="True" onselectedindexchanged="bind_City_SelectedIndexChanged" Height="24px" Width="84px">
                                </asp:DropDownList>&nbsp;市 <asp:DropDownList ID="Bind_Area" CssClass="styled" runat="server" Height="24px" Width="83px" AutoPostBack="True">
                                </asp:DropDownList>&nbsp;区
                            </td>
                        </tr>
                      <tr>
                            <td class="auto-style13">&nbsp;</td>
                            <td>
                                <asp:TextBox ID="managername" runat="server" Height="20px" Width="222px" Placeholder="公司/社会团体/学生社团名称等"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                证明文件：<br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                            </td>
                            <td class="auto-style15">
                                &nbsp;
                                <br />
&nbsp;<asp:Image ID="pic" runat="server" Height="68px" Width="83px" />
&nbsp;&nbsp;
                                <br />
&nbsp;<asp:Label ID="lbl_pic" runat="server" Text="上传图片格式为.jpg, .gif, .bmp,.png,图片大小不得超过8M" BorderStyle="None" Font-Size="XX-Small" Height="16px" Width="186px"></asp:Label>
                                <br />
                                <br />
&nbsp;<asp:FileUpload ID="pic_upload" runat="server" Height="27px" Width="156px" />
&nbsp;&nbsp;
                                     <asp:Button ID="btn_upload" runat="server"  Text="上传" onclick="btn_upload_Click" Height="26px" Width="63px"/>  
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style16">
                                <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                联系电话：</td>
                            <td class="auto-style17">
                                <asp:TextBox ID="telephone" runat="server" Height="20px" Width="222px" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style18">
                                <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                邮箱：</td>
                            <td class="auto-style19">
                                <asp:TextBox ID="email" runat="server" Height="20px" Width="222px" OnTextChanged="email_TextChanged" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">微信号：</td>
                            <td class="auto-style21">
                                <asp:TextBox ID="wechat" runat="server" Height="20px" Width="222px" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                               
                            </td>
                            <td id="d">
                                <asp:Button ID="Button1" runat="server" BackColor="#002D54" BorderWidth="0px" Font-Size="Large" ForeColor="White" Height="27px" Text="下一步" Width="62px" OnClick="Button1_Click" />
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
