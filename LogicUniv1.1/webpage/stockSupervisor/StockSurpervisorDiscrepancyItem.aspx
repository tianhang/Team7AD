<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockSurpervisorDiscrepancyItem.aspx.cs" Inherits="LogicUniv1._1.webpage.stockSupervisor.StockSurpervisorDiscrepancyItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 603px; width: 1020px">
    
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" Height="468px" Width="879px" CaptionAlign="Bottom" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Font-Bold="False" Font-Italic="False" Font-Names="Cambria" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>   
    </div>
    <asp:Button ID="Button1" runat="server" Text="Approve" style="margin-left:5%" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Reject" style="margin-left:10px" OnClick="Button2_Click" />
    </form>
</body>
</html>