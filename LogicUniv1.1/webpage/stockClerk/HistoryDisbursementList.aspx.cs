using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class HistoryDisbursementList : System.Web.UI.Page
    {
        ViewDisbursementListController vdlController = new ViewDisbursementListController();
        protected void Page_Load(object sender, EventArgs e)
        {
            Object o = vdlController.getAllHistoryList();
            GridView1.DataSource = o;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String checkIn = checkInDatePicker.Text;
            String checkOut = checkOutDatePicker.Text;
            Label1.Text = "";
            try
            {
                DateTime begin = Convert.ToDateTime(checkIn);
                DateTime end = Convert.ToDateTime(checkOut);
                Object o=vdlController.getSelectedHistoryList(begin, end);
                GridView1.DataSource = o;
                GridView1.DataBind();

            }
            catch
            {
                Label1.Text = "Please Use the Correct Format !";
            }


          

        }

        protected void btn_Current_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckCurrentDisbursementList.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String s = GridView1.Rows[Convert.ToInt16(e.CommandArgument)].Cells[1].Text;
            Session["passing"] = s;
            // the show entire items for respective row 
            Response.Redirect("HistoryDisbursementListDetails.aspx");
        }
    }
}