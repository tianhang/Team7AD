using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;

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
        /////mobile/////////////////////////////////////////////////////
        public itemEntity getItemById(int itemId)
        {
            var data = from f in cntx.items
                       join c in cntx.categories on f.categoryId equals c.categoryId
                       join g in cntx.item_supplier on f.itemId equals g.itemId
                       join k in cntx.suppliers on g.supplierId equals k.supplierId
                       where f.itemId == itemId
                       select new itemEntity
                       {
                           itemId = f.itemId,
                           categoryName = c.categoryName,
                           description = f.description,
                           balance = f.balance,
                           unit = f.unit,
                           reorderlevel = f.reorderlevel,
                           reorderQty = f.reorderQty,
                           companyName = k.compName,
                           binNumber = f.binNumber,
                           status = f.status
                       };
            return data.ToList().First();
        }

        public List<itemEntity> getItemByName(string name)
        {
            var data = from f in cntx.items
                       join c in cntx.categories on f.categoryId equals c.categoryId
                       join g in cntx.item_supplier on f.itemId equals g.itemId
                       join k in cntx.suppliers on g.supplierId equals k.supplierId
                       where f.description.Contains(name)
                       select new itemEntity
                       {
                           itemId = f.itemId,
                           categoryName = c.categoryName,
                           description = f.description,
                           balance = f.balance,
                           unit = f.unit,
                           reorderlevel = f.reorderlevel,
                           reorderQty = f.reorderQty,
                           companyName = k.compName,
                           binNumber = f.binNumber,

                           status = f.status
                       };
            return data.ToList();
        }

    }
}
