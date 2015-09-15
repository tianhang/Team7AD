<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryDisbursementList.aspx.cs" Inherits="LogicUniv1._1.webpage.stockClerk.HistoryDisbursementList" %>

<!DOCTYPE html>

<html>
<head>
     <title></title>
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
    <%-- --%>
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <%-- --%>
    <script src="../js/bootstrap.min.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>
    <script>
    $(function () {

  $("#<%=checkInDatePicker.ClientID %>").datepicker({
    dateFormat: 'mm/dd/yy',
    changeMonth: true,
    showOn: 'button',
    buttonImage: '../images/calendar_blk.png',
    buttonImageOnly: true,
    onSelect: function (selectedDate) {
    $("#<%=checkOutDatePicker.ClientID %>").datepicker("option", "minDate", selectedDate)

    }

    });    

    $("#<%=checkOutDatePicker.ClientID %>").datepicker({
    dateFormat: 'mm/dd/yy',
    changeMonth: true,
    showOn: 'button',
    buttonImage: '../images/calendar_blk.png',
    buttonImageOnly: true,
    onSelect: function (selectedDate) {
    $("#<%=checkOutDatePicker.ClientID %>").datepicker("option", "minDate", selectedDate)
    }
    });
    });
    </script>
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
            <li class="notification-dropdown hidden-xs hidden-sm">
                <a href="#" class="trigger">
                    <i class="icon-envelope"></i>
                </a>
                <div class="pop-dialog">
                    <div class="pointer right">
                        <div class="arrow"></div>
                        <div class="arrow_border"></div>
                    </div>
                    <div class="body">
                        <a href="#" class="close-icon"><i class="icon-remove-sign"></i></a>
                        <div class="messages">
                            <a href="#" class="item">
                                <img src="../img/contact-img.png" class="display" />
                                <div class="name">DEMO</div>
                                <div class="msg">
                                    回家来吃饭了.
                                </div>
                                <span class="time"><i class="icon-time"></i> 13分钟前.</span>
                            </a>
                            <a href="#" class="item">
                                <img src="../img/contact-img2.png" class="display" />
                                <div class="name">Galván</div>
                                <div class="msg">
                                    照片很不错哦.
                                </div>
                                <span class="time"><i class="icon-time"></i> 26分钟前.</span>
                            </a>
                            <a href="#" class="item last">
                                <img src="../img/contact-img.png" class="display" />
                                <div class="name">后台</div>
                                <div class="msg">
                                   模版很不错赶紧下载.
                                </div>
                                <span class="time"><i class="icon-time"></i> 48分钟前.</span>
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
				  <li><a href="ClerkManageRequisition.aspx" ><i class="fa fa-file-word-o fa-medium"></i>Manage Requisition</a></li>
				  <li><a href="ClerkInventory.aspx"><i class="fa fa-shopping-cart fa-medium"></i>Inventory</a></li>
                 <li><a href="Reorder.aspx"><i class="fa fa-file-word-o fa-medium"></i>Purchase Order</a></li>  
                <li><a href="ClerkRetrivalForm.aspx"><i class="fa fa-search-plus fa-medium"></i>Retrieve Form</a></li>
                  <li><a href="ViewCurrentPendingByItems.aspx"><i class="fa fa-search-plus fa-medium"></i>Pending Form</a></li>
                  <li><a href="CheckCurrentDisbursementList.aspx"  class="active"><i class="fa fa-comments-o fa-medium"></i>Disbursement</a></li>
				  <li><a href="ClerkReportDiscrepancy.aspx" ><i class="fa  fa-exclamation-triangle fa-medium"></i>Discrepancy</a></li>
				  <li><a href="ClerkMainSupplierPengxiaomeng.aspx"><i class="fa fa-reply-all fa-medium"></i>Manage Supplier</a></li>
                  <li><a href="x.html"><i class="fa fa-print  fa-medium"></i>Print Current Page</a></li>
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>
		<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
                  
			<div class="tm-right-inner-container"> 
                <div>
                    <asp:Button ID="btn_Current" CssClass="btn btn-default btn-sm" runat="server" Text="View List for Current Week" OnClick="btn_Current_Click" />
                    <asp:Button ID="btn_History"  CssClass="btn btn-default btn-sm" runat="server" Text="View History Log" Enabled="false"/>
                </div>   
                <br />

                <%-- timepicker --%>
                <table class="table-products">
                     <tr>
                        <td style="text-align: left">
                            <p>From(Collect Date)</p>
                            <asp:TextBox ID="checkInDatePicker" runat="server" ToolTip="Enter Check-in Date" Font-Size="Small"></asp:TextBox>
                        </td>
                        <td style="text-align: left">
                            <p >To(Collect Date)</p>
                            <asp:TextBox ID="checkOutDatePicker" runat="server" ToolTip="Enter Check-out Date" Font-Size="Small"></asp:TextBox>
                            <asp:Button ID="Button1"  CssClass="btn btn-info btn-sm" runat="server" Text="Specify" OnClick="Button1_Click" />
                        </td>
                        
                    </tr>
                    <tr>
                         <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </tr>
                </table>
                <%-- timepicker --%>        
                <div>
                    <asp:GridView  CssClass="table table-striped table-bordered table-condensed" ID="GridView1" width="900px" RowStyle-Height="35px"  HeaderStyle-Height="35px" Font-Size="Small" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:ButtonField HeaderText="View Detail" Text="View " />
                        </Columns>
                        <HeaderStyle />

                     <RowStyle Height="35px"></RowStyle>

                    </asp:GridView>

                </div>
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
