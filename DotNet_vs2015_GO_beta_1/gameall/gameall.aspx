<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gameall.aspx.cs" Inherits="DotNet_vs2015_GO_beta_1.gameall.gameall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/gameall.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 0px;
        }
        .auto-style2 {
            height: 0px;
        }
        .auto-style3 {
            height: 0px;
        }
        .auto-style4 {
            height: 0px;
        }
        .auto-style5 {
            height: 20px;
        }
        </style>
    </head>
<body>
    <form id="form1" runat="server">

<table class="back">
    <tr>
        <td>
    <table class="left_menu"  z-index: 1;">
        <tr>
            <td class="auto-style5"><h5 class="menutitle">赛事类别</h5></td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink1" runat="server" Class="menuitem" style="z-index: 1">全部</asp:HyperLink>
            </td>
            <td class="auto-style5"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" Class="menuclass" style="z-index: 1">工科</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" Class="menuitem" style="z-index: 1">数学建模</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink4" runat="server" Class="menuitem" style="z-index: 1">程序设计</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink5" runat="server" Class="menuitem" style="z-index: 1">机器人</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink6" runat="server" Class="menuitem" style="z-index: 1">工程机械</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink7" runat="server" Class="menuitem" style="z-index: 1">土木建筑</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink8" runat="server" Class="menuitem" style="z-index: 1">大数据</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink9" runat="server" Class="menuitem" style="z-index: 1">交通车辆</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink10" runat="server" Class="menuitem" style="z-index: 1">航空航天</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink11" runat="server" Class="menuitem" style="z-index: 1">船舶海洋</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink12" runat="server" Class="menuitem" style="z-index: 1">环境能源</asp:HyperLink>
            </td>
            <td colspan="2">
                <asp:HyperLink ID="HyperLink13" runat="server" Class="menuitem" style="z-index: 1">计算机&信息技术</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink14" runat="server" Class="menuitem" style="z-index: 1">材料高分子</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink15" runat="server" Class="menuitem" style="z-index: 1">电子&自动化</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink16" runat="server" Class="menuclass" style="z-index: 1">文体</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink17" runat="server" Class="menuitem" style="z-index: 1">工业&创意设计</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink18" runat="server" Class="menuitem" style="z-index: 1">服装设计</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink19" runat="server" Class="menuitem" style="z-index: 1">模特</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink20" runat="server" Class="menuitem" style="z-index: 1">演讲主持&辩论</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink21" runat="server" Class="menuitem" style="z-index: 1">歌舞书画摄影</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink22" runat="server" Class="menuitem" style="z-index: 1">外语</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink23" runat="server" Class="menuitem" style="z-index: 1">科技文化艺术节</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink24" runat="server" Class="menuitem" style="z-index: 1">电子竞技</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink25" runat="server" Class="menuitem" style="z-index: 1">体育</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink26" runat="server" Class="menuclass" style="z-index: 1">理科</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink27" runat="server" Class="menuitem" style="z-index: 1">化学化工</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink28" runat="server" Class="menuitem" style="z-index: 1">数学</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink29" runat="server" Class="menuitem" style="z-index: 1">物理</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink30" runat="server" Class="menuitem" style="z-index: 1">健康生命&医学</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink31" runat="server" Class="menuitem" style="z-index: 1">力学</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink32" runat="server" Class="menuclass" style="z-index: 1">综合</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink33" runat="server" Class="menuitem" style="z-index: 1">职业技能</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink34" runat="server" Class="menuitem" style="z-index: 1">挑战杯</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink35" runat="server" Class="menuitem" style="z-index: 1">创青春</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink36" runat="server" Class="menuitem" style="z-index: 1">环保公益</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink37" runat="server" Class="menuitem" style="z-index: 1">社会综合</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style5"><h5 class="menutitle">赛事级别</h5></td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink38" runat="server" Class="menuitem" style="z-index: 1">全部</asp:HyperLink>
            </td>
            <td class="auto-style5"></td>
            <td class="auto-style5">
                
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink39" runat="server" Class="menuitem" style="z-index: 1">国际级</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink40" runat="server" Class="menuitem" style="z-index: 1">国家级</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink41" runat="server" Class="menuitem" style="z-index: 1">省级</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink42" runat="server" Class="menuitem" style="z-index: 1">市级</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink43" runat="server" Class="menuitem" style="z-index: 1">校级</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink44" runat="server" Class="menuitem" style="z-index: 1">自由</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style5"><h5 class="menutitle">排序方式</h5></td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink45" runat="server" Class="menuitem" style="z-index: 1">全部</asp:HyperLink>
            </td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink46" runat="server" Class="menuitem" style="z-index: 1">近期报名</asp:HyperLink>
            </td>
            <td class="auto-style5">
                <asp:HyperLink ID="HyperLink47" runat="server" Class="menuitem" style="z-index: 1">最近更新</asp:HyperLink>
            </td>
        </tr>


    </table>
        </td>
        <td>
    <table class="right_show"  z-index: 1;">
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">比赛时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">比赛结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="game" z-index: 1;">
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="game_status">正在报名</asp:Label>
                        </td>
                        <td>
                            <asp:HyperLink runat="server" CssClass="gametitle">赛事名称</asp:HyperLink>
                        </td>
                        <td>
                            <asp:Button runat="server" Text="点击报名"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">主办方</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">主办方名称</asp:Label>
                        </td>
                        <td>
                            <span class="texttitle">距离报名截止还有</span>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">XX</asp:Label>
                            <span class="texttitle">天</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">竞赛级别</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">级别</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="texttitle">报名时间</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名开始时间</asp:Label>
                            <span class="textcontent">~</span>
                            <asp:Label runat="server" Text="Label" CssClass="textcontent">报名结束时间</asp:Label>
                        </td>
                        <td>

                        </td>
                    </tr>
                    
                </table>
            </td>
        </tr>

    </table>
        </td>
    </tr>
</table>
    </form>
    </body>
</html>
