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
                       join g in cntx.item_supplier on f.itemId equals g.itemId
                       join k in cntx.suppliers on g.supplierId equals k.supplierId
                       select new { f.itemId, c.categoryName, f.description, f.balance, f.unit, f.reorderlevel, k.compName };
            Object o= data.ToList();
            return o;         
        }

        public Object getLowBalanceData()
        {
            var data = from f in cntx.items
                       join c in cntx.categories on f.categoryId equals c.categoryId
                       join g in cntx.item_supplier on f.itemId equals g.itemId
                       join k in cntx.suppliers on g.supplierId equals k.supplierId
                       where f.balance<=f.reorderlevel
                       select new { f.itemId, c.categoryName, f.description, f.balance, f.unit, f.reorderlevel, k.compName };
            Object o = data.ToList();
            return o;
        }

    }
}
