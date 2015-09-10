using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.EntityFacade
{
    public class RequisitionTrendFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();
        public List<string> GetCategoryName() {
            var query = from c in luse.categories
                        select c.categoryName;
            return query.ToList();
        }
    }
}
