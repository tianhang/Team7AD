using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.controller;
using ClassLibraryBL;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using System.Data;
namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkSupplierTenderManagePengxiaomeng : System.Web.UI.Page
    {
        MaintainTenderInfoController clerk = new MaintainTenderInfoController();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s = (supplier)Session["supplier"];
            Label2.Text = s.supplierId.ToString();
            Label4.Text = s.compName;
            GridView1.DataSource= clerk.showitems(s.supplierId);
            GridView1.DataBind();
        }

        protected void search_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s = (supplier)Session["supplier"];
            GridView1.DataSource= clerk.searchbydescription(TextBox1.Text, s.supplierId);
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s = (supplier)Session["supplier"];
            int k = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            SupplieritemMix sup = new SupplieritemMix();
            sup = clerk.showsingleitem(k, s.supplierId);
            ItemDescription.Text = sup.Itemdescription;
            ItemCode.Text = sup.itemid.ToString();
            ExisitingPricer.Text = sup.price.ToString();
            Unit.Text = sup.Unit.ToString();
            ClientScript.RegisterStartupScript(this.GetType(), "SayHello2", "$('#exampleModal').modal({})", true); 
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s = (supplier)Session["supplier"];
            int k = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            int i = Convert.ToInt32(NewPrice.Text);
            clerk.editprice(k, s.supplierId, i);
            GridView1.DataSource = clerk.showitems(s.supplierId);
            GridView1.DataBind();
        }

       

       


       
        

        
    }
}