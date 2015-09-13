<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClerkReportDiscrepancy.aspx.cs" Inherits="LogicUniv1._1.webpage.stockClerk.ClerkReportDiscrepancy" %>

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

    <!--Replenish-->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js" ></script>
    <script src="Scripts/bootstrap.min.js"></script>
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
                  <li><a href="CheckCurrentDisbursementList.aspx"><i class="fa fa-comments-o fa-medium"></i>Disbursement</a></li>
				  <li><a href="ClerkReportDiscrepancy.aspx"  class="active"><i class="fa  fa-exclamation-triangle fa-medium"></i>Discrepancy</a></li>
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
                    <asp:Button ID="btn_Current" CssClass="btn btn-default btn-sm" runat="server" Text="Report Discrepancy"  Enabled="false"/>
                    <asp:Button ID="btn_History"  CssClass="btn btn-default btn-sm" runat="server" Text="View Discrepancy History" OnClick="btn_History_Click" />
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                <div style="text-align: center">
        <asp:GridView ID="Gv1" runat="server" AutoGenerateColumns="False"  width="900px" RowStyle-Height="35px"  HeaderStyle-Height="35px" Font-Size="Small" OnRowDeleting="Gv1_RowDeleting"
           CssClass="table table-bordered" onrowcommand="Gv1_RowCommand" AllowPaging="True" OnPageIndexChanging="Gv1_PageIndexChanging">
            <HeaderStyle />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
          
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%# Container.DataItemIndex+1 %>
                        <asp:Label ID="Lb_Index" runat="server" Text='<%# Container.DataItemIndex+1 %>' Visible="false"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Category">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_Cposition" runat="server" Text='<%#Eval("Cposition")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_UserName" runat="server" Text='<%#Eval("UserName")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_Jan" runat="server" Text='<%#Eval("JanCount")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Unit">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_Unit" runat="server" Text='<%#Eval("Count")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Type">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_Feb" runat="server" Text='<%#Eval("FebCount")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remark">
                    <ItemTemplate>
                        <asp:TextBox ID="Txt_remark" runat="server" Text='<%#Eval("remark")%>' CssClass="form-control"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="Lkb_delete" runat="server" CommandName="delete" Text="delete" CommandArgument='<%# Container.DataItemIndex+1 %>' CssClass="btn btn-sm btn-danger"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
                <div>  
                <p>
                    &nbsp;</p>
                <p>
                    Category：
                    <asp:DropDownList ID="dropdownlist_category" CssClass="btn btn-default btn-sm dropdown-toggle" runat="server" OnSelectedIndexChanged="dropdownlist_category_SelectedIndexChanged" AutoPostBack="True" Width="25%"></asp:DropDownList>
                </p>
                <p>
                    &nbsp;ItemName:
                    <asp:DropDownList ID="dropdownlist_item" CssClass="btn btn-default btn-sm dropdown-toggle" runat="server" Width="25%"></asp:DropDownList>
                </p>
                <p>
                    Amount：<asp:TextBox ID="txt_Jn" runat="server" CssClass="TextBox" Width="25%"></asp:TextBox></p>
                <p>
                    Unit：<asp:Label ID="lbl_unit" runat="server" Text="(The unit of measure)" Width="25%"></asp:Label></p>
                <p>
                    Reason：
                    <asp:DropDownList ID="droplist_reason" CssClass="btn btn-default btn-sm dropdown-toggle" runat="server" Width="25%">
                        <asp:ListItem>Damage</asp:ListItem>
                        <asp:ListItem>Lost</asp:ListItem>
                        <asp:ListItem>Misallocated</asp:ListItem>
                    </asp:DropDownList>
                </p>
                  <p>
                    Remark：<asp:TextBox ID="textbox_remark" runat="server" CssClass="TextBox" Width="25%"></asp:TextBox></p>
                <p>
                    <%--<asp:Button ID="Btn_edit" runat="server" Text="Edit" OnClick="Btn_edit_Click" CssClass="btn btn-info btn-sm" />--%>
                    <asp:Button ID="Btn_Add" runat="server" OnClick="Btn_Add_Click" Text="Add to row" CssClass="btn btn-info btn-sm"/>                    
                </p>
                </div>
        <div>
             <!-- Trigger the modal with a button -->
                    


        </div>
    </div>
                   </ContentTemplate>
</asp:UpdatePanel>

                <button id="Btn_submit" style="position:relative;left:90%"  class="btn btn-info btn-sm " data-whatever="@getbootstrap" data-toggle="modal" data-target="#exampleModal" >Submit</button>
                <div style="position:relative;left:90%">
                <asp:Label ID="lbl_fail" runat="server" ForeColor="Red" Font-Size="Medium" Text=""></asp:Label>
                </div>
                <!-- Modal -->
  <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
    <div class="modal-dialog" role="document">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Confirmation</h4>
        </div>
        <div class="modal-body">
            <p>Do you want to confirm</p>
                <div class="modal-footer">
                    <asp:Button ID="Btn_confirm"  runat="server" CssClass="btn btn-default" Text="Confirm"  OnClick="Confirm_Click"/>    
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
        </div>
     </div>
   </div>
  <!-- Modal End-->
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
