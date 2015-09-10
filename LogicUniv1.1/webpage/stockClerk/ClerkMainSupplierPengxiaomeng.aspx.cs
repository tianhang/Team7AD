using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ClerkMainSupplierPengxiaomeng : System.Web.UI.Page
    {
        MaintainSupplierController con = new MaintainSupplierController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int i;
            //执行循环，保证每条数据都可以更新
            for (i = 0; i < GridView1.Rows.Count; i++)
            {
                //首先判断是否是数据行
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //当鼠标停留时更改背景色
                    e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
                    //当鼠标移开时还原背景色
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
                }
            }
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            con.addsupplier(CompanyName.Text, ContactName.Text, PhoneNumber.Text, FaxNumber.Text, Address.Text, gst.Text);
            Response.Write(CompanyName.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i =Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            Session["supplier"]= con.findsupplier(i); 
            Response.Redirect("ClerkSupplierTenderManagePengxiaomeng.aspx");

        }

     
    

     
        

       

     
       
      
    }
}