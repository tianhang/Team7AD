<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequisitionDetails.aspx.cs" Inherits="LogicUniv1._1.webpage.DeptHead.RequisitionDetails" %>

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
    <link rel="stylesheet" type="text/css" href="../css/reqdetail.css">
    <!-- this page specific styles -->
    <link rel="stylesheet" href="../css/compiled/index.css" type="text/css" media="screen" />
    	<!-- scripts -->
    <script src="../js/jquery-1.11.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery-ui-1.10.2.custom.min.js"></script>
    <script src="../js/handlebars-v4.0.2.js"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>


    <script>
        $(function () {
            var reqTemplate = Handlebars.compile($("#goodsTemplate").html());
            var reqsessonlist = <%= new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(Session["reqdetails"])%>
            console.log(reqsessonlist[0].Description.trim());

            for (var i = 0; i < reqsessonlist.length; i++) {
                if (i < 6) {
                    var desc = reqsessonlist[i].Description.trim();
                    var num = reqsessonlist[i].Number;
                    var unit = reqsessonlist[i].Unit.trim();
                    var data = {
                        m0: "../images/" + desc + ".jpg",
                        m1: desc,
                        m2: num,
                        m3: unit
                    }
                    $("#itembox").append(reqTemplate(data));
                }
                else if (i < 12 && i > 6) {
                    var desc = reqsessonlist[i].Description.trim();
                    var num = reqsessonlist[i].Number;
                    var unit = reqsessonlist[i].Unit.trim();
                    var data = {
                        m0: "../images/" + desc + ".jpg",
                        m1: desc,
                        m2: num,
                        m3: unit
                    }
                    $("#itembox2").append(reqTemplate(data));
                }
                else if (i < 18 && i > 12) {
                    var desc = reqsessonlist[i].Description.trim();
                    var num = reqsessonlist[i].Number;
                    var unit = reqsessonlist[i].Unit.trim();
                    var data = {
                        m0: "../images/" + desc + ".jpg",
                        m1: desc,
                        m2: num,
                        m3: unit
                    }
                    $("#itembox3").append(reqTemplate(data));
                }

            }


            });
    </script>

    
     <script id= "goodsTemplate" type="text/x-handlebars" >

                   <div style="width:151px" id="reqdisplay">
                        <strong>
                            <img src="{{ m0 }}" />
                        </strong>
                       <p>
                           Description: {{ m1 }} 
                       </p>
                        <p>
                            Number: {{ m2 }}
                       </p>
                        <p>
                            Unit: {{ m3 }}
                        </p>
                   
                    
                    </div>
      </script>



    <style type="text/css">
        .auto-style1 {
            max-width: 710px;
            text-align: center;
                      
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            width: 100%;
            height: 51px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            height: 17px;
            text-align: left;
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
				  <li><a href="HeadHome.aspx" class="active"><i class="fa fa-list-alt fa-medium"></i>Current Requisition</a></li>
				  <li><a href="PreviousRequisition.aspx"><i class="fa fa-book fa-medium"></i>Previous Requisition</a></li>
				  <li><a href="DelegateAuthority.aspx"><i class="fa fa-gavel fa-medium"></i>Delegate Authority</a></li>
				  <li><a href="ChangeRep.aspx"><i class="fa fa-user fa-medium"></i>Change Representitive</a></li>
				  <li><a href="ChangeCollectionPoint.aspx"  ><i class="fa fa-flag-checkered fa-medium"></i>Change Collection Point</a></li>
				  
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>
<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            
          
			<div class="auto-style1" id="prelayer" style="padding-left:60px">

                <div>
                    <table class="auto-style3">
                        <tr>
                            <td class="auto-style4">
                                <div class="auto-style5">
            <asp:Label ID="reqid" runat="server" Text="reqid" BorderColor="Black" BorderStyle="Double" Font-Bold="True" ForeColor="Black"></asp:Label>
                                </div>
                                <table class="table-products">
                                    <tr>
                                        <td class="auto-style5">
            <asp:Label ID="status" runat="server" Text="status" BorderColor="Black" BorderStyle="Double" Font-Bold="True" ForeColor="Black"></asp:Label>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">

            <asp:Label ID="colpoint" runat="server" Text="colpoint" BorderColor="Black" BorderStyle="Double" Font-Bold="True" ForeColor="Black"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style6">
            <asp:Label ID="reqby" runat="server" Text="reqby" BorderColor="Black" BorderStyle="Double" Font-Bold="True" ForeColor="Black"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>


                <div id="itembox" class="reqbox" style="display: -webkit-box;">

                </div>
                 <div id="itembox2" class="reqbox" style="display: -webkit-box;">

                </div>
                <div id="itembox3" class="reqbox" style="display: -webkit-box;">

                </div>
                <div class="auto-style2" style="padding-left:800px">
                    <asp:Label ID="Labelflag" runat="server" ForeColor="Red"></asp:Label>
               <asp:Button ID="ApproveBtn" runat="server" CssClass="btn btn-success" position="relative" Text="Approve" top="10px" Width="100px" OnClick="ApproveBtn_Click" />
              <br />
                <br />
               <asp:Button ID="RejectBtn" runat="server" CssClass="btn btn-danger" Text="Reject" Width="100px" data-toggle="modal" data-target="#myModal" />
                </div>
             </div>


            <%-- BOOTSTRAT POPUP WINDOW --%>
<!-- Button trigger modal -->
<!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Please Tell The Reason to Reaject</h4>
      </div>
      <div class="modal-body">
        
          <asp:TextBox ID="RejReason" runat="server" Height="70px" Width="500px"></asp:TextBox>

      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        <asp:Button ID="RejButton" runat="server" CssClass="btn btn-danger" position="relative" Text="Reject" top="10px" Width="100px" OnClick="RejBtn_Click" />
      </div>
    </div>
  </div>
</div>
             <%-- BOOTSTRAT POPUP WINDOW --%>





				<footer>
					<p class="col-lg-3 col-md-3  ">Copyright &copy; 2015 Logic University designed by NUS ISS SA 40 Team 7 </p>
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
   <script>
       $(function () {
           console.log(window.innerHeight);
           var height = (window.innerHeight);
           console.log(height);
           document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");
           document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
       });
</script>

    </form>
 </body>
    </html>
