using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller.deptEmpRep;

namespace LogicUniv1._1.webpage.deptEmpRep
{
    public partial class ViewHistoryDisbursement : System.Web.UI.Page
    {
        ViewPastDisbursementListController vpdc = new ViewPastDisbursementListController();

        User u = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            if (vpdc.getHisDisbursementList(u).Count() == 0)
            {
                Label1.Text = "There is no history disbursement list..";
                
            }
            else
            {
                GridView1.DataSource = vpdc.getHisDisbursementList(u);
                

                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = GridView1.SelectedRow.Cells[0].Text;

            Response.Redirect("DisbursementListDetails.aspx?did=" + GridView1.SelectedRow.Cells[0].Text);
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {

        }
    }
}