using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;
using System.Data;



namespace LogicUniv1._1.webpage.stockSupervisor
{
    public partial class TrendForSupplier : System.Web.UI.Page
    {

        string department;
        string categary;
        string type;
        int Quantity;
        int CategoryCost;
        int fromMonth;
        int toMonth;

        RequestItemFacade rif = new RequestItemFacade();
        DepartmentFacade df = new DepartmentFacade();
        TrendForSupplierFacade tfsf = new TrendForSupplierFacade();
        RequisitionTrendFacade rtf = new RequisitionTrendFacade();
        protected void Page_Load(object sender, EventArgs e)
        {
            User userbean = (User)Session["UserEntity"];
            //Supervisor.Text = ("Hello," + userbean.Name).ToString();
            if (!IsPostBack)
            {

                //User userbean = (User)Session["UserEntity"];
                //Supervisor.Text = "Hello," + userbean.Name;

                List<Department> listDepartment = df.GetDepName();
                DropDownListDepartment.DataSource = listDepartment;
                DropDownListDepartment.DataTextField = "deptName";
                DropDownListDepartment.DataValueField = "deptName";
                DropDownListDepartment.DataBind();

                List<RequestItem> listCategary = rif.GetCategoryName();
                DropDownListCategory.DataSource = listCategary;
                DropDownListCategory.DataTextField = "CategoryName";
                DropDownListCategory.DataValueField = "CategoryName";
                DropDownListCategory.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //costOrContity = DropDownListCostOrQontity.SelectedItem.Text;
            department = DropDownListDepartment.SelectedValue;
            categary = DropDownListCategory.SelectedItem.Text;
            fromMonth = Convert.ToInt16(DropDownListMonthFrom.SelectedItem.Value);
            toMonth = Convert.ToInt16(DropDownListMonthTo.SelectedItem.Value);
            type = DropDownListType.SelectedItem.Value;
            List<string> categoryNamelist = rtf.GetCategoryName();
            // Test label

            // Test GridView
            DataTable dt = new DataTable();
            List<TrendForSupplierEntity> list = new List<TrendForSupplierEntity>();

            // Test Chart


            if (type == "Quantity")
            {
                dt.Columns.Add("Month");
                dt.Columns.Add("Quantity");
                for (int m = 1; m >= fromMonth && m <= toMonth; m++)
                {
                    list = tfsf.GetPrice(department, categary, m);
                    Quantity = GetQtyByMonth(list);
                    dt.Rows.Add(new object[] { m, Quantity });
                }
                Chart1.Series[0].XValueMember = dt.Columns[0].ToString();
                Chart1.Series[0].YValueMembers = dt.Columns[1].ToString();
            }
            else
            {
                dt.Columns.Add("Month");
                dt.Columns.Add("CategoryCost");
                for (int m = 1; m >= fromMonth && m <= toMonth; m++)
                {
                    list = tfsf.GetPrice(department, categary, m);
                    CategoryCost = GetCategoryCostByMonth(list);
                    dt.Rows.Add(new object[] { m, CategoryCost });
                }
                Chart1.Series[0].XValueMember = dt.Columns[0].ToString();
                Chart1.Series[0].YValueMembers = dt.Columns[1].ToString();
            }
            Chart1.Series[0].Name = type;
            Chart1.Series[0].LegendText = type;

            // GridView bind
            GridView1.DataSource = dt;
            GridView1.DataBind();
            // Chart bind
            Chart1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
        public int GetQtyByMonth(List<TrendForSupplierEntity> tfseList)
        {

            TrendForSupplierEntity tfse = new TrendForSupplierEntity();
            tfse = tfseList.FirstOrDefault();
            if (tfse != null)
            {
                return tfse.requestQty;
            }
            return 0;
        }
        public int GetCategoryCostByMonth(List<TrendForSupplierEntity> tfseList)
        {
            TrendForSupplierEntity tfse = new TrendForSupplierEntity();
            tfse = tfseList.FirstOrDefault();

            if (tfse != null)
            {
                return (int)tfse.categoryCost;
            }
            return 0;

        }
    }
}