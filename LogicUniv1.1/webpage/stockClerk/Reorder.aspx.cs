using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class Reorder : System.Web.UI.Page
    {
        PlaceOrderController pl = new PlaceOrderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u.RoleId != 4)
            {
                Response.Redirect("../Security.aspx");
            }
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                CheckBox chek = (CheckBox)r.FindControl("Choose");
                if (chek.Checked)
                {
                    int k = Convert.ToInt32(r.Cells[0].Text);
                    pl.confirmorder(k);
                }

            }
            Response.Redirect("Reorder.aspx");
        }

        protected void Order_Click(object sender, EventArgs e)
        {
            user u = (user)Session["User"];
            pl.formorder(u);
            Response.Redirect("Reorder.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k=Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
            Session["purchaseitem"] = pl.findpurchaseorder(k);
            Response.Redirect("Purchaseitems.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                CheckBox chek = (CheckBox)r.FindControl("Choose");
                if (chek.Checked)
                {
                    int k = Convert.ToInt32(r.Cells[0].Text);
                    pl.cancel(k);
                }

            }
            Response.Redirect("Reorder.aspx");
        }
    }
}