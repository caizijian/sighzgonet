<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="launch4.aspx.cs" Inherits="WebApplication1._4" %>

<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1014px;
        }
        .auto-style2 {
            width: 100%;
            height: 711px;
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
            width: 151px;
        }
        .auto-style7 {
            height: 366px;
            width: 151px;
        }
        .auto-style8 {
            width: 151px;
        }
        .auto-style9 {
            height: 61px;
            width: 539px;
        }
        .auto-style10 {
            height: 366px;
            width: 539px;
        }
        .auto-style11 {
            width: 539px;
        }
        .auto-style14 {
            width: 100%;
            height: 675px;
        }
        .auto-style16 {
            width: 413px;
            height: 42px;
        }
        .auto-style21 {
            width: 413px;
            height: 75px;
        }
        .auto-style24 {
            width: 413px;
            height: 52px;
        }
        .auto-style27 {
            width: 413px;
            height: 6px;
        }
        .auto-style28 {
            width: 413px;
            height: 432px;
        }
        .auto-style29 {
            width: 413px;
            height: 45px;
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
                   
                    <table class="auto-style14">
                        <tr>
                            <td class="auto-style21">
                                <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="391px" placeholder="标题"></asp:TextBox>
                            </td>                           
                        </tr>
                        <tr>
                            <td class="auto-style24">&nbsp;&nbsp;温馨提示：此页所编辑信息将在赛事资讯页面上提示，请自行编辑好文本格式，注意标题与分段</td>                           
                        </tr>
                         <tr>
                            <td class="auto-style27">
                             </td>                           
                        </tr>
                        <tr>
                            <td class="auto-style28">
                                <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="300px" >
                                </FCKeditorV2:FCKeditor>
                                <br />
&nbsp;<br />
                                <br />
                                <asp:FileUpload ID="pic_upload" runat="server" Height="27px" Width="73px" />
&nbsp;&nbsp;
                                     <asp:Button ID="btn_upload" runat="server"  Text="上传" onclick="btn_upload_Click" Height="26px" Width="63px"/>  
                                &nbsp;&nbsp; <asp:Label ID="lbl_pic" runat="server" Text="文件大小不得超过8M" BorderStyle="None" Font-Size="XX-Small" Height="16px" Width="186px"></asp:Label>
                                <br />
                                <br />
&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#002D54" BorderWidth="0px" Font-Size="Large" ForeColor="White" Height="26px" Text="提交申请" Width="81px" OnClick="Button1_Click" />
                            </td>                        
                        </tr>
                         <tr>
                            <td class="auto-style29">
                             &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                </td>                        
                        </tr>
                        <tr>
                            <td class="auto-style16">
                                &nbsp;&nbsp; &nbsp;</td>
                            
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

