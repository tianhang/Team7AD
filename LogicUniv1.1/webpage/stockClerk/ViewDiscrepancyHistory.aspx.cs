using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewDisbursementHistory : System.Web.UI.Page
    {
        ProcessDiscrepancyController pdController = new ProcessDiscrepancyController();
        protected void Page_Load(object sender, EventArgs e)
        {
            Object o=pdController.ListHistory();
            GridView1.DataSource = o;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            String checkIn = checkInDatePicker.Text;
            String checkOut = checkOutDatePicker.Text;
            Boolean c = pdController.validateBlank(checkIn, checkOut);
           
            if (c == true) 
            {
                    Label1.Text = "";
                    DateTime begin = Convert.ToDateTime(checkIn);
                    DateTime end = Convert.ToDateTime(checkOut);

                    Object o = pdController.ListSelectedHistory(begin,end);
                    GridView1.DataSource = o;
                    GridView1.DataBind();
            }
            else
            {
                Label1.Text = "Please enter correct history format";
            }


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String s = GridView1.Rows[Convert.ToInt16(e.CommandArgument)].Cells[1].Text;
            Session["transferId"] = s;
            Response.Redirect("ViewDiscrepancyHistoryDetails.aspx"); 
        }

        protected void btn_Current_Click(object sender, EventArgs e)
        {
            btn_Current.Enabled = false;
            Response.Redirect("ClerkReportDiscrepancy.aspx");
        }

    }
}