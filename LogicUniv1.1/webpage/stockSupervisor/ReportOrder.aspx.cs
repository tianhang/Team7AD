using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace LogicUniv1._1.webpage.stockSupervisor
{
    public partial class ReportOrder : System.Web.UI.Page
    {
        int month;
        ReportOrderFacade ro = new ReportOrderFacade();
        RequisitionTrendFacade rtf = new RequisitionTrendFacade();
        protected void Page_Load(object sender, EventArgs e)
        {
            User userbean = (User)Session["UserEntity"];
            //Supervisor.Text = "Hello," + userbean.Name;
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            month = Convert.ToInt16(DropDownListMonth.SelectedItem.Value);
            List<string> categoryNamelist = rtf.GetCategoryName();

            int qty;
            DataTable dt = new DataTable();
            dt.Columns.Add("Category");
            dt.Columns.Add("RequestQty");
            foreach (string cName in categoryNamelist)
            {
                ReportOrderEntity roe = new ReportOrderEntity();
                roe = ro.GetRequestQty(cName, month).FirstOrDefault();
                if (roe != null)
                {
                    qty = roe.requestQty;
                }
                else
                {
                    qty = 0;
                }
                dt.Rows.Add(cName, qty);
            }

            Chart1.Series[0].Name = "Category";

            Chart1.Series[0].XValueMember = dt.Columns[0].ToString();
            Chart1.Series[0].YValueMembers = dt.Columns[1].ToString();
            Chart1.Series[0].LegendText = "Category";


            GridView1.DataSource = dt;
            GridView1.DataBind();

            Chart1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
        }
    }
}