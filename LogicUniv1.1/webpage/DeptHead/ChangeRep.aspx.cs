using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller.DeptHead;

namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class ChangeRep : System.Web.UI.Page
    {

        MaintainEmployeeRepController merc = new MaintainEmployeeRepController();
        User u = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            u = (User)Session["UserEntity"];
            getAllEmployee(u);
        }
        public void getAllEmployee(User u)
        {
            GridEmp.DataSource = merc.getAllEmployee(u);
            GridEmp.DataBind();
        }
        protected void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string name = GridEmp.SelectedRow.Cells[0].Text.Trim();
            string uid = GridEmp.SelectedRow.Cells[1].Text.Trim();
            string startDate = checkInDatePicker.Text;
            string endDate = checkOutDatePicker.Text;
            merc.AssignNewRep(uid);
            merc.mailNotification(startDate, endDate, u, name);
            Label2.Text = "Successfuly Assigned, Email has been sent to all relevant individual.";
        }

        protected void GridEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridEmp.PageIndex = e.NewPageIndex;
            GridEmp.DataBind();
        }

        protected void GridEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Label3.Text = GridEmp.SelectedRow.Cells[0].Text.Trim();
        }


    }
}