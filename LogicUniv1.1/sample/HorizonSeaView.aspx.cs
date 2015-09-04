using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeHotel.Pages
{
    public partial class HorizonSeaView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] RoomOptions = new[] { "1", "2", "3" };
                foreach (string option in RoomOptions)
                {
                    DropDownListRoomCount.Items.Add(new ListItem(option, option));
                }

                String[] adultOptions = new[] { "1", "2", "3" };
                foreach (string option in adultOptions)
                {
                    DropDownListAdult.Items.Add(new ListItem(option, option));
                }

                String[] childrenOptions = new[] { "0", "1", "2" };
                foreach (string option in childrenOptions)
                {
                    DropDownListChildren.Items.Add(new ListItem(option, option));
                }
            }
        }

        protected void DropDownListRoomCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListAdult.Items.Clear();
            DropDownListChildren.Items.Clear();

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 1)
            {
                String[] adultOptions = new[] { "1", "2", "3" };
                foreach (string option in adultOptions)
                {
                    DropDownListAdult.Items.Add(new ListItem(option, option));
                }
                String[] childrenOptions = new[] { "0", "1", "2" };
                foreach (string option in childrenOptions)
                {
                    DropDownListChildren.Items.Add(new ListItem(option, option));
                }

            }

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 2)
            {
                String[] adultOptions = new[] { "1", "2", "3", "4", "5", "6" };
                foreach (string option in adultOptions)
                {
                    DropDownListAdult.Items.Add(new ListItem(option, option));
                }
                String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5" };
                foreach (string option in childrenOptions)
                {
                    DropDownListChildren.Items.Add(new ListItem(option, option));
                }
            }

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 3)
            {
                String[] adultOptions = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                foreach (string option in adultOptions)
                {
                    DropDownListAdult.Items.Add(new ListItem(option, option));
                }
                String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
                foreach (string option in childrenOptions)
                {
                    DropDownListChildren.Items.Add(new ListItem(option, option));
                }
            }



        }

        protected void DropDownListAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListChildren.Items.Clear();

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 1)
            {
                if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 1)
                {
                    String[] childrenOptions = new[] { "0", "1", "2" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 2)
                {
                    String[] childrenOptions = new[] { "0", "1" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else
                {
                    DropDownListChildren.Items.Add(new ListItem("0", "0"));
                }
            }

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 2)
            {
                if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 1)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 2)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 3)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 4)
                {
                    String[] childrenOptions = new[] { "0", "1", "2" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 5)
                {
                    String[] childrenOptions = new[] { "0", "1" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else
                {
                    DropDownListChildren.Items.Add(new ListItem("0", "0"));
                }
            }

            if (Convert.ToInt16(DropDownListRoomCount.SelectedItem.Text) == 3)
            {
                if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 1)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 2)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5", "6", "7" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 3)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5", "6" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 4)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4", "5" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 5)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3", "4" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 6)
                {
                    String[] childrenOptions = new[] { "0", "1", "2", "3" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 7)
                {
                    String[] childrenOptions = new[] { "0", "1", "2" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else if (Convert.ToInt16(DropDownListAdult.SelectedItem.Text) == 8)
                {
                    String[] childrenOptions = new[] { "0", "1" };
                    foreach (string option in childrenOptions)
                    {
                        DropDownListChildren.Items.Add(new ListItem(option, option));
                    }
                }
                else
                {
                    DropDownListChildren.Items.Add(new ListItem("0", "0"));
                }
            }

        }

        protected void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            String checkIn = (checkInDatePicker.Text).Substring(6, 4) + "-" + (checkInDatePicker.Text).Substring(3, 2) + "-" + (checkInDatePicker.Text).Substring(0, 2);
            String checkOut = (checkOutDatePicker.Text).Substring(6, 4) + "-" + (checkOutDatePicker.Text).Substring(3, 2) + "-" + (checkOutDatePicker.Text).Substring(0, 2);

            Session["CheckInDB"] = checkIn;
            Session["CheckOutDB"] = checkOut;
            Session["CheckIn"] = checkInDatePicker.Text;
            Session["CheckOut"] = checkOutDatePicker.Text;
            Session["RoomCount"] = DropDownListRoomCount.SelectedItem.Text;
            Session["AdultCount"] = DropDownListAdult.SelectedItem.Text;
            Session["ChildrenCount"] = DropDownListChildren.SelectedItem.Text;
            Session["SpecialRateCode"] = txtSpecialRate.Text;

            Response.Redirect("RoomReservations-list.aspx");
        }
    }
}