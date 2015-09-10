using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class CurrentDisbursementDetailItem : System.Web.UI.Page
    {
        ViewDisbursementListController vc = new ViewDisbursementListController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(Session["passing"]);
            Object o = vc.getDetailedItem(p);
            GridView1.DataSource = o;
            GridView1.DataBind();

            String deptvalue = Session["deptValue"].ToString();
            Object collectionPoint= vc.getCollectionPoint(deptvalue);
            lbl_collectionPoint.Text = "Collection Point:"+collectionPoint.ToString();
            lbl_time.Text = "Collection Time" + disPlayTime();
        }
        // We assure that the Collection Time will be the next Monday
        protected String disPlayTime()
        {
            DateTime dt = DateTime.Now;
            int weeknow = Convert.ToInt32(DateTime.Now.DayOfWeek);
            int dayspan = (-1) * weeknow + 1;
            DateTime dt2 = dt.AddMonths(1);

            String time = DateTime.Now.AddDays(dayspan).ToString("yyyy-MM-dd");
            return time;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        
    }
}