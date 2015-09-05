using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.DeptHead
{

    
    public class ViewPastRequistionController
    {
        RequisiitonFacade rf = new RequisiitonFacade();


        public List<requisition> getPreRequisition(User u)
        {
            return rf.getPreRequisition(u);
        }
        public List<RequisitionDetails> getRequisitionDetails(string rid)
        {
            return rf.getRequisitionDetails(rid);
        }
    }
}
