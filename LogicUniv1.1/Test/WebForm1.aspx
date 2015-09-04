<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LogicUniv1._1.Test.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script>
        $(function () {

            $("#<%=startdate.ClientID %>").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                minDate: new Date(),
                maxDate: '+3m',
                showOn: 'button',
                buttonImage: '../Images (ThreeHotel)/Date.png',
                buttonImageOnly: true,


            });

            $("#<%=enddate.ClientID %>").datepicker({
                minDate: new Date(),
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                showOn: 'button',
                buttonImage: '../Images (ThreeHotel)/Date.png',
                buttonImageOnly: true,
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="startdate" runat="server" ></asp:TextBox>
    <asp:TextBox ID="enddate" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
