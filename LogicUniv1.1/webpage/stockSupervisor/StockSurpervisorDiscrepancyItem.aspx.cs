using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.stockSupervisor
{
    public partial class StockSurpervisorDiscrepancyItem : System.Web.UI.Page
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            var N = from a in ctx.discrepancy_item
                    join b in ctx.items on a.itemId equals b.itemId
                    join c in ctx.categories on b.categoryId equals c.categoryId
                    where a.discrepancyId == s
                    select new
                    {
                        Catogory = c.categoryName,
                        Item = b.description,
                        Quantity = a.reportQty,
                        Type = a.type
                    };
            GridView1.DataSource = N.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            discrepancy ac = (from a in ctx.discrepancies
                              where a.discrepancyId == s
                              select a).SingleOrDefault();
            ac.status = "Approved";
            ctx.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            discrepancy ac = (from a in ctx.discrepancies
                              where a.discrepancyId == s
                              select a).SingleOrDefault();
            ac.status = "Rejected";
            ctx.SaveChanges();
        }
    }
}