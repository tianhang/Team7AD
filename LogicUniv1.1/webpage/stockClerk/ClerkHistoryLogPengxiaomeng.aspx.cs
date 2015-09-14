using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkHistoryLogPengxiaomeng : System.Web.UI.Page
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();
        ViewRetrievalFormController view = new ViewRetrievalFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            user u = (user)Session["User"];
            if (u.roleId != 4)
            {
                Response.Redirect();
            }
            GridView1.DataSource = view.checkhistorybyitemwithoutdate();
            GridView1.DataBind();
        }     
     
        protected void Department_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (viewby.SelectedValue == "View By Item")
            {
                GridView1.DataSource = view.checkhistorybyitemwithoutdate();
            }
            else
            {
                string ts = Department.SelectedValue;
                GridView1.DataSource = view.checkhistorybydepartmentwithoutdate(ts);
            }
                  
            GridView1.DataBind();
            
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string start = startdate.Text;
            string end = enddate.Text;
            if ((start != "") && (end != ""))
            {
                if (Department.Visible)
                {
                     string ts = Department.SelectedValue;
                     GridView1.DataSource=view.checkhistorybydepartmentwithdate(ts,start,end);
                }
                    else
                    {
                       GridView1.DataSource=view.checkhistorybyitemwithdate(start,end);
                    }
            }
            else
            {
                if (Department.Visible)
                {
                    string ts = Department.SelectedValue;
                    GridView1.DataSource = view.checkhistorybydepartmentwithoutdate(ts);
                }
                else
                {
                    GridView1.DataSource = view.checkhistorybyitemwithoutdate();
                }
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
                GridView1.DataSource = view.checkhistorybyitemwithoutdate();
                GridView1.DataBind();
                Department.Visible = false;
            }
        }

        protected void CurrentWeek_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClerkRetrivalForm.aspx");
        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            string start = startdate.Text;
            string end = enddate.Text;
            string ts = Department.SelectedValue;
            if ((start != "") && (end != ""))
            {
                if (viewby.SelectedValue == "View By Department")
                {
                    GridView1.DataSource=view.checkhistorybydepartmentwithdate(ts, start, end);
                }
                else
                {
                    GridView1.DataSource = view.checkhistorybyitemwithdate(start, end);

                }
                GridView1.DataBind();
            }  
            }
        
        //protected void itemwithoutdate()
        //{
        //    var n = from a in ctx.requisitions
        //            join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
        //            group b.requisition_itemId by b.itemId into g
        //            join c in ctx.items on g.Key equals c.itemId
        //            join d in ctx.categories on c.categoryId equals d.categoryId
        //            select new
        //            {
        //                itemID = g.Key,
        //                Category = d.categoryName,
        //                Itemname = c.description,
        //                amount = g.Count(),
        //                Unit = c.unit,
        //                Bin = c.binNumber

        //            };
        //    GridView1.DataSource = n.ToList();
        //    GridView1.DataBind();
        //}
        //protected void itemwithdate()
        //{
        //    string start = startdate.Text;
        //    string end = enddate.Text;
        //    DateTime dt1 = DateTime.ParseExact(start, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //    DateTime dt2 = DateTime.ParseExact(end, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //    var n = from a in ctx.requisitions
        //            join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
        //            where (a.requestDate < dt2) && (a.requestDate > dt1)
        //            group b.requisition_itemId by b.itemId into g
        //            join c in ctx.items on g.Key equals c.itemId
        //            join d in ctx.categories on c.categoryId equals d.categoryId
        //            select new
        //            {
        //                itemID = g.Key,
        //                Category = d.categoryName,
        //                Itemname = c.description,
        //                amount = g.Count(),
        //                Unit = c.unit,
        //                Bin = c.binNumber

        //            };
        //    GridView1.DataSource = n.ToList();
        //    GridView1.DataBind();
        //}
        //protected void departmentwithoutdate()
        //{
        //    string ts = Department.SelectedValue;
        //    var n = from a in ctx.requisitions
        //            join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
        //            where (a.departmentId == ts)
        //            group b.requisition_itemId by b.itemId into g
        //            join c in ctx.items on g.Key equals c.itemId
        //            join d in ctx.categories on c.categoryId equals d.categoryId
        //            select new
        //            {
        //                itemID = g.Key,
        //                Category = d.categoryName,
        //                Itemname = c.description,
        //                amount = g.Count(),
        //                Unit = c.unit,
        //                Bin = c.binNumber

        //            };

        //    {
        //        GridView1.DataSource = n.ToList();
        //        GridView1.DataBind();
        //    }
        //}
        //protected void departmentwithdate()
        //{
        //    string start = startdate.Text;
        //    string end = enddate.Text;
        //    DateTime dt1 = DateTime.ParseExact(start, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //    DateTime dt2 = DateTime.ParseExact(end, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
        //    string ts = Department.SelectedValue;
        //    var n = from a in ctx.requisitions
        //            join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
        //            where (a.departmentId == ts) && (a.requestDate < dt2) && (a.requestDate > dt1)
        //            group b.requisition_itemId by b.itemId into g
        //            join c in ctx.items on g.Key equals c.itemId
        //            join d in ctx.categories on c.categoryId equals d.categoryId
        //            select new
        //            {
        //                itemID = g.Key,
        //                Category = d.categoryName,
        //                Itemname = c.description,
        //                amount = g.Count(),
        //                Unit = c.unit,
        //                Bin = c.binNumber

        //            };

        //    {
        //        GridView1.DataSource = n.ToList();
        //        GridView1.DataBind();
        //    }
        //}

        protected void HistoryLog1_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.ToString());
        }
       
    }
}