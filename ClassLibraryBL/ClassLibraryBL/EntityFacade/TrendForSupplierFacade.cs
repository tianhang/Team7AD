using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.EntityFacade
{
    public class TrendForSupplierFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public List<TrendForSupplierEntity> GetPrice(string department, string category, int month)
        {

            var query = from r in luse.requisitions
                        from ri in luse.requsiiton_item
                        from i in luse.items
                        from c in luse.categories
                        from d in luse.departments
                        from s in luse.suppliers
                        from si in luse.item_supplier
                        where (i.itemId == ri.itemId)
                        && (r.requisitionId == ri.requisitionId)
                        && (d.departmentId == r.departmentId)
                        && (c.categoryId == i.categoryId)
                        && (s.supplierId == si.supplierId)
                        && (si.itemId == i.itemId)
                        && (si.priority == 1)
                        && (r.requestDate.Month == month)                     
                        && (d.deptName == department)
                        && (c.categoryName == category)
                       

                        select new TrendForSupplierEntity
                        {
                            requestQty = ri.requestQty,
                            price = si.price,
                            deptName = d.deptName,
                            categoryName = c.categoryName,
                            requestDate = r.requestDate
                        };

            var query1 = (from r in query
                          orderby r.categoryName
                          group query by r.categoryName into grp
                          let sum = query.Where(x => x.categoryName == grp.Key).Sum(x => x.requestQty)
                          select new
                          {
                              requestQty = sum,
                              categoryName = grp.Key
                          }).ToList().Select(y =>
             new TrendForSupplierEntity
             {
                 requestQty = y.requestQty,
                 categoryName = y.categoryName,
                 requestDate = query.First().requestDate ,
                 categoryCost = query.First().price*y.requestQty
             });
            return query1.ToList();   
        }
    }
}
