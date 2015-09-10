using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk  ;
using ClassLibraryBL;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewCurrentPendingByDeptDetails : System.Web.UI.Page
    {
        ViewPendingFormController vpfc;
        protected void Page_Load(object sender, EventArgs e)
        {
            vpfc = new ViewPendingFormController();
            String rId = Session["transferId"].ToString();
            Label1.Text = "Details for Requisition "+rId;
            Object o= vpfc.getListByDeptDetail(rId);
            GridView1.DataSource = o;
            GridView1.DataBind();
        }


    }
}