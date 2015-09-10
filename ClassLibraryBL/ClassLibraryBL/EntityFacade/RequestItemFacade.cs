using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.EntityFacade
{
    public class RequestItemFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public RequestItem GetRequestItem()
        {
            RequestItem requestItem = new RequestItem();

            //var query = from 
            return requestItem;
        }

        public List<RequestItem> GetCategoryName()
        {
            var query = from i in luse.categories
                        select new RequestItem
                        { 
                            CategoryName=i.categoryName
                        };
            return query.ToList();
        }

        public int GetCategorSum(String categoryName) { 
            var query1 = from c in luse.categories
                         where c.categoryName == categoryName
                         select c.categoryId;
            int categoryId = query1.First();
            var query = from i in luse.items
                        where i.categoryId == categoryId
                        select i.reorderQty;
            var QtySum = query.ToList().Sum().ToString();
            return Convert.ToInt16(QtySum);
        }
    }
}
