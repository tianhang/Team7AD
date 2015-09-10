using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class CheckCurrentDisbursementList : System.Web.UI.Page
    {
        ViewDisbursementListController vs = new ViewDisbursementListController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //deptValue is the name of the dept
        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            String sValue = DropDownList1.SelectedValue;
            Session["deptValue"] = sValue;
            Object o = vs.getCurrentList(sValue);

            GridView1.DataSource = o;
            GridView1.DataBind();
        }
        
        //get the value of specified row and column.
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String s = GridView1.Rows[Convert.ToInt16(e.CommandArgument)].Cells[1].Text;
            Session["passing"] = s;
            // the show entire items for respective row 
            Response.Redirect("CurrentDisbursementDetailItem.aspx");

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void btn_History_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryDisbursementList.aspx");
        }

    }
}