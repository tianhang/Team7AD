﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchaseitems.aspx.cs" Inherits="LogicUniv1._1.webpage.stockClerk.Purchaseitem" EnableEventValidation="false" %>

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
				  <li><a href="ClerkManageRequisition.aspx"><i class="fa fa-file-word-o fa-medium"></i>Manage Requisition</a></li>
				  <li><a href="ClerkInventory.aspx"  ><i class="fa fa-shopping-cart fa-medium"></i>Inventory</a></li>
                 <li><a href="Reorder.aspx" class="active"><i class="fa fa-file-word-o fa-medium"></i>Purchase Order</a></li>  
                <li><a href="ClerkRetrivalForm.aspx"><i class="fa fa-search-plus fa-medium"></i>Retrieve Form</a></li>
                  <li><a href="ViewCurrentPendingByItems.aspx"><i class="fa fa-search-plus fa-medium"></i>Pending Form</a></li>
                  <li><a href="CheckCurrentDisbursementList.aspx"><i class="fa fa-comments-o fa-medium"></i>Disbursement</a></li>
				  <li><a href="ClerkReportDiscrepancy.aspx"><i class="fa  fa-exclamation-triangle fa-medium"></i>Discrepancy</a></li>
				  <li><a href="ClerkMainSupplierPengxiaomeng.aspx"><i class="fa fa-reply-all fa-medium"></i>Manage Supplier</a></li>
                  <li><a href="x.html"><i class="fa fa-print  fa-medium"></i>Print Current Page</a></li>
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>                    
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">
			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>

    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Purchase Order Number:"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Date:"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="SupplierID:"></asp:Label>  
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>  
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="346px" Width="723px" OnRowCommand="GridView1_RowCommand" CssClass="table table-striped table-bordered table-condensed">
            <Columns>
                <asp:BoundField DataField="Itemcode" HeaderText="Itemcode" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="price" HeaderText="Price" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" />
                <asp:TemplateField HeaderText="Choose Supplier">
                    <ItemTemplate>
                        <asp:DropDownList ID="choosesupplier" runat="server" Height="23px" Width="121px">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="ChangeSupplier" HeaderText="ChangeSupplier" Text="ChangeSupplier" >
                <ControlStyle CssClass="btn btn-success" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="DeleteItem" Text="Delete Items" >
                <ControlStyle CssClass="btn btn-danger" />
                </asp:ButtonField>
            </Columns>
            <EmptyDataTemplate>
                NO&nbsp;&nbsp; ITEM&nbsp;&nbsp;&nbsp; FOUND!
            </EmptyDataTemplate>
        </asp:GridView>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Send" runat="server" style="margin-left: 509px" Text="Send Email to Supplier" Width="178px" CssClass="btn btn-info" />
            <asp:Button ID="Add" runat="server" Height="35px" style="margin-left: 15px" Text="Add Item" Width="135px" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap" CssClass="btn btn-info" />
        </p>
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" Width="96px" CssClass="btn btn-info" />  
           <asp:Button ID="Button1" runat="server" Text="Print" OnClientClick="PrintGridView()" Width="98px" CssClass="btn btn-info" />  

          <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="exampleModalLabel">Add Items</h4>
      </div>
      <div class="modal-body">
       <form>
          <div class="form-group">
            <label for="recipient-name" class="control-label">Item Description:</label>
              <asp:DropDownList ID="Itemchoose" runat="server" Height="17px" Width="126px" AppendDataBoundItems="True">
              </asp:DropDownList>
          </div>
          <div class="form-group">
             <label for="recipient-name" class="control-label">Item Number:</label><asp:TextBox ID="itemnumber" runat="server" Width="96px"></asp:TextBox>
       &nbsp;</div>
       </form>
      </div>
      <div class="modal-footer">
     <asp:Button ID="Close" class="btn btn-default" data-dismiss="modal" runat="server" Text="Close" />
     <asp:Button ID="Confirm" class="btn btn-primary" runat="server" Text="Confirm" CssClass="btn btn-primary" OnClick="Confirm_Click" />
      </div>   
  </div>      
</div>
         </div> 
            </div>    
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
<script id="print">  
      function PrintGridView() {  
      // 打开一个新网页  
          var newwindow = window.open('');  
      
         // 将指定DIV中的内容写入该网页  
       newwindow.document.write(document.getElementById('Print').innerHTML);  
       newwindow.document.close();    
          // 打印该网页  
       newwindow.focus();  
       newwindow.print();  
          // 打印完毕后关闭该窗口  
       newwindow.close();  
        return;  
     }  
 </script>  

</body>
    </html>