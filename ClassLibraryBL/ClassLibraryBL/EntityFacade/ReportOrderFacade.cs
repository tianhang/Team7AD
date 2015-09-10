using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.EntityFacade
{
    public class ReportOrderFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public List<ReportOrderEntity> GetRequestQty(string categoryName, int month)
        {
            var query = from c in luse.categories
                        from i in luse.items
                        from pi in luse.purchase_item
                        from p in luse.purchases
                        where (c.categoryId == i.categoryId)
                        && (i.itemId == pi.itemId)
                        && (pi.purchaseId == p.purchaserId)
                        && (p.purchaseDate.Month == month)
                        && (c.categoryName == categoryName)
                        select new ReportOrderEntity
                        {
                            categoryName = c.categoryName,
                            requestQty = pi.requestQty,
                            purchaseDate = p.purchaseDate
                        };

            var query1 = (from q in query
                          orderby q.categoryName
                          group query by q.categoryName into grp
                          let sum = query.Where(x => x.categoryName == grp.Key).Sum(x => x.requestQty)
                          select new
                          {
                              requestQty = sum,
                              categoryName = grp.Key
                          }).ToList().Select(y =>
                                  new ReportOrderEntity
                              {
                                  requestQty = y.requestQty,
                                  categoryName = y.categoryName,
                                  purchaseDate = query.First().purchaseDate
                              });
            return query1.ToList();
        }
    }
}
