<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogoutPage.aspx.cs" Inherits="LogicUniv1._1.webpage.LogoutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Successfully Logout your account.</h3>
        <h3><span id='spanid'>3</span>s, redirecting to Login page...</h3>
    </div>
    </form>
             <script>
                 spanobj = document.getElementById('spanid');
                 i = 3;
                 setInterval(function () {
                     num = --i;
                     if (num <= 0) {
                         clearInterval();
                         location = 'Login/login.aspx';
                     }
                     spanobj.innerHTML = num;
                 }, 1000);
     </script>
</body>
</html>
