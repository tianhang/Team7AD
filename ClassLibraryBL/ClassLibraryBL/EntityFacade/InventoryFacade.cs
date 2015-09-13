using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.EntityFacade
{
    public class InventoryFacade
    {
        LogicUnivSystemEntities cntx = new LogicUnivSystemEntities();
        public Object getInventoryData()
        {
            var data = from f in cntx.items
                       join c in cntx.categories on f.categoryId equals c.categoryId
                       
                       
                       select new { f.itemId, c.categoryName, f.description, f.balance, f.unit, f.reorderlevel};
            Object o= data.ToList();
            return o;         
        }

        public Object getLowBalanceData()
        {
            var data = from f in cntx.items
                       join c in cntx.categories on f.categoryId equals c.categoryId
                       
                      
                       where f.balance<=f.reorderlevel
                       select new { f.itemId, c.categoryName, f.description, f.balance, f.unit, f.reorderlevel };
            Object o = data.ToList();
            return o;
        }

    }
}
