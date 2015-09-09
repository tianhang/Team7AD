using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.EntityFacade
{
    class RequisiitonFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public List<requisition> getPendingRequisition(User u)
        {
            var t = (from x in luse.requisitions
                     where x.status == "Pending" 
                     select x).ToList();
            return t;
        }

        public List<RequisitionDetails> getRequisitionDetails(string rid)
        {
           int reqid = int.Parse(rid);
           List<RequisitionDetails> rd = new List<RequisitionDetails>();
           var ilist = (from x in luse.requisitions
                         from y in luse.items
                         from z in luse.requsiiton_item
                         from l in luse.departments
                         from m in luse.collectionPoints
                         from n in luse.users
                         where x.requisitionId == z.requisitionId && y.itemId == z.itemId && x.requisitionId == reqid && x.departmentId == l.departmentId && x.userId == n.userId && l.collectionPointId == m.collectionPointId 
                         select new RequisitionDetails {
                           Description = y.description, 
                           Number = z.requestQty,
                           Unit = y.unit,
                           Status = x.status,
                           CollectionPoint = m.address,
                           ReqDate = x.requestDate,
                           Name = n.name,
                           photourl = "../images/" + y.description.Trim() + ".jpg"
                         }).ToList();
            return ilist;

        }

        public void approveRequisition(int x)
        {
            var req = (from y in luse.requisitions
                       where y.requisitionId == x
                        select y).First();
            req.status = "Approved";
            luse.SaveChanges();
        }
        public void rejectRequisition(int x,string reason)
        {
            var req = (from y in luse.requisitions
                       where y.requisitionId == x
                       select y).First();
            req.status = "Rejected";
            req.rejectReason = reason;
            luse.SaveChanges();

           

        }
        public List<requisition> getPreRequisition(User u)
        {
            var t = (from x in luse.requisitions
                     where x.status == "Approved"
                     select x).ToList();
            return t;
        }


        public List<requisition> getAllRequisitionEmployee(User u)
        {
            var t = (from a in luse.requisitions
                     where a.userId == u.UserId
                     select a).ToList();
            return t;
        }

        public List<requisition> getPendingRequisitionEmployee(User u)
        {
            var t = (from a in luse.requisitions
                     where a.userId == u.UserId && a.status.Trim() == "Pending"
                     select a).ToList();
            return t;
        }

        public void addRequisition(User u, List<ShoppingItem> sclist)
        {
            requisition re = new requisition();
            re.departmentId = u.DepartmentId;
            re.userId = u.UserId;
            re.rejectReason = null;
            re.status = "Pending";
            re.requestDate = DateTime.Now;
            luse.requisitions.Add(re);
            luse.SaveChanges();
            for (int i = 0; i < sclist.Count; i++) {
                requsiiton_item reItem = new requsiiton_item();
                reItem.requisitionId = re.requisitionId;
                reItem.itemId = sclist[i].ItemId;
                reItem.requestQty = sclist[i].Amount;
                luse.requsiiton_item.Add(reItem);
                luse.SaveChanges();

            }


        }




        


    }
}
