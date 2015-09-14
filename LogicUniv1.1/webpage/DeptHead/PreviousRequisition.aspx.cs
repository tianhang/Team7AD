using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller.DeptHead;

namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class PreviousRequisition : System.Web.UI.Page
    {
        User u = new User();
        ViewPastRequistionController vprc = new ViewPastRequistionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            if (vprc.getPreRequisition(u).Count() == 0)
            {
                head.Text = "There is no History Requsition at this moment.";
                //RejectBtn.Visible = false;
                //ApproveBtn.Visible = false;
            }

            else
            {
                GridView2.DataSource = vprc.getPreRequisition(u);
                GridView2.DataBind();

            }
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("RequisitionDetails.aspx?rid=" + GridView2.SelectedRow.Cells[0].Text + "&idet=pre");
        }




    }
}