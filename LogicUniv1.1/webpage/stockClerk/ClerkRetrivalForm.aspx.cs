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
using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkRetrivalForm : System.Web.UI.Page
    {
        ViewRetrievalFormController view = new ViewRetrievalFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u.RoleId != 4)
            {
                Response.Redirect("../Security.aspx");
            }
            if (!IsPostBack)
            {

                GridView1.DataSource = view.checkcurrentweekbyitem();
                GridView1.DataBind();

            }
        }
        //public void bandingtable1()
        //{
        //        DateTime da = DateTime.Today.Date;
        //        String dw = da.DayOfWeek.ToString();

        //            switch (dw)
        //            {
        //                case "Tuesday":
        //                    da = da.AddDays(-1);
        //                    break;
        //                case "Wednesday":
        //                    da = da.AddDays(-2);
        //                    break;
        //                case "Thursday":
        //                    da = da.AddDays(-3);
        //                    break;
        //                case "Friday":
        //                    da = da.AddDays(-4);
        //                    break;
        //                case "Saturday":
        //                    da = da.AddDays(-5);
        //                    break;
        //                case "Sunday":
        //                    da = da.AddDays(-6);
        //                    break;
        //                default:
        //                    break;
        //            }

        //        var n = from a in ctx.requisitions
        //                join b in ctx.requsiiton_item on a.requisitionId equals b.requisitionId
        //                where (a.requestDate > da)
        //                group b.requisition_itemId by b.itemId into g
        //                join c in ctx.items on g.Key equals c.itemId
        //                join d in ctx.categories on c.categoryId equals d.categoryId
        //                select new
        //                {
        //                    itemID = g.Key,
        //                    Category = d.categoryName,
        //                    Itemname = c.description,
        //                    amount = g.Count(),
        //                    Unit = c.unit,
        //                    Bin = c.binNumber

        //                };
        //        GridView1.DataSource = n.ToList();
        //        GridView1.DataBind();

        //}


        protected void HistoryLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClerkHistoryLogPengxiaomeng.aspx");
        }

        protected void CurrentWeek_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = view.checkcurrentweekbyitem();
            GridView1.DataBind();
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            if (Department.Visible == true)
            {
                String ts = Department.SelectedValue;
                GridView1.DataSource = view.checkcurrentweekbydepartment(ts);
            }
            else
            {
                GridView1.DataSource = view.checkcurrentweekbyitem();
            }
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

        }

        protected void viewby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewby.SelectedValue == "View By Department")
            {
                Department.Visible = true;
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
            else
            {
                Department.Visible = false;

                GridView1.DataSource = view.checkcurrentweekbyitem();
                GridView1.DataBind();
            }
        }


        protected void Department_SelectedIndexChanged1(object sender, EventArgs e)
        {
            String ts = Department.SelectedValue;
            GridView1.DataSource = view.checkcurrentweekbydepartment(ts);
            GridView1.DataBind();

        }
    }
}