using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ViewDisbursementListController
    {
        DisbursementFacade disF = new DisbursementFacade();
        public Object getCurrentList(String value)
        {
            return disF.getCurrentList(value);
        }

        public Object getDetailedItem(int session)
        {
            return disF.getDetailedItem(session);
        }

        public Object getCollectionPoint(String value)
        {
            return disF.getCollectionPoint(value);
        }

        public Object getAllHistoryList()
        {
            return disF.getAllHistoryList();
        }

        public Object getSelectedHistoryList(DateTime begin,DateTime end)
        {
            return disF.getSelectedHistoryList(begin, end);
        }
        
        public Object getHistoryListDetails(String disbursementId)
        {
            return disF.getHistoryListDetails(disbursementId);
        }
    }
}
