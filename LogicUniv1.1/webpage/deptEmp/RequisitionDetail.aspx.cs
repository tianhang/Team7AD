using ClassLibraryBL;
using ClassLibraryBL.Controller.deptEmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogicUniv1._1.webpage.deptEmp
{
    public partial class RequisitionDetail : System.Web.UI.Page
    {
        LogicUnivSystemEntities lu = new LogicUnivSystemEntities();
        ViewCurrentRequisitionController vcrc = new ViewCurrentRequisitionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int rid = Convert.ToInt32(Request.QueryString["rid"]);
            Label4.Text = rid.ToString();
            string cpoint = "";
            string st = "";
            //var M = from a in lu.requisitions
            //        join b in lu.requsiiton_item on a.requisitionId equals b.requisitionId
            //        join c in lu.items on b.itemId equals c.itemId
            //        join d in lu.departments on a.departmentId equals d.departmentId
            //        join f in lu.collectionPoints on d.collectionPointId equals f.collectionPointId
            //        where a.requisitionId == rid
            //        select new
            //        {
            //            Cpoint = f.address,
            //            Rid = a.requisitionId,
            //            Status = a.status,


            //        };
            //var N = from a in lu.requisitions
            //        join b in lu.requsiiton_item on a.requisitionId equals b.requisitionId
            //        join c in lu.items on b.itemId equals c.itemId
            //        join d in lu.departments on a.departmentId equals d.departmentId
            //        join f in lu.collectionPoints on d.collectionPointId equals f.collectionPointId
            //        where a.requisitionId == rid
            //        select new
            //        {

            //            Qty = b.requestQty,
            //            ItemName = c.description,
            //            itemPhoto = "../images/"+c.description.Trim()+".jpg"

            //        };




            var val = vcrc.RequisitionDetail(rid.ToString()).First();
            cpoint = val.CollectionPoint;
            st = val.Status_dept;
            Label5.Text = cpoint;
            Label6.Text = st;

            GridView1.DataSource = vcrc.RequisitionDetail(rid.ToString());
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PreviousRequisition.aspx");
        }


        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

        }

    }
}