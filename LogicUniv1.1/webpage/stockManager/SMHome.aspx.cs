using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;
using ClassLibraryBL;
using ClassLibraryBL.Controller.stockManager;

namespace LogicUniv1._1.webpage.stockManager
{
    public partial class SMHome : System.Web.UI.Page
    {
        ApproveStockAdjustmentController Manager = new ApproveStockAdjustmentController();
        protected void Page_Load(object sender, EventArgs e)
        {
            user u = (user)Session["User"];
            if (u.roleId != 6)
            {
                Response.Redirect();
            }
                //User userbean = (User)Session["UserEntity"];
                //storeM.Text = "Hello," + userbean.Name;
                //var N = from a in ctx.discrepancies
                //        join b in ctx.users on a.userId equals b.userId
                //        where a.status == "Pending"
                //        select new
                //        {
                //            DiscrepancyId = a.discrepancyId,
                //            Clerk = b.name,
                //            Date = a.reportDate,
                //            Remark = a.Remark,
                //            TotalPrice = a.totalPrice,
                //            Status = a.status
                //        };

                GridView1.DataSource = Manager.checkdiscrepancy();
                GridView1.DataBind();                
            
        }
        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["id"] = GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("StockManagerDiscrepancyItemPengxiaomeng.aspx");
        }
    }
}