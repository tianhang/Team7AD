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
                                catch (Exception ex)
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
    }
}
