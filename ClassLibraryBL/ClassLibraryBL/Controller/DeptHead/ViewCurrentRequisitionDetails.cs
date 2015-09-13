using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.DeptHead
{
    public class ViewCurrentRequisitionDetails
    {
        RequisiitonFacade rf = new RequisiitonFacade();

        public List<RequisitionDetails> getRequisitionDetails(string rid)
        {
            return rf.getRequisitionDetails(rid);
        }
        public void approveRequisition(int x)
        {
            rf.approveRequisition(x);
        }
        public void rejectRequisition(int x, string reason)
        {
            rf.rejectRequisition(x, reason);
        }

        public void checkItemAvailable(int x)
        {
            rf.checkItemAvailable(x);
        }

    }
}