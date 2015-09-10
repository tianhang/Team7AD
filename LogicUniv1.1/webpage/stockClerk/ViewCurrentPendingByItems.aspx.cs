using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewCurrentPendingByItems : System.Web.UI.Page
    {
        ViewPendingFormController vpController = new ViewPendingFormController();
        protected void Page_Load(object sender, EventArgs e)
        {
            Object o= vpController.getAllPendingItem();
            GridView1.DataSource = o;
            GridView1.DataBind();
        }

        protected void btn_byDept_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCurrentPendingByDept.aspx");
        }

    }
}