using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.EntityFacade
{
    public class RequestThreeMonthsEntityFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public List<RequestThreeMonthsEntity> GetRequestThreeMonthsEntity(int month,string department) {

            var query = from i in luse.items
                        from ri in luse.requsiiton_item
                        from r in luse.requisitions
                        from d in luse.departments
                        from c in luse.categories
                        where (i.itemId == ri.itemId)
                        && (r.requisitionId == ri.requisitionId)
                        && (d.departmentId == r.departmentId)
                        && (c.categoryId == i.categoryId)
                        && (r.requestDate.Month == month)
                        && (d.deptName == department)
                        
                        select new RequestThreeMonthsEntity
                        {     
                            requestQty = ri.requestQty,
                            requisitionId = r.requisitionId,
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
                         new RequestThreeMonthsEntity
                         {                          
                             requestQty = y.requestQty,                            
                             categoryName = y.categoryName,
                             requestDate = query.First().requestDate
                         });
            return query1.ToList();       
        }

    }
}
