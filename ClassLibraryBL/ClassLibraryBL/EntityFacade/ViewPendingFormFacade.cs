using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL;
namespace ClassLibraryBL.EntityFacade
{
    public class ViewPendingFormFacade
    {
        LogicUnivSystemEntities lg = new LogicUnivSystemEntities();

        public Object getAllPendingItems()
        {
            var data = from i in lg.items
                       join ri in lg.requsiiton_item on i.itemId equals ri.itemId
                       join r in lg.requisitions on ri.requisitionId equals r.requisitionId
                       join pi in lg.purchase_item on i.itemId equals pi.itemId
                       join p in lg.purchases on pi.purchaseId equals p.purchaserId
                       where r.status == "Pending"
                       select new { i.description, ri.requestQty, p.status } into newgg
                       group newgg by new { newgg.description, newgg.status } into grouppings
                       select new
                       {
                           GroupId=grouppings.Key.description,
                           RequestQTY=grouppings.Sum(g=>g.requestQty),
                           Status=grouppings.Key.status
                       };
            return data.ToList();
        }

        public Object getListByDept(String selectedValue)
        {
            var data = (from r in lg.requisitions
                        join d in lg.departments on r.departmentId equals d.departmentId
                        where r.status == "Pending"
                        where d.deptName == selectedValue
                        select r.requisitionId).Distinct();
            try
            {
            List<int> l = data.ToList();
            int receive = l[0];
            int receiveMax = l.Max();
            
                var data2 = from r in lg.requisitions
                           where r.requisitionId >= receive
                           where r.requisitionId <= receiveMax
                           select r;
                return data2.ToList();
            }
            catch { }
            return null;
        }

        public Object getListByDeptDetail(String rId)
        {
            int intRid = Convert.ToInt32(rId);
            var data = from i in lg.items
                       join ri in lg.requsiiton_item on i.itemId equals ri.itemId
                       join r in lg.requisitions on ri.requisitionId equals r.requisitionId
                       join pi in lg.purchase_item on i.itemId equals pi.itemId
                       join p in lg.purchases on pi.purchaseId equals p.purchaserId
                       join c in lg.categories on i.categoryId equals c.categoryId
                       where r.status == "Pending"
                       where r.requisitionId==intRid
                       select new {i.itemId,c.categoryName,i.description,ri.requestQty,i.balance,p.status };
            return data.ToList();
        }

    }
}
