using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using ClassLibraryBL;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewCurrentPendingByItems : System.Web.UI.Page
    {
        ViewPendingFormController vpController = new ViewPendingFormController();
        PlaceOrderController pl = new PlaceOrderController();
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            user u = (user)Session["User"];
            int itemcode= Convert.ToInt32(e.CommandArgument);
            string k = GridView1.Rows[itemcode].Cells[1].Text;
            string l = GridView1.Rows[itemcode].Cells[3].Text;
            itemcode = Convert.ToInt32(k);
            int quantity=Convert.ToInt32(l);
            int supplierid = pl.findsupplier(itemcode);
            purchase s = pl.newpurhcase(supplierid,u.userId);
            pl.additems(itemcode, supplierid, s.purchaserId, quantity);
            Session["purchaseitem"] = s;
            Response.Redirect("Purchaseitems.aspx");
        }

    }
}