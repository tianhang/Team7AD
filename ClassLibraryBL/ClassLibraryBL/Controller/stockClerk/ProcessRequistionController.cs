using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ProcessRequistionController
    {
        RequisiitonFacade requisitionData;
        public ProcessRequistionController()
        {
            requisitionData = new RequisiitonFacade();
        }

        public Object getRequisitionData()
        {
            return requisitionData.getRequisition();
        }
    }
}
