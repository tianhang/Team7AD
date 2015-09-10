<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrendForSupplier.aspx.cs" Inherits="LogicUniv1._1.webpage.stockSupervisor.TrendForSupplier" %>

<!DOCTYPE html>

<html>
<head>
	
	<title>Logic Unviersity Stationery Inventory System</title>
	<meta name="keywords" content="" />
	<meta name="description" content="" />
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="../css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href="../css/templatemo_style.css" rel="stylesheet" type="text/css">	

    <!-- bootstrap -->
    <link href="../css/bootstrap/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap/bootstrap-overrides.css" type="text/css" rel="stylesheet" />
    <!-- libraries -->
    <link href="../css/lib/jquery-ui-1.10.2.custom.css" rel="stylesheet" type="text/css" />
    <link href="../css/lib/font-awesome.css" type="text/css" rel="stylesheet" />
    <!-- global styles -->
    <link rel="stylesheet" type="text/css" href="../css/compiled/layout.css">
    <link rel="stylesheet" type="text/css" href="../css/compiled/elements.css">
    <link rel="stylesheet" type="text/css" href="../css/compiled/icons.css">

    <!-- this page specific styles -->
    <link rel="stylesheet" href="../css/compiled/index.css" type="text/css" media="screen" />
    	<!-- scripts -->
    <script src="../js/jquery-1.11.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery-ui-1.10.2.custom.min.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>
    <style type="text/css">
        .auto-style2 {
            height: 17px;
            text-align: left;
        }
        .auto-style3 {
            height: 17px;
            width: 91px;
        }
    </style>
</head>
<body>
    <header class="navbar navbar-inverse" role="banner">
        <ul class="nav navbar-nav pull-right hidden-xs">
            <li class="hidden-xs hidden-sm">
                <input class="search" type="text" />
            </li>
            <li class="notification-dropdown hidden-xs hidden-sm">
                <a href="#" class="trigger">
                    <i class="icon-warning-sign"></i>
                    <span class="count">8</span>
                </a>
                <div class="pop-dialog">
                    <div class="pointer right">
                        <div class="arrow"></div>
                        <div class="arrow_border"></div>
                    </div>
                    <div class="body">
                        <a href="#" class="close-icon"><i class="icon-remove-sign"></i></a>
                        <div class="notifications">
                            <h3>你有6条信息</h3>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 13分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 18分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-envelope-alt"></i> 新消息来自Alejandra
                                <span class="time"><i class="icon-time"></i> 28分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-signin"></i> 新用户注册
                                <span class="time"><i class="icon-time"></i> 49分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <i class="icon-download-alt"></i> 新订单
                                <span class="time"><i class="icon-time"></i> 1天前.</span>
                            </a>
                            <div class="footer">
                                <a href="#" class="logout">查看所有消息</a>
                            </div>
                        </div>
                    </div>
                </div>
            </li>
            
            <li class="dropdown">
                <a href="#" class="dropdown-toggle hidden-xs hidden-sm" data-toggle="dropdown">
                    你的账号
                    <b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="personal-info.html">个人信息</a></li>
                    <li><a href="#">账号设置</a></li>
                    <li><a href="#">账单</a></li>
                    <li><a href="#">导出数据</a></li>
                    <li><a href="#">发送反馈</a></li>
                </ul>
            </li>
            <li class="settings hidden-xs hidden-sm">
                <a href="personal-info.html" role="button">
                    <i class="icon-cog"></i>
                </a>
            </li>
            <li class="settings hidden-xs hidden-sm">
                <a href="signin.html" role="button">
                    <i class="icon-share-alt"></i>
                </a>
            </li>
        </ul>
    </header>

    
	<form id="form1" runat="server">
        
	<div class="templatemo-container">
