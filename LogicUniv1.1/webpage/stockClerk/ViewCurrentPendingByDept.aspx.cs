using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibraryBL.Controller.stockClerk;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewCurrentPendingByDept : System.Web.UI.Page
    {
        ViewPendingFormController vpfc = new ViewPendingFormController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedValue = ddl_dept.SelectedValue;
            Object o= vpfc.getListByDept(selectedValue);
            try
            {
                GridView1.DataSource = o;
                GridView1.DataBind();
            }
            catch { }
        }

       

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String s = GridView1.Rows[Convert.ToInt16(e.CommandArgument)].Cells[1].Text;
            Session["transferId"] = s;
            Response.Redirect("ViewCurrentPendingByDeptDetails.aspx");
        }

        protected void btn_byItem_Click(object sender, EventArgs e)
        {
            btn_byItem.Enabled = false;
            Response.Redirect("ViewCurrentPendingByItems.aspx");
        }


    }
}