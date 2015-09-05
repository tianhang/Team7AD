using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.DeptHead;
namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class RequisitionDetails : System.Web.UI.Page
    {
        ViewCurrentRequisitionDetails vcrd = new ViewCurrentRequisitionDetails();
        ViewPastRequistionController vprc = new ViewPastRequistionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["rid"] != null && Request.Params["idet"] != null)
            {
                retrievePreReqDetailsForHead(Request.Params["rid"]);
            }

            else
            {
                retrieveReqDetails(Request.Params["rid"]);
            }

        }
        public void retrievePreReqDetailsForHead(string rid)
        {
            Session["reqdetails"] = vprc.getRequisitionDetails(rid);
            reqid.Text = "Requisition Number: " + Request.Params["rid"];
            reqby.Text = "Requested By :" + vcrd.getRequisitionDetails(rid).First().Name;
            status.Text = "Status :" + vcrd.getRequisitionDetails(rid).First().Status;
            colpoint.Text = "Collection Point: " + vcrd.getRequisitionDetails(rid).First().CollectionPoint;
            RejectBtn.Visible = false;
            ApproveBtn.Visible = false;
        }


        public void retrieveReqDetails(string rid)
        {
            Session["reqdetails"] = vcrd.getRequisitionDetails(rid);
            reqid.Text = "Requisition Number: " + Request.Params["rid"];
            reqby.Text = "Requested By :" + vcrd.getRequisitionDetails(rid).First().Name;
            status.Text = "Status :" + vcrd.getRequisitionDetails(rid).First().Status;
            colpoint.Text = "Collection Point: " + vcrd.getRequisitionDetails(rid).First().CollectionPoint;

        }

        protected void ApproveBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.Params["rid"]);
            vcrd.approveRequisition(x);
            retrieveReqDetails(Request.Params["rid"]);
            RejectBtn.Enabled = false;
            ApproveBtn.Enabled = false;
            Labelflag.Text = "Successful Approved.";
        }

        protected void RejBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.Params["rid"]);
            string reason = RejReason.Text;
            vcrd.rejectRequisition(x,reason);
            retrieveReqDetails(Request.Params["rid"]);
            Labelflag.Text = "Requisition Rejected.";
            RejectBtn.Enabled = false;
            ApproveBtn.Enabled = false;
        }


        
    }
}