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
    public partial class Purchaseitem : System.Web.UI.Page
    {
        PlaceOrderController pl = new PlaceOrderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            purchase s=(purchase) Session["purchaseitem"];
            List<Purchaseitem111> l = pl.showpurchaseitems(s);
            GridView1.DataSource = l;
            GridView1.DataBind();
            Label3.Text = s.purchaserId.ToString();
            Label5.Text = DateTime.Today.Date.ToShortDateString();
            foreach (GridViewRow r in GridView1.Rows)
            {
                DropDownList dp = (DropDownList)r.FindControl("choosesupplier");
                int i=s.supplierId;
                int k=Convert.ToInt32(r.Cells[0].Text);
                int x = s.purchaserId;
                dp.DataSource = pl.getcompanyname(k, i,x);
                dp.DataBind();
            }
            Itemchoose.DataSource = pl.showitemsbysupppier(s.supplierId);
            Itemchoose.DataBind();
        }

      
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
                //GridViewRow gvr = (GridViewRow)((Control)e.CommandSource).Parent.Parent
            purchase s = (purchase)Session["purchaseitem"];
            int index=Convert.ToInt32(e.CommandArgument);
            string k =GridView1.Rows[index].Cells[0].Text;
            index = Convert.ToInt32(k);
            DropDownList dp = (DropDownList)GridView1.Rows[0].Cells[0].FindControl("choosesupplier");
            string sp = dp.Text;
            if (e.CommandName == "ChangeSupplier")
            {
                pl.changesupplier(index, s.purchaserId, sp);
            
            };
            if (e.CommandName == "DeleteItem")
            {
                pl.delete(index, s.supplierId, s.purchaserId);
            }
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            purchase s = (purchase)Session["purchaseitem"];
            string description = Itemchoose.SelectedValue;
            int itemcode = pl.finditemcode(description, s.supplierId);
            int qt = Convert.ToInt32(itemnumber.Text);
            pl.additems(itemcode, s.supplierId, s.purchaserId, qt);
            Response.Redirect("Purchaseitems.aspx");
        }

       
     

     
    }
}