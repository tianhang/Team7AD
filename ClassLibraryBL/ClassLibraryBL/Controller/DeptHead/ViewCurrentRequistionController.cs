using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.DeptHead
{
    public class ViewCurrentRequistionController
    {
        RequisiitonFacade rf = new RequisiitonFacade();
        public List<requisition> getPendingRequisition(User u)
        {
            return rf.getPendingRequisition(u);
        }


    }
}
