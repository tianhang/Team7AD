using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
using ClassLibraryBL;


namespace LogicUniv1._1.webpage.stockSupervisor
{
    public partial class SSHome : System.Web.UI.Page
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User userbean = (User)Session["UserEntity"];
          
            var N = from a in ctx.discrepancies
                    join b in ctx.users on a.userId equals b.userId
                    where a.status == "Pending"
                    select new
                    {
                        DiscrepancyId = a.discrepancyId,
                        Clerk = b.name,
                        Date = a.reportDate,
                        Remark = a.Remark,
                        TotalPrice = a.totalPrice,
                        Status = a.status
                    };

            GridView1.DataSource = N.ToList();
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
            Response.Redirect("StockSurpervisorDiscrepancyItem.aspx");
        }
    }
}