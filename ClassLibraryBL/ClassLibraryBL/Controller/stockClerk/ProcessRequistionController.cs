using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
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

        ////////////////////////////////mobile/////////////////////////////////////////////////////
        public List<requisitionEntity> getAllRequisitionData()
        {
            return requisitionData.getRequisition2();
        }

        public List<requisitionEntity> getPendingRequisitionData()
        {
            return requisitionData.getPendingRequisition();
        }
        public List<requisitionEntity> getWaitingRequisitionData()
        {
            return requisitionData.getWaitingRequisition();
        }
        public List<requisitionEntity> getCompletedRequisitionData()
        {
            return requisitionData.getCompletedRequisition();
        }

    }
}
