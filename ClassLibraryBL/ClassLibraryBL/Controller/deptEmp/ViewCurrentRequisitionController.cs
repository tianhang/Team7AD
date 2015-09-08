using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Controller.deptEmp
{

    public class ViewCurrentRequisitionController
    {
        RequisiitonFacade refacade = new RequisiitonFacade();
        public List<requisition> PendingPastRequisition(User u)
        {
            return refacade.getPendingRequisitionEmployee(u);

        }

        public List<RequisitionDetails> RequisitionDetail(string rid)
        {
            return refacade.getRequisitionDetails(rid);

        } 
    }
}
