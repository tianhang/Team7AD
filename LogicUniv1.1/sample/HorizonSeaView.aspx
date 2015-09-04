<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HorizonSeaView.aspx.cs" Inherits="ThreeHotel.Pages.HorizonSeaView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script>
        $(function () {

            $("#<%=checkInDatePicker.ClientID %>").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                minDate: new Date(),
                maxDate: '+3m',
                showOn: 'button',
                buttonImage: '../Images (ThreeHotel)/Date.png',
                buttonImageOnly: true,
                

            });

            $("#<%=checkOutDatePicker.ClientID %>").datepicker({
                minDate: new Date(),
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                showOn: 'button',
                buttonImage: '../Images (ThreeHotel)/Date.png',
                buttonImageOnly: true,
            });
        });
    </script>
    <style>
        .ui-datepicker-trigger {
            position: relative;
            top: 4px;
            left: 5px;
            height: 19px;
        }

        .ui-datepicker {
            font-size: 70%;
        }
        .auto-style18 {
            font-weight: normal;
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager> 
    <table class="auto-style3">
        <tr>
            <td colspan="3">
                <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.7em" PathSeparator=" : ">
                    <CurrentNodeStyle ForeColor="#BB9754" />
                    <NodeStyle Font-Bold="True" ForeColor="black" />
                    <PathSeparatorStyle Font-Bold="True" ForeColor="black" />
                    <RootNodeStyle Font-Bold="True" ForeColor="black" />
                </asp:SiteMapPath>
            </td>
        </tr>
        <tr>
            <td colspan="3"><span style="color: rgb(134, 109, 45)"><h1 class="auto-style18">
                <asp:Label ID="Label1" runat="server" Text="HORIZON SEA VIEW ROOM" ForeColor="#BB9754"></asp:Label>
                </h1></span></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Image ID="Image10" runat="server" ImageUrl="~/Images (ThreeHotel)/BoldLine1.PNG" Width="746px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Image ID="Image1" runat="server" ImageUrl="../Images (ThreeHotel)/SBHI-Superior-City-View-Room.jpg" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <h2 style="font-family: SortsMillGoudyRegular; color: rgb(52, 52, 52); font-size: 28px; font-weight: normal; line-height: 33px; margin: 0px; padding: 0px; letter-spacing: 1px; clear: both; font-style: normal; font-variant: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgba(255, 255, 255, 0.952941);">
                    Spacious comfort with resplendent views</h2>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Image ID="Image12" runat="server" ImageUrl="~/Images (ThreeHotel)/BoldLine2.PNG" Width="736px" />
            </td>
        </tr>
         <tr>
             <td>
                 <table class="auto-style3">
                     <tr>
                         <td>

                             <table class="auto-style3">
                                 <tr>
                                     <td colspan="2">
                                         <asp:Label ID="Label6" runat="server" Text="Be pampered by the extra space and exquisite comfort of our Horizon Sea View Rooms." Width="466px" style="text-align: justify"></asp:Label>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2">
                                         <asp:Label ID="Label3" runat="server" style="font-size: x-large" ForeColor="#BB9754" Text="Features"></asp:Label>
                                         <p>
                                             <asp:Image ID="Image2" runat="server" ImageUrl="~/Images (ThreeHotel)/view.png" Width="20px" />
                                             &nbsp;Magnificent views of the West Coast</p>
                                         <p>
                                             <asp:Image ID="Image3" runat="server" ImageUrl="~/Images (ThreeHotel)/bed.png" Width="20px" />
                                             &nbsp;An indulgent bed with quality cotton linens</p>
                                         <p>
                                             <asp:Image ID="Image4" runat="server" ImageUrl="~/Images (ThreeHotel)/bath.png" Width="20px" />
                                             &nbsp;Spacious bathroom</p>
                                         <p>
                                             <asp:Image ID="Image5" runat="server" ImageUrl="~/Images (ThreeHotel)/size.png" Width="20px" />
                                             &nbsp;Each room offers 36 sqm / 388 sqf of luxury.</p>
                                         <br />

                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2"><asp:Label ID="Label7" runat="server" style="font-size: x-large" ForeColor="#BB9754" Text="Amenities"></asp:Label></td>
                                 </tr>
                                 <tr>
                                     <td style="vertical-align:top">
                                        <p>
                                            <asp:Image ID="Image6" runat="server" ImageAlign="Top" ImageUrl="~/Images (ThreeHotel)/media.png" Width="20px" />
                                            &nbsp;
                                            <strong>Media & Entertainment</strong></p>
                                        <ul>
                                            <li>Complimentary Wi-Fi Access</li>
                                            <li>Satellite / cable television</li>
                                        </ul>
                                     </td>
                                     <td style="vertical-align:top">
                                         <p>
                                             <asp:Image ID="Image7" runat="server" ImageAlign="Middle" ImageUrl="~/Images (ThreeHotel)/office.png" Width="20px" />
                                             &nbsp;
                                             <strong>Office Equipment & Stationery</strong></p>
                                         <ul>
                                            <li>Full-size executive writing desk</li>
                                            <li>International Direct Dial telephone</li>
                                            <li>Voice mail</li>
                                            <li>Smoke masks</li>
                                            <li>Emergency flashlight</li>
                                        </ul>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td style="vertical-align:top">
                                         <p>
                                             <asp:Image ID="Image8" runat="server" ImageAlign="Top" ImageUrl="~/Images (ThreeHotel)/toiletries.png" Width="20px" />
                                             &nbsp;
                                             <strong>Bath & Personal Care</strong></p>
                                         <ul>
                                            <li>Exclusive Shangri-La toiletries</li>
                                            <li>Hair dryer</li>
                                        </ul>
                                     </td>
                                     <td style="vertical-align:top">
                                         <p>
                                             <asp:Image ID="Image9" runat="server" ImageAlign="Top" ImageUrl="~/Images (ThreeHotel)/refreshment.png" Width="20px" />
                                             &nbsp;
                                             <strong>Refreshments</strong></p>
                                         <ul>
                                            <li>Coffee / tea-making facilities</li>
                                            <li>Mini bar</li>
                                        </ul>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2">
                                         <asp:Label ID="Label2" runat="server" style="font-size: x-large" ForeColor="#BB9754" Text="Children's Meal Plan for registered hotel guests"></asp:Label>
                                         <p style="text-align: justify">Children of registered hotel guests under the age of 6 can enjoy complimentary buffet meals in All Day Dining and Pool Cafes when accompanied by a paying adult, up to a maximum of 2 children. In excess of 2 children under the age of 6 and for all children above 6 and below 12, a 50% discount of the buffet price will be given.</p>
                                         <br /><br /><br />
                                     </td>
                                 </tr>
                             </table>

                         </td>
                         <td>
                             &nbsp;
                             &nbsp;
                         </td>
                            
                         <td style="vertical-align:top">
                             <asp:Label ID="lblGuestInfo" runat="server" Font-Size="Large" ForeColor="#BB9754" Text="Room Reservations"></asp:Label>
                                <p>Check-in</p>
                                <p><asp:TextBox ID="checkInDatePicker" runat="server" ToolTip="Enter Check-in Date" Width="120px" Font-Size="Small"></asp:TextBox></p>
                                <p>Check-out</p>
                                <p><asp:TextBox ID="checkOutDatePicker" runat="server" ToolTip="Enter Check-out Date" Width="120px" Font-Size="Small"></asp:TextBox></p>
                             <hr class="hr1" />
                             <br />   
                             <asp:UpdatePanel ID="UpdatePanel2" runat="server" RenderMode="Inline">
                                    <ContentTemplate>
                                        <table class="auto-style3">
                                            <tr>
                                                <td>
                                                    <span>No. of rooms</span>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownListRoomCount" runat="server" OnSelectedIndexChanged="DropDownListRoomCount_SelectedIndexChanged" AutoPostBack="True" Width="80px" Font-Size="Small">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <span>Adults</span>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownListAdult" runat="server" OnSelectedIndexChanged="DropDownListAdult_SelectedIndexChanged" AutoPostBack="True" Width="80px" Font-Size="Small">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <span>Children</span>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownListChildren" runat="server" Width="80px" Font-Size="Small">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <br />
                                                    <hr class="hr1" />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <span>Special Rate (optional)</span>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtSpecialRate" runat="server" ToolTip="Enter Code"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                             <br />
                             <asp:Button ID="btnCheckAvailability" runat="server" Text="CHECK AVAILABILITY" Font-Names="Verdana" ForeColor="White" BackColor="#BB9754" BorderColor="#BB9754" Font-Size="Small" OnClick="btnCheckAvailability_Click"/>
                                <hr class="hr1" />
                         </td>
                     </tr>
                 </table>
             </td>
         </tr>
        <tr>
            <td colspan="2">
                <br />
                <asp:Image ID="Image11" runat="server" ImageUrl="~/Images (ThreeHotel)/BoldLine1.PNG" Width="746px" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
