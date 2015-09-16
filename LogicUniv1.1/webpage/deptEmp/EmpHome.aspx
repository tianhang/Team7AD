<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpHome.aspx.cs" Inherits="LogicUniv1._1.webpage.deptEmp.EmpHome" %>

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
    <script src="js/handlebars-v3.0.3.js" type="text/javascript"></script>
    <!-- knob -->
    <script src="../js/jquery.knob.js"></script>
    <!-- flot charts -->
    <script src="../js/jquery.flot.js"></script>
    <script src="../js/jquery.flot.stack.js"></script>
    <script src="../js/jquery.flot.resize.js"></script>
    <script src="../js/theme.js"></script>


    
 
    <style type="text/css">
        #resultdemo {
            height: 24px;
        }
        #aaa {
            float:left;
            width:220px;
            height:290px;
            /*width:10%;*/
            margin:15px;
            
        }
        #aaa {
            border: 1px solid gray;
            border-radius: 15px ;
            text-align:center;
        }
        
        

    </style>


    <script id="resultTemplate" type="text/x-handlebars">
        <div id="aaa">
            <asp:Image class="resultdemo" runat="server" src="{{ m0 }}" width="180" height="180"/>
            <br><br>
            <div style="height:50px" >
            <asp:Label runat="server" Text="Name:"></asp:Label>
            <asp:Label runat="server" Text="{{ m2 }}"></asp:Label><br>
            <asp:Label runat="server" Text="Left:"></asp:Label>
            <asp:Label runat="server" Text="{{ m1 }}"></asp:Label>
            <br> 
            </div>
            <div id="bbb">
            <input type="checkbox" name="choice" value="{{ m3 }}" >
            <input type="text" id="{{ m3 }}" name="amount" style="width:130px">
            </div>
        </div>
    </script>

     <script>
         var length;
           $(function () {
               var goodtemplate = Handlebars.compile($("#resultTemplate").html());
               //var itemList = '<%= Session["itemList"] %>';
               var itemList = <%= new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(Session["itemList"])%>
               //alert(itemList.length);
               console.log(itemList[0].description.trim());
               length= itemList.length;
               for (var i = 0; i < itemList.length; i++) {
                   var data = {
                       m0: "../images/" + itemList[i].description.trim() + ".jpg",
                       m1: itemList[i].balance,
                       m2: itemList[i].description,
                       m3: itemList[i].itemId

                   };
                   $("#resultdemo").append(goodtemplate(data));

               }

               var a="/";
               var b="/";
               var c="";
               $("#<%=Button2.ClientID%>").on("click",function(){
                $("input:checkbox[name=choice]:checked").each(function(){
                    console.log($(this).val());
                    a=a+$(this).val()+"/";
                    c=$(this).val().toString();
                    console.log($("#"+c).val());
                    b=b+$("#"+c).val()+"/";
                });
                console.log(a);
                console.log(b);
                <%--$("#<%=TextBox1.ClientID %>").val(a);--%>
                $("#<%=HiddenField1.ClientID %>").val(a);
                $("#<%=HiddenField2.ClientID %>").val(b);
            });
           }); 
      </script>
</head>
<body>
    <header class="navbar navbar-inverse" role="banner" id="headlayer">
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
		<div class="col-lg-3 col-md-3 col-sm-3  black-bg left-container" style="background-color:#28303a" id="leftlayer">
			<h1 class="logo-left hidden-xs margin-bottom-60" style="color:white">Logic</h1>			
			<div class="tm-left-inner-container">
				<ul class="nav nav-stacked templatemo-nav">
				  <li><a href="EmpHome.aspx" class="active"><i class="fa fa-home fa-medium"></i>Homepage</a></li>
				  <li><a href="PreviousRequisition.aspx"><i class="fa fa-shopping-cart fa-medium"></i>Previous Requisition</a></li>
				  <li><a href="CurrentRequisition.aspx"><i class="fa fa-send-o fa-medium"></i>Current Requisition</a></li>
				 
				</ul>
			</div>

		</div> <!-- left section -->
        <div class="copyrights">Collect from <a href="http://www.mycodes.net/" ></a></div>
		<div class="col-lg-9 col-md-9 col-sm-9  white-bg right-container" id="rightlayer">

			<h1 class="logo-right hidden-xs margin-bottom-60">University</h1>
            
			<div id="prelayer" style="padding-left:60px">
                <div> 
                    <div>
                        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="119px"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" CssClass="btn btn-info" />
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="136px">
                            <asp:ListItem>catogoryName</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search By Category" CssClass="btn btn-info" Height="32px" Width="181px" />
                 
                        <asp:Button ID="Button2" runat="server" Text="Add To Cart" OnClick="Button2_Click" CssClass="btn btn-danger" />
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                        <asp:HiddenField ID="HiddenField2" runat="server" />
                    </div>
                </div>

                                    <div id="resultdemo">
  
                                          </div>
            </div>


            </div>





        </div>


    <script>
        $(function () {

            var x =(length/3);
            var height = (x*290) + 1200;
            console.log(height);
            console.log(length);
            var x1 = window.outerHeight;

            console.log(x1);
            
            document.getElementById("leftlayer").setAttribute("style", "height:" + height + "px");

            //document.getElementById("leftlayer").setAttribute("style", "width:" + leftwidth + "px");

            document.getElementById("rightlayer").setAttribute("style", "height:" + height + "px");
            
            //document.getElementById("rightlayer").setAttribute("style", "width:" + rightwidth + "px");


        });
    </script>
		<!-- right section -->
        </form>
    </body>  
</html>
