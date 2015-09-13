using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.deptEmp
{
    public partial class EmpHome : System.Web.UI.Page
    {
        LogicUnivSystemEntities lu = new LogicUnivSystemEntities();
        List<item> itemList = new List<item>();
        string b = ""; string c = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var N = from a in lu.items
                        select new
                        {
                            itemId = a.itemId,
                            unit = a.unit,
                            categoryId = a.categoryId,
                            description = a.description,
                            reorderlevel = a.reorderlevel,
                            reorderQty = a.reorderQty,
                            balance = a.balance,
                            binNumber = a.binNumber,
                           
                              

                        };
                foreach (var i in N)
                {
                    item it = new item();
                    it.itemId = i.itemId;
                    it.unit = i.unit;
                    it.categoryId = i.categoryId;
                    it.description = i.description;
                    it.reorderlevel = i.reorderlevel;
                    it.reorderQty = i.reorderQty;
                    it.balance = i.balance;
                    it.binNumber = i.binNumber;
                    
                    itemList.Add(it);


                }
                Session["itemList"] = itemList;
                //List<item> itemList = N.ToList();
                //GridView1.DataSource = N.ToList();
                //GridView1.DataBind();
                var M = from a in lu.categories
                        select new
                        {
                            categoryId = a.categoryId,
                            categoryName = a.categoryName

                        };
                DropDownList1.DataSource = M.ToList();
                DropDownList1.DataTextField = "categoryName";
                DropDownList1.DataValueField = "categoryId";
                DropDownList1.DataBind();


            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //a = TextBox1.Text;
            b = HiddenField1.Value;
            Response.Write(b);
            c = HiddenField2.Value;
            Response.Write(c);



            string s_url = "ShoppingCart.aspx?idstr=" + b + "&amountstr=" + c;
            Response.Redirect(s_url);




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var N = from a in lu.items
                    where a.description.Contains(TextBox1.Text)
                    select new
                    {
                        itemId = a.itemId,
                        unit = a.unit,
                        categoryId = a.categoryId,
                        description = a.description,
                        reorderlevel = a.reorderlevel,
                        reorderQty = a.reorderQty,
                        balance = a.balance,
                        binNumber = a.binNumber,
                        


                    };
            List<item> itemList2 = new List<item>();
            foreach (var i in N)
            {
                item it = new item();
                it.itemId = i.itemId;
                it.unit = i.unit;
                it.categoryId = i.categoryId;
                it.description = i.description;
                it.reorderlevel = i.reorderlevel;
                it.reorderQty = i.reorderQty;
                it.balance = i.balance;
                it.binNumber = i.binNumber;
               
                itemList2.Add(it);


            }

            Session["itemList"] = null;
            Session["itemList"] = itemList2;

        }



        protected void Button3_Click(object sender, EventArgs e)
        {

            int cid = Convert.ToInt32(DropDownList1.SelectedValue);
            var N = from a in lu.items
                    where a.categoryId == cid
                    select new
                    {
                        itemId = a.itemId,
                        unit = a.unit,
                        categoryId = a.categoryId,
                        description = a.description,
                        reorderlevel = a.reorderlevel,
                        reorderQty = a.reorderQty,
                        balance = a.balance,
                        binNumber = a.binNumber,
                       


                    };
            List<item> itemList2 = new List<item>();
            foreach (var i in N)
            {
                item it = new item();
                it.itemId = i.itemId;
                it.unit = i.unit;
                it.categoryId = i.categoryId;
                it.description = i.description;
                it.reorderlevel = i.reorderlevel;
                it.reorderQty = i.reorderQty;
                it.balance = i.balance;
                it.binNumber = i.binNumber;
               
                itemList2.Add(it);


            }

            Session["itemList"] = null;
            Session["itemList"] = itemList2;


        }

        
       
    }
}