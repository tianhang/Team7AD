using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockManager;
namespace LogicUniv1._1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        ApproveStockAdjustmentController manager = new ApproveStockAdjustmentController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            manager.checkdiscrepancyitem(s);
            GridView1.DataSource = manager.checkdiscrepancyitem(s);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            manager.apporvediscrepancy(s);
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Session["id"].ToString());
            manager.rejectdiscrepancy(s);
        }
    }
}