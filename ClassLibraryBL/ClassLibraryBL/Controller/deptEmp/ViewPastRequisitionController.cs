using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Controller.deptEmp
{
   public  class ViewPastRequisitionController
    {

        RequisiitonFacade refacade = new RequisiitonFacade();
        public List<requisition> AllPastRequisition(User u)
        {
            return refacade.getAllRequisitionEmployee(u);

        }

    }
}
