using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using System.Data;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ProcessDiscrepancyController
    {
        DiscrepancyFacade df = new DiscrepancyFacade();
        public Object getCategory()
        {
            return df.getCategory();
        }
        public void confirmOperation(DataTable dt,User u)
        {
            df.confirmOperation(dt,u);
        }

        public Object getCategoryItem(String transfer)
        {
            return df.getCategoryItem(transfer);
        }

        public String getUnit(String transfer)
        {
            return df.getUnit(transfer);
        }

        public Object ListHistory()
        {
            return df.ListHistory();
        }

        public Object ListSelectedHistory(DateTime begin, DateTime end)
        {
            return df.ListSelectedHistory(begin,end);
        }

        public Boolean validateBlank(String cIn,String cOut)
        {
            return df.validateBlank(cIn, cOut);
        }

        public Object getDiscrepanyDetail(String id)
        {
            return df.getDiscrepanyDetail(id);
        }
        //////////////////////mobile//////////////////
        public List<discrepancyEntity> ListHistory2()
        {
            return df.ListHistory2();
        }

        public List<discrepancyDetailEntityMobile> getDiscrepanyDetail2(string id)
        {
            return df.getDiscrepanyDetail2(id);
        }

        public void confirmOperation2(List<discrepancyDetailEntityMobile> ddem, User u)
        {
            df.confirmOperation2(ddem, u);
        }
    }
}
