using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkHistoryLogPengxiaomeng : System.Web.UI.Page
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities(); 
        protected void Page_Load(object sender, EventArgs e)
        {           

            var n = from a in ctx.requisitions
                    join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
                    group b.requisition_itemId by b.itemId into g
                    join c in ctx.items on g.Key equals c.itemId
                    join d in ctx.categories on c.categoryId equals d.categoryId
                    select new
                    {
                        itemID = g.Key,
                        Category = d.categoryName,
                        Itemname = c.description,
                        amount = g.Count(),
                        Unit = c.unit,
                        Bin = c.binNumber

                    };
            GridView1.DataSource = n.ToList();
            GridView1.DataBind();
        }
        protected void change()
        {
          
            String ts = Department.SelectedValue;
           
            var n = from a in ctx.requisitions
                    join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
                    where (a.departmentId == ts)
                    group b.requisition_itemId by b.itemId into g
                    join c in ctx.items on g.Key equals c.itemId
                    join d in ctx.categories on c.categoryId equals d.categoryId
                    select new
                    {
                        itemID = g.Key,
                        Category = d.categoryName,
                        Itemname = c.description,
                        amount = g.Count(),
                        Unit = c.unit,
                        Bin = c.binNumber

                    };

            {
                GridView1.DataSource = n.ToList();
                GridView1.DataBind();
            }
        }

     
        protected void Department_SelectedIndexChanged1(object sender, EventArgs e)
        {
            change();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (Department.Visible)
            {
                change();
            }
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            
        }

        protected void viewby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewby.SelectedValue == "View By Department")
            {
                Department.Visible = true;
            }
            else
            {
                Department.Visible = false;
            }
        }

        protected void CurrentWeek_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClerkHome.aspx");
        }
    }
}