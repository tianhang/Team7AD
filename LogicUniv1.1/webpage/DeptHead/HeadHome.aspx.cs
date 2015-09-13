using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Controller.DeptHead;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class HeadHome : System.Web.UI.Page
    {
        User u = new User();
        ViewCurrentRequistionController vrc = new ViewCurrentRequistionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //User userbean = (User)Session["UserEntity"];
            //head.Text = "Hello," + userbean.Name;

            u = (User)Session["UserEntity"];
            if (vrc.getPendingRequisition(u).Count() == 0)
            {
                flag.Text = "There is no Current Requsition at this moment.";
                //RejectBtn.Visible = false;
                //ApproveBtn.Visible = false;
            }

            else
            {
                GridView1.DataSource = vrc.getPendingRequisition(u);
                GridView1.DataBind();
               
            }
        }
        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging1(object sender, GridViewSelectEventArgs e)
        {
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          //  Response.Redirect("RequisitionDetails.aspx?rid=" + 1);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("RequisitionDetails.aspx?rid=" + GridView1.SelectedRow.Cells[0].Text);
        }






    }
}