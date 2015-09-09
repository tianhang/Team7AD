using ClassLibraryBL;
using ClassLibraryBL.Controller.deptEmp;
using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.deptEmp
{
    public partial class PreviousRequisition : System.Web.UI.Page
    {
        LogicUnivSystemEntities lu = new LogicUnivSystemEntities();
        User u = new User();
        ViewPastRequisitionController vprc = new ViewPastRequisitionController();
        protected void Page_Load(object sender, EventArgs e)
        {

            u = (User)Session["UserEntity"];

            //var N = from a in lu.requisitions
            //        where a.userId == u.UserId
            //        select new
            //        {
            //            Rid = a.requisitionId,
            //            RequisitionDate = a.requestDate,
            //            Status = a.status
                       
                        

            //        };

            GridView1.DataSource = vprc.AllPastRequisition(u);
            GridView1.DataBind();




        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s_url = "RequisitionDetail.aspx?rid=" + GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect(s_url);

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

      
        
    }
}