<div class="col-lg-3 col-md-3 col-sm-3  black-bg left-container" id="leftlayer">
			<h1 class="logo-left hidden-xs margin-bottom-60" style="color:white">Logic</h1>			
			<div class="tm-left-inner-container">
				<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="SSHome.aspx" ><i class="fa fa-home fa-medium"></i>Discrepancy</a></li>
				  <li><a href="CompareThreeMonths.aspx" ><i class="fa fa-shopping-cart fa-medium"></i>Department Request bar</a></li>
				  <li><a href="TrendForSupplier.aspx"class="active"><i class="fa fa-send-o fa-medium"></i>Trend for supplier</a></li>
				  <li><a href="ReportOrder.aspx" ><i class="fa fa-comments-o fa-medium"></i>Reorder Chart</a></li>
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            
           <div>
               <table>
                   <tr>
                       <td class="auto-style3">

                           <asp:Label ID="Label1" runat="server" Text="Department:"></asp:Label>

                       </td>
                       <td class="auto-style2">

                           <asp:DropDownList ID="DropDownListDepartment" runat="server">
                           </asp:DropDownList>

                       </td>
                       <td class="auto-style2">

                       </td>
                        <td class="auto-style2">

                       </td>
                       <td></td>
                   </tr>
                   <tr>
                       <td class="auto-style3">

                           <asp:Label ID="Label2" runat="server" Text="Category:"></asp:Label>

                       </td>
                       <td class="auto-style2">

                           <asp:DropDownList ID="DropDownListCategory" runat="server">
                           </asp:DropDownList>

                       </td>
                       <td class="auto-style2">

                       </td>
                        <td class="auto-style2">

                       </td>
                       <td class="auto-style2"></td>
                   </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Type:"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownListType" runat="server">
                                <asp:ListItem>Quantity</asp:ListItem>
                                <asp:ListItem>Cost</asp:ListItem>
                            </asp:DropDownList></td>
                        <td></td>
                        <td></td>
                    </tr>
                   </Table>



               <Table>
                   <tr>
                       <td class="auto-style3">

                           <asp:Label ID="Label3" runat="server" Text="Month:"></asp:Label>

                       </td>
                       <td class="auto-style2">

                           <asp:Label ID="Label4" runat="server" Text="From:"></asp:Label>

                       </td>
                       <td class="auto-style2">

                           <asp:DropDownList ID="DropDownListMonthFrom" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                           </asp:DropDownList>

                       </td>
                        <td class="auto-style2">

                            <asp:Label ID="Label5" runat="server" Text="To:"></asp:Label>

                       </td>
                       <td>
                           <asp:DropDownList ID="DropDownListMonthTo" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                           </asp:DropDownList>
                       </td>
                   </tr>
               </table>
           </div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
             <div>


                <asp:Chart ID="Chart1" runat="server" Width="887px" OnLoad="Chart1_Load">
                            <Series>
                                <asp:Series Name="Series1" Label="#VAL" Legend="Legend1" LegendText="Month"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1" >
                                    
                                </asp:ChartArea>
                            </ChartAreas>
                                            <Legends>
                            <asp:Legend Name="Legend1">
                            </asp:Legend>
                          
                        </Legends>
                        </asp:Chart>

            </div>
           <div>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
               </div>

				<footer>
					<p class="col-lg-3 col-md-3  templatemo-copyright">Copyright &copy; 2015 Logic University designed by NUS ISS SA 40 Team 7 </p>
					<p class="col-lg-9 col-md-9  templatemo-social">
						<a href="#"><i class="fa fa-facebook fa-medium"></i></a>
						<a href="#"><i class="fa fa-twitter fa-medium"></i></a>
						<a href="#"><i class="fa fa-google-plus fa-medium"></i></a>
						<a href="#"><i class="fa fa-youtube fa-medium"></i></a>
						<a href="#"><i class="fa fa-linkedin fa-medium"></i></a>
					</p>
				</footer>
			</div>
        </div>	
		<!-- right section -->
    </form>
        <script>
    $(function () {
        console.log(window.innerHeight);
        var height = (window.innerHeight);
                console.log(height);
                document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");
                document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
            });
</script>

</body>
    </html>