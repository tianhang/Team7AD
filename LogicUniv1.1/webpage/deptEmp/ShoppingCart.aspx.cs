using ClassLibraryBL;
using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.deptEmp;

namespace LogicUniv1._1.webpage.deptEmp
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        List<item> itemList = new List<item>();
        // List<string> idlistBuy = new List<string>();
        List<int> idlistInt = new List<int>();
        //List<string> amountlist = new List<string>();
        List<int> amountlistInt = new List<int>();
        List<string> namelist = new List<string>();
        List<ShoppingItem> sclist = new List<ShoppingItem>();
        List<ShoppingItem> sclist2 = new List<ShoppingItem>();
        RaiseNewRequisitonController rnrc = new RaiseNewRequisitonController();
        User u = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                string idstr = Request.QueryString["idstr"];
                string amountstr = Request.QueryString["amountstr"];
                itemList = (List<item>)Session["itemList"];

                idlistInt = rnrc.getIdlistInt(idstr);

                amountlistInt = rnrc.getAmountlistInt(amountstr);

                namelist = rnrc.getNamelist(itemList, idlistInt);

                sclist = rnrc.addShoppingItem(namelist, amountlistInt, idlistInt);
                Session["sclist"] = sclist;
                GridView1.DataSource = sclist;
                GridView1.DataBind();

            }


        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            for (int i = 0; i < sclist2.Count; i++)
            {
                if (sclist2[i].Description.Equals(GridView1.SelectedRow.Cells[1].Text))
                {
                    sclist2.Remove(sclist2[i]);
                }

            }
            Session["sclist"] = sclist2;
            GridView1.DataSource = sclist2;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = sclist2;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string s = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString().Trim();
            int b = Convert.ToInt32(s);
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            string a = GridView1.Rows[e.RowIndex].Cells[1].Text;
            for (int i = 0; i < sclist2.Count; i++)
            {
                if (sclist2[i].Description.Equals(a))
                {
                    sclist2[i].Amount = b;
                }

            }
            Session["sclist"] = sclist2;
            GridView1.DataSource = sclist2;
            GridView1.DataBind();



        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            GridView1.DataSource = sclist2;
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            GridView1.DataSource = sclist2;
            GridView1.DataBind();
            GridView1.EditIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            sclist2 = (List<ShoppingItem>)Session["sclist"];
            rnrc.addRequisitionController(u, sclist2);
            Label1.Text = "add success";

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}