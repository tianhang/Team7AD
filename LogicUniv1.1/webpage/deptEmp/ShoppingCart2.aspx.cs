using ClassLibraryBL;
using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.deptEmp
{
    public partial class ShoppingCart2 : System.Web.UI.Page
    {
        List<item> itemList = new List<item>();
        List<string> idlistBuy = new List<string>();
        List<int> idlistInt = new List<int>();
        List<string> amountlist = new List<string>();
        List<int> amountlistInt = new List<int>();
        List<string> namelist = new List<string>();
        List<ShoppingItem> sclist = new List<ShoppingItem>();
        List<ShoppingItem> sclist2 = new List<ShoppingItem>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idstr = Request.QueryString["idstr"];
                string amountstr = Request.QueryString["amountstr"];
                //Response.Write(idstr);
                //Response.Write(amountstr);
                itemList = (List<item>)Session["itemList"];
                idlistBuy = idstr.Split('/').ToList();
                for (int i = 0; i < idlistBuy.Count; i++)
                {
                    if (idlistBuy[i] != "")
                    {

                        idlistInt.Add(Convert.ToInt32(idlistBuy[i]));

                    }
                }
                amountlist = amountstr.Split('/').ToList();
                for (int i = 0; i < amountlist.Count; i++)
                {
                    if (amountlist[i] != "")
                    {

                        amountlistInt.Add(Convert.ToInt32(amountlist[i]));

                    }
                }
                for (int i = 0; i < idlistInt.Count; i++)
                {
                    for (int j = 0; j < itemList.Count; j++)
                    {
                        if (idlistInt[i] == itemList[j].itemId)
                        {
                            namelist.Add(itemList[j].description);
                        }

                    }
                }
                for (int i = 0; i < namelist.Count; i++)
                {
                    ShoppingItem si = new ShoppingItem();
                    si.Description = namelist[i];
                    si.Amount = amountlistInt[i];
                    si.Photourl = "../images/" + namelist[i].Trim() + ".jpg";
                    si.ItemId = idlistInt[i];
                    sclist.Add(si);
                }
                Session["sclist"] = sclist;
                GridView1.DataSource = sclist;
                GridView1.DataBind();

            }


        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = GridView1.SelectedRow.Cells[1].Text;
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

        //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    sclist2 = (List<ShoppingItem>)Session["sclist"];
        //    GridView1.EditIndex = e.NewEditIndex;
        //    GridView1.DataSource = sclist2;
        //    GridView1.DataBind();
        //}

        //protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    string s = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString().Trim();
        //    int b = Convert.ToInt32(s);
        //    sclist2 = (List<ShoppingItem>)Session["sclist"];
        //    string a = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
        //    for (int i = 0; i < sclist2.Count; i++)
        //    {
        //        if (sclist2[i].Description.Equals(a))
        //        {
        //            sclist2[i].Amount = b;
        //        }

        //    }
        //    GridView1.DataSource = sclist2;
        //    GridView1.DataBind();


        //}

        //protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        //{
        //    GridView1.EditIndex = -1;
        //    sclist2 = (List<ShoppingItem>)Session["sclist"];
        //    GridView1.DataSource = sclist2;
        //    GridView1.DataBind();

        //}

        //protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        //{
        //    sclist2 = (List<ShoppingItem>)Session["sclist"];
        //    GridView1.DataSource = sclist2;
        //    GridView1.DataBind();
        //    GridView1.EditIndex = -1;
        //}
    }
}