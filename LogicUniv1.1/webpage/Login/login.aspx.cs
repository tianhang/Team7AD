using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.controller;
using ClassLibraryBL.EntityFacade;



namespace LogicUnivTeam7.webpage.Login
{
    
    public partial class login : System.Web.UI.Page
    {
        loginFacade lf = new loginFacade();
        loginController lc = new loginController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.InitializeControls();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = username.Text;
            string y = password.Text;
            if (lc.Authentication(x, y))
            {
                Session["UserEntity"] = lf.fillInEntity(x, y);
                int role = lf.fillInEntity(x, y).RoleId;
               
                switch (role)
                {
                    case 1: //depthead
                    Response.Redirect("../DeptHead/HeadHome.aspx");
                    break;
                    case 2: //deptEmp
                    Response.Redirect("../deptEmp/EmpHome.aspx");
                    break;
                    case 3: //deptEmpRep
                    Response.Redirect("../deptEmpRep/DepRepHome.aspx");
                    break;
                    case 4://stockClerk
                    Response.Redirect("../stockClerk/ClerkManageRequisition.aspx");
                    break;
                    case 5://stockSupervisor
                    Response.Redirect("../stockSupervisor/SSHome.aspx");
                    break;
                    case 6:////stockManager
                    Response.Redirect("../stockManager/SMHome.aspx");
                    break;
                }
                
            }
            else
            {
                flag.Text = "Email or Password is not correct, Try again.";
            }


        }

        public void InitializeControls()
        {
            this.username.Text = string.Empty;
            this.password.Text = string.Empty;
        }
    }
}