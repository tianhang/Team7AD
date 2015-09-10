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
    public partial class DisbursementListDetails : System.Web.UI.Page
    {
        ViewPastDisbursementListController vpdc = new ViewPastDisbursementListController();

        User u = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            int p = int.Parse(Request.Params["did"]);
            getdisbusementDetails(u,p);
        }
        public void getdisbusementDetails(User u, int p)
        {
            Label1.Text = "Disbursement List ID: " + Request.Params["did"];
            contacName.Text = "Contact Person: " + vpdc.getDetailDisbursementList(u,p).First().ContacName;
            address.Text = "Collection Point: " + vpdc.getDetailDisbursementList(u,p).First().Address;
            time.Text = "Collection Time: " + vpdc.getDetailDisbursementList(u,p).First().Time;
            Labelflag.Text = "Collection Date: " + vpdc.getDetailDisbursementList(u, p).First().CollectionDate.ToShortDateString();
            GridView1.DataSource = vpdc.getDetailDisbursementList(u,p);
            GridView1.DataBind();
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

    }
}