using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.Controller.stockManager
{

    public class ApproveStockAdjustmentController
    {

        DiscrepancyFacade dis = new DiscrepancyFacade();
        public List<DiscrepancyMixBean> checkdiscrepancy()
        {

            return dis.getpendingdiscrepancy();
        }
        public void apporvediscrepancy(int s)
        {
            dis.approvediscrepancy(s);
        }
        public void rejectdiscrepancy(int s)
        {
            dis.rejectdiscrepancy(s);
        }
        public List<DiscrepancyItemMix> checkdiscrepancyitem(int s)
        {
            return dis.getdiscrepancyitem(s);
        }

    }
}
