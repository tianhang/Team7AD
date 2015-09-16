<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeRep.aspx.cs" Inherits="LogicUniv1._1.webpage.DeptHead.ChangeRep" %>

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
         <%--  --%>
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <%--  --%>
    <!-- this page specific styles -->
    <link rel="stylesheet" href="../css/compiled/index.css" type="text/css" media="screen" />
    	<!-- scripts -->
    <script src="../js/bootstrap.min.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
          <script>
              $(function () {

                  $("#<%=checkInDatePicker.ClientID %>").datepicker({
                  dateFormat: 'dd/mm/yy',
                  changeMonth: true,
                  showOn: 'button',
                  buttonImage: '../images/calendar_blk.png',
                  buttonImageOnly: true,
                  onSelect: function (selectedDate) {
                      $("#<%=checkOutDatePicker.ClientID %>").datepicker("option", "minDate", selectedDate)

                }

              });

              $("#<%=checkOutDatePicker.ClientID %>").datepicker({
                  dateFormat: 'dd/mm/yy',
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
<a href="../LogoutPage.aspx" role="button">
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
				  <li><a href="HeadHome.aspx"><i class="fa fa-list-alt fa-medium"></i>Current Requisition</a></li>
				  <li><a href="PreviousRequisition.aspx"><i class="fa fa-book fa-medium"></i>Previous Requisition</a></li>
				  <li><a href="DelegateAuthority.aspx"><i class="fa fa-gavel fa-medium"></i>Delegate Authority</a></li>
				  <li><a href="ChangeRep.aspx" class="active"><i class="fa fa-user fa-medium"></i>Change Representitive</a></li>
				  <li><a href="ChangeCollectionPoint.aspx"><i class="fa fa-flag-checkered fa-medium"></i>Change Collection Point</a></li>
				  <li><a href="../deptEmp/EmpHome.aspx"  ><i class="fa fa-money fa-medium"></i>Go to Stationery Shop</a></li>
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            
           
			<div class="tm-right-inner-container" style="padding-left:220px">
                <div> 

                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <div class="auto-style1">
                                <asp:GridView ID="GridEmp" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-condensed" OnPageIndexChanging="GridEmp_PageIndexChanging" OnSelectedIndexChanged="GridEmp_SelectedIndexChanged" AllowPaging="True">
                                    <Columns>
                                        <asp:BoundField DataField="name" HeaderText="Employee Name" />
                                        <asp:BoundField DataField="userId" HeaderText="Employee Id" />
                                        <asp:CommandField HeaderText="Action" ShowSelectButton="True">
                                        <ControlStyle CssClass="btn btn-info" />
                                        </asp:CommandField>
                                    </Columns>
                                    <EditRowStyle Height="35px" />
                                    <HeaderStyle Height="35px" />
                                </asp:GridView>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <%--  --%>
                    <%--  --%>
                       <div class="auto-style2">
                                        <%-- bootstrap --%>
                                        <table class="table-products">
                                            <tr>
                                                <td class="auto-style2">
                                                        &nbsp;</td>
                                                </tr>
                                            </table>

                                       

                                                        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>

                                       

                                        <button class="btn btn-info" data-target="#myModal" data-toggle="modal" type="button">
                                            <div class="auto-style4">Delegate</div>
                                        </button>
                                        <!-- Modal -->
                                        <div id="myModal" aria-labelledby="myModalLabel" class="modal fade" role="dialog" tabindex="-1">
                                            <div class="modal-dialog" role="document">
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <button aria-label="Close" class="close" data-dismiss="modal" type="button">
                                                            <span aria-hidden="true">×</span>
                                                        </button>
                                                        <h4 id="myModalLabel" class="modal-title"><center>Are you sure to assign him as new Employee Representitive? </center>
                                                            <h4></h4>
                                                        </h4>
                                                    </div>
                                                    <div class="modal-body">
                                       <%-- bootstrap --%>                                                     
                                                        <%-- timepicker --%>
                                                         <table class="table-products">
                                                            <tr>
                                                                <td style="text-align: center">
 
                                                                    <p>StartDate</p>
                                                                    <asp:TextBox ID="checkInDatePicker" runat="server" ToolTip="Enter Check-in Date" Font-Size="Small"></asp:TextBox></td>
                                                                <td style="text-align: center">
                                                                    <p >EndDate</p>
                                                                    <asp:TextBox ID="checkOutDatePicker" runat="server" ToolTip="Enter Check-out Date"  Font-Size="Small"></asp:TextBox></td>
                                                            </tr>
                                                          </table>
                                                        <%-- timepicker --%>
                                                     <br />
                                                       <p style="text-align: center"> Please Select the startDate and endDate for the new representitive. </p>
                                                        
                                                        <br />
                                                        <p style="text-align: center">An  Email will be sent to your subordinates and StoreClerk as soon as you confirm.</p>
                                                    
                                                    </div>
                                                    <div class="modal-footer">
                                                        <button class="btn btn-default" data-dismiss="modal" type="button">
                                                            Close
                                                        </button>
                                                        
                                                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Confirm" OnClick="ConfirmBtn_Click"/>
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                    <!-- Button trigger modal -->





                    </div>

                    <%--  --%>
                    <%--  --%>
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
