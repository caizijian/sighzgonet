<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shangchuang.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.shangchuang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 403px;
        }
    </style>
</head>
<body style="height: 570px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
                                <asp:FileUpload ID="pic_upload" runat="server" Height="27px" Width="73px" />
&nbsp;&nbsp;&nbsp;
                                     <asp:Button ID="btn_upload" runat="server"  Text="上传" onclick="btn_upload_Click" Height="26px" Width="63px"/>  
                                &nbsp;&nbsp; <asp:Label ID="lbl_pic" runat="server" Text="请上传文件" BorderStyle="None" Font-Size="XX-Small" Height="16px" Width="186px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
