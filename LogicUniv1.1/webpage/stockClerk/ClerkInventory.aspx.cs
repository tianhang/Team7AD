using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibraryBL;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkHome : System.Web.UI.Page
    {
      
        ViewInventoryController viewInventoryController = new ViewInventoryController();
        protected void Page_Load(object sender, EventArgs e)
        {                        
            Object o= viewInventoryController.getInventoryData();
            GridView1.DataSource = o;
            GridView1.DataBind();
        }

        protected void btn_checkLowInventory_Click(object sender, EventArgs e)
        {
            btn_checkLowInventory.Enabled = false;
            btn_reportDiscrepancy.Visible = false;
            btn_reorder.Visible = true;
            Object o = viewInventoryController.getLowBalanceData();
            GridView1.DataSource = o;
            GridView1.DataBind();
        }


        protected void btn_reportDiscrepancy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClerkReportDiscrepancy.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void btn_reorder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reorder.aspx");
        }

       

    }
}