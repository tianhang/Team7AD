using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.EntityFacade
{
    public class DisbursementFacade
    {
        LogicUnivSystemEntities cntx = new LogicUnivSystemEntities();
        public List<DisbursementList> getDisbursementList(User u)
        {

            var data = (from x in cntx.items
                        from y in cntx.disbursements
                        from z in cntx.disbursement_item
                        from l in cntx.departments
                        from m1 in cntx.collectionPoints
                        where l.collectionPointId == m1.collectionPointId && y.departmentId == l.departmentId && y.disbursementId == z.disbursementId && x.itemId == z.itemId && y.status == "WaitingCollection" && y.departmentId == u.DepartmentId
                        select new DisbursementList
                        {
                            CollectionDate = y.collectDate,
                            DisbusementId = y.disbursementId,
                            Description = x.description,
                            CollectQty = z.collectQty,
                            Photourl = "../images/" + x.description.Trim() + ".jpg",
                           ContacName = l.contacName,
                           Address= m1.address,
                          Time = m1.time
                        }
                         ).ToList();
            int m = data.Count();
            return data;
        }
                        public void confirmDisbursement()
                        {

                            try
                            {
                                var data = (from x in cntx.items
                                            from y in cntx.disbursements
                                            from z in cntx.disbursement_item
                                            where y.disbursementId == z.disbursementId && x.itemId == z.itemId && y.status == "WaitingCollection"
                                            select y).First();
                                var x2 = data.disbursementId;


                                var update = (from x in cntx.disbursements
                                              where x.disbursementId == x2
                                              select x).FirstOrDefault();
                                update.status = "Completed";
                                cntx.SaveChanges();
                                }
                                catch (Exception eew)
                                {
                            }
                        }

                        public List<DisbursementList> getHisDisbursementList(User u)
                        {
                            var data = (
                                        from y in cntx.disbursements
                                        from l in cntx.departments
                                        from m1 in cntx.collectionPoints
                                        where l.collectionPointId == m1.collectionPointId && y.departmentId == l.departmentId && y.status == "Completed" && y.departmentId == u.DepartmentId
                                        select new DisbursementList
                                        {
                                            DisbusementId = y.disbursementId,
                                            Status = y.status,
                                            Address = m1.address,
                                            CollectionDate = y.collectDate
                                        }
                         ).ToList();
                            //var data = (from x in cntx.disbursements
                            //            where x.status == "Completed"
                            //            select x).ToList();


                            return data;
                        }

                        public List<DisbursementList> getHisDetailDisbursementList(User u, int p)
                        {
                            var data = (from x in cntx.items
                                        from y in cntx.disbursements
                                        from z in cntx.disbursement_item
                                        from l in cntx.departments
                                        from m1 in cntx.collectionPoints
                                        where l.collectionPointId == m1.collectionPointId && y.departmentId == l.departmentId && y.disbursementId == z.disbursementId && x.itemId == z.itemId && y.status == "Completed" && y.departmentId == u.DepartmentId && y.disbursementId == p
                                        select new DisbursementList
                                        {
                                            CollectionDate = y.collectDate,
                                            DisbusementId = y.disbursementId,
                                            Description = x.description,
                                            CollectQty = z.collectQty,
                                            Photourl = "../images/" + x.description.Trim() + ".jpg",
                                            ContacName = l.contacName,
                                            Address = m1.address,
                                            Time = m1.time
                                        }
                        ).ToList();
                            int m = data.Count();
                            return data;
                        }

        //Du du

                        //This method belongs to "CheckCurrentDisbursementList.aspx"
                        public Object getCurrentList(String value)
                        {

                            var data = from f in cntx.disbursements
                                       join d in cntx.departments on f.departmentId equals d.departmentId
                                       where d.deptName == value && f.status == "WaitingCollection"
                                       select new { f.disbursementId, d.deptName, f.collectDate, f.status };


                            Object o = data.ToList();
                            return o;
                        }

                        //The following two methods belong to "CurrentDisbursementDetailItem.aspx"
                        public Object getDetailedItem(int session)
                        {
                            var data = from f in cntx.disbursements
                                       join fi in cntx.disbursement_item on f.disbursementId equals fi.disbursementId
                                       where f.disbursementId == session
                                       join i in cntx.items on fi.disburse_itemId equals i.itemId
                                       orderby fi.collectQty
                                       select new { fi.collectQty, i.description };
                            return data.ToList();

                        }

                        public Object getCollectionPoint(String value)
                        {
                            var data = from d in cntx.departments
                                       join c in cntx.collectionPoints on d.collectionPointId equals c.collectionPointId
                                       where d.deptName == value
                                       select c.address;
                            return data.FirstOrDefault();
                        }

                        public Object getAllHistoryList()
                        {
                            var data = from d in cntx.disbursements
                                       join dept in cntx.departments on d.departmentId equals dept.departmentId
                                       select new { d.disbursementId, dept.deptName, d.collectDate, d.status };
                            return data.ToList();
                        }

                        public Object getSelectedHistoryList(DateTime begin, DateTime end)
                        {
                            var data = from d in cntx.disbursements
                                       join dept in cntx.departments on d.departmentId equals dept.departmentId
                                       where d.collectDate >= begin
                                       where d.collectDate <= end
                                       select new { d.disbursementId, dept.deptName, d.collectDate, d.status };
                            return data.ToList();
                        }

                        public Object getHistoryListDetails(String disbursementId)
                        {
                            int disId = Convert.ToInt32(disbursementId);
                            var data = from d in cntx.disbursements
                                       join di in cntx.disbursement_item on d.disbursementId equals di.disbursementId
                                       join i in cntx.items on di.itemId equals i.itemId
                                       where d.disbursementId == disId
                                       select new { i.description, di.collectQty };
                            return data.ToList();
                        }
        //Du du

    }
}
