using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.controller;
using ClassLibraryBL.Entities;
using System.ComponentModel;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.Globalization;



namespace LogicUniv1._1.webpage.stockSupervisor
{

    public partial class CompareThreeMonths : System.Web.UI.Page
    {
        string monthA;
        string monthB;
        string monthC;
        string department;

        RequestItemFacade rif = new RequestItemFacade();
        DepartmentFacade df = new DepartmentFacade();
        RequisitionTrendFacade rtf = new RequisitionTrendFacade();
        RequestThreeMonthsEntityFacade rtef = new RequestThreeMonthsEntityFacade();

        protected void Page_Load(object sender, EventArgs e)
        {
            User userbean = (User)Session["UserEntity"];
            if (!IsPostBack)
            {
                //User userbean = (User)Session["UserEntity"];
                //Supervisor.Text = "Hello," + userbean.Name;

                List<Department> list = df.GetDepName();
                DropDownListDepartment.DataSource = list;
                DropDownListDepartment.DataTextField = "deptName";
                DropDownListDepartment.DataValueField = "deptName";
                DropDownListDepartment.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            monthA = DropDownListMonthA.SelectedItem.Value;
            monthB = DropDownListMonthB.SelectedItem.Value;
            monthC = DropDownListMonthC.SelectedItem.Value;
            int mA = Convert.ToInt16(monthA);
            int mB = Convert.ToInt16(monthB);
            int mC = Convert.ToInt16(monthC);
            department = DropDownListDepartment.SelectedItem.Value;
            //Creat Chart 
            int MonthA;
            int MonthB;
            int MonthC;
            DataTable dt = new DataTable();
            dt.Columns.Add("Category");
            dt.Columns.Add("QtyMonthA");
            dt.Columns.Add("QtyMonthB");
            dt.Columns.Add("QtyMonthC");
            List<RequestThreeMonthsEntity> rtmeListMonthA = rtef.GetRequestThreeMonthsEntity(mA, department);
            List<RequestThreeMonthsEntity> rtmeListMonthB = rtef.GetRequestThreeMonthsEntity(mB, department);
            List<RequestThreeMonthsEntity> rtmeListMonthC = rtef.GetRequestThreeMonthsEntity(mC, department);

            //Get categoryname
            List<string> categoryNamelist = rtf.GetCategoryName();

            foreach (string cName in categoryNamelist)
            {
                MonthA = GetQtyByMonth(cName, rtmeListMonthA);
                MonthB = GetQtyByMonth(cName, rtmeListMonthB);
                MonthC = GetQtyByMonth(cName, rtmeListMonthC);
                dt.Rows.Add(new object[] { cName, MonthA, MonthB, MonthC });
            }
            Chart1.Series[0].Color = Color.Red;
            Chart1.Series[1].Color = Color.SteelBlue;
            Chart1.Series[2].Color = Color.BlueViolet;
            Chart1.Series[0].Name = monthA;
            Chart1.Series[1].Name = monthB;
            Chart1.Series[2].Name = monthC;
            Chart1.Series[0].XValueMember = "Category";
            Chart1.Series[0].YValueMembers = dt.Columns[1].ToString();
            Chart1.Series[1].YValueMembers = dt.Columns[2].ToString();
            Chart1.Series[2].YValueMembers = dt.Columns[3].ToString();
            Chart1.Series[0].LegendText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mA);
            Chart1.Series[1].LegendText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mB);
            Chart1.Series[2].LegendText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mC);

            //Chart bind
            Chart1.DataSource = dt.DefaultView;
            Chart1.DataBind();
            //Table bind
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        public int GetQtyByMonth(string categoryName, List<RequestThreeMonthsEntity> rtmeList)
        {
            int qty = 0;
            foreach (RequestThreeMonthsEntity rtme in rtmeList)
            {
                if (rtme.categoryName == categoryName)
                {
                    qty = rtme.requestQty;
                }
            }
            return qty;
        }


        protected void Chart1_Load(object sender, EventArgs e)
        {
        }





    }
}
