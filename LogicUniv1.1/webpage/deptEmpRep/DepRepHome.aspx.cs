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
    public partial class DepEmpHome : System.Web.UI.Page
    {
        ConfirmDisbursementListController cdlc = new ConfirmDisbursementListController();

        User u = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            if (cdlc.getDisbursementList(u).Count() == 0)
            {
                Label1.Text = "Current Disbursementlist has not been generated yet..";
                confirmBtn.Visible = false;
            }
            else
            {
                Label1.Text = "Current Week Disbursement List";
                contacName.Text = "Contact Person: " + cdlc.getDisbursementList(u).First().ContacName;
                address.Text ="Collection Point: " + cdlc.getDisbursementList(u).First().Address;
                time.Text ="Collection Time: " + cdlc.getDisbursementList(u).First().Time;
                colldate.Text = "Collection Date: " + cdlc.getDisbursementList(u).First().CollectionDate.ToShortDateString();
                GridView1.DataSource = cdlc.getDisbursementList(u);
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
            
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            cdlc.confirmRceive();
        }
    }
}