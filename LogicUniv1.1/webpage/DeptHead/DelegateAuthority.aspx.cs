using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.DeptHead;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class DelegateAuthority : System.Web.UI.Page
    {

        DelegateAuthorityController dac = new DelegateAuthorityController();
        User u = new User();


        protected void Page_Load(object sender, EventArgs e)
        {
            
            u = (User)Session["UserEntity"];

            getAllEmployee(u);
        }

        public void getAllEmployee(User u)
        {
            GridEmp.DataSource = dac.getAllEmployee(u);
            GridEmp.DataBind();
        }



        protected void delegateBtn_Click(object sender, EventArgs e)
        {
            Label1.Text = "1";
            foreach (GridViewRow r in GridEmp.Rows)
            {
                CheckBox chk = (CheckBox)r.FindControl("chkbx");
               // CheckBox chk = r.Cells[2].Controls[0] as CheckBox;
                if (chk != null && chk.Checked)
                {
                    Label1.Text = "2";
                    Label1.Text = r.Cells[1].Text + "<br>";
                }
            }
        }

        protected void GridEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = GridEmp.SelectedRow.Cells[1].Text;
        }

        protected void GridEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           
            GridEmp.PageIndex = e.NewPageIndex;
            GridEmp.DataBind();
        }

        protected void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string startDate = checkInDatePicker.Text;
            string endDate = checkOutDatePicker.Text;
            dac.mailNotification(startDate, endDate, u.Name);
            Label2.Text = "Successfuly delegated, Email has been sent to all relevant individual.";

            
        }
    }
}