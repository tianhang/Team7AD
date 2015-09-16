using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller;
namespace ClassLibraryBL.EntityFacade
{
    public class PurchaseOrderFacade
    {

        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();
        public purchase findpurchaseorder(int s)
        {
            var n = from a in ctx.purchases
                    where a.purchaserId == s
                    select a;
            return n.SingleOrDefault();
        }
        public void confirmorder(int s)
        {
            var n = from a in ctx.purchase_item
                    from b in ctx.items
                    where (a.itemId == b.itemId) && (a.purchaseId == s)
                    select b;
            var x = from a in ctx.purchases
                    where a.purchaserId == s
                    select a;
            var w = from a in ctx.purchase_item
                    from b in ctx.items
                    where (a.itemId == b.itemId) && (a.purchaseId == s)
                    select a;
            foreach (item t in n.ToList())
            {
                foreach (purchase_item pt in w.ToList())
                {
                    if (t.itemId == pt.itemId)
                    {
                        t.balance += pt.requestQty;
                        t.status = "sufficient";
                    }
                }
            }
            purchase o = x.SingleOrDefault();
            o.status = "Confirmed";
            ctx.SaveChanges();


            var purchaseitemlist = (from x1 in ctx.purchases
                                    from y1 in ctx.purchase_item
                                    from z1 in ctx.items
                                    where x1.purchaserId == s && x1.purchaserId == y1.purchaseId && z1.itemId == y1.itemId
                                    select z1).ToList();
            revalidationForReq(purchaseitemlist);
        }

        //Purchase Order Confirm method. To validate Waiting order

        public void revalidationForReq(List<item> purchaseitemlist)
        {
            
            foreach(item x in purchaseitemlist){
                int totalItemQuantity = 0;
            var findRelevantRequistion = (from x1 in ctx.items
                                            from y1 in ctx.requisitions
                                            from z1 in ctx.requsiiton_item
                                            where x1.itemId == z1.itemId && y1.requisitionId==z1.requisitionId &&  y1.status == "PendingForOrder" && x1.itemId == x.itemId
                                            select y1).ToList();
            foreach (requisition req in findRelevantRequistion)
            {
                  var t2 = (from x1 in ctx.items
                         from y1 in ctx.requisitions
                         from z1 in ctx.requsiiton_item
                         where x1.itemId == x.itemId && x1.flag == "needReorderSoon" && y1.requisitionId == req.requisitionId && x1.itemId == z1.itemId && y1.requisitionId == z1.requisitionId
                         select z1.requestQty).FirstOrDefault();
                  totalItemQuantity = totalItemQuantity + t2;
            }

            var tiq = (from x2 in ctx.items
                       where x2.itemId == x.itemId
                       select x2).First();


            if (totalItemQuantity >= tiq.balance)
            {
                foreach (requisition req in findRelevantRequistion)
                {
                    var t2 = (from x1 in ctx.items
                              from y1 in ctx.requisitions
                              from z1 in ctx.requsiiton_item
                              where x1.flag == "needReorderSoon" && y1.requisitionId == req.requisitionId && x1.itemId == z1.itemId && y1.requisitionId == z1.requisitionId
                              select x1.itemId);
                    int flag = t2.Count();

                    if (flag < 2)
                    {
                        var m = (
                               from y1 in ctx.requisitions
                               where y1.requisitionId == req.requisitionId
                               select y1).First();
                        m.status = "WaitingCollection";

                        //add disbursement 
                        // date and time
                        var coltime = (from m2 in ctx.collectionPoints
                                       from m4 in ctx.departments
                                       where m2.collectionPointId == m4.collectionPointId && m4.departmentId == req.departmentId
                                       select new { m2, m4 }).First();
                        string collectiontime = coltime.m2.time;
                        DateTime dt = DateTime.Now;
                        int weeknow = Convert.ToInt32(DateTime.Now.DayOfWeek);
                        int dayspan = (-1) * weeknow + 5;
                        DateTime dt2 = dt.AddMonths(1);
                        DateTime friday = DateTime.Now.AddDays(dayspan);
                        string nhd = (friday.ToShortDateString() + " " + collectiontime);
                        DateTime myDatefriday = Convert.ToDateTime(nhd);
                        // date and time

                        /// update disbursement list
                        disbursement di = new disbursement();
                        di.departmentId = req.departmentId;
                        di.collectDate = myDatefriday;
                        di.status = "WaitingCollection";
                        ctx.disbursements.Add(di);
                        ctx.SaveChanges();
                        //updte disbursement list 



                        //get particular requistion item list
                  List<itemValidate> itemidlistAvailable = new List<itemValidate>();
            var n = (from x1 in ctx.requisitions
                     from y in ctx.items
                     from z in ctx.requsiiton_item
                     where x1.requisitionId == z.requisitionId && y.itemId == z.itemId && x1.requisitionId == req.requisitionId
                     select new itemValidate
                     {
                         Itemid = z.itemId,
                         RequestQty = z.requestQty,
                         StockBalance = y.balance,
                         Itemreorderlevel = y.reorderlevel
                     }).ToList();
                        itemidlistAvailable = n;
                        //get particular requistion item list

                        foreach (itemValidate mx in itemidlistAvailable)
                        {
                            disbursement_item disbi = new disbursement_item();
                            disbi.disbursementId = di.disbursementId;
                            disbi.itemId = mx.Itemid;
                            disbi.collectQty = mx.RequestQty;
                            ctx.disbursement_item.Add(disbi);
                        }



                        ///update disbursement list 

                        //add disbursement


                    }
                    var t3 = (from x1 in ctx.items
                              from y1 in ctx.requisitions
                              from z1 in ctx.requsiiton_item
                              where x1.itemId == x.itemId && x1.flag == "needReorderSoon" && y1.requisitionId == req.requisitionId && x1.itemId == z1.itemId && y1.requisitionId == z1.requisitionId
                              select z1.requestQty).First();
                    var u = (from x1 in ctx.items
                             where x1.itemId == x.itemId
                             select x1).First();
                    u.balance = u.balance - t3;
                }
                var m3 = (from z1 in ctx.items
                          where z1.itemId == x.itemId
                          select z1).First();
                m3.flag = "NULL";
                ctx.SaveChanges();
                 }
            }
        }

        //


        public void formorder(User u)
        {
            var n = from a in ctx.items
                    where (a.balance < a.reorderlevel) && (a.status == "stockout")
                    from c in ctx.item_supplier
                    where a.itemId == c.itemId
                    from b in ctx.suppliers
                    where b.supplierId == c.supplierId && (c.priority == 1)
                    select b;
            var d = from a in ctx.items
                    where (a.balance < a.reorderlevel) && (a.status == "stockout")
                    from c in ctx.item_supplier
                    where a.itemId == c.itemId
                    from b in ctx.suppliers
                    where b.supplierId == c.supplierId && (c.priority == 1)
                    select c;
            List<supplier> s = n.ToList();
            List<item_supplier> ls = d.ToList();
            foreach (supplier x in s)
            {
                purchase po = new purchase();
                po.supplierId = x.supplierId;
                po.purchaseDate = DateTime.Today.Date;
                po.userId = u.UserId;
                po.expectedDeliveryDate = DateTime.Today.Date.AddDays(14);
                po.status = "waiting";
                ctx.purchases.Add(po);
                ctx.SaveChanges();
                foreach (item_supplier i in ls)
                {
                    if (i.supplierId == x.supplierId)
                    {
                        var y = from a in ctx.items
                                where a.itemId == i.itemId 
                                select a;
                        item item = y.SingleOrDefault();
                        item.status = "ordering";
                        purchase_item pitem = new purchase_item();
                        pitem.purchaseId = po.purchaserId;
                        pitem.itemId = i.itemId.Value;
                        pitem.requestQty = item.reorderlevel;
                        pitem.supplierid = po.supplierId;
                        ctx.purchase_item.Add(pitem);
                        ctx.SaveChanges();
                    }
                }
            }
        }
        public List<Purchaseitem111> showpurchaseitems(purchase p)
        {
            int x1 = p.purchaserId;
            var n = from a in ctx.items
                    from b in ctx.purchase_item
                    from z in ctx.purchases
                    from c in ctx.item_supplier
                    from y in ctx.suppliers
                    where a.itemId == b.itemId && b.purchaseId == z.purchaserId && a.itemId == c.itemId && c.supplierId == y.supplierId && z.purchaserId == p.purchaserId && b.supplierid == y.supplierId
                    select new Purchaseitem111
                    {
                        Itemcode = a.itemId,
                        Description = a.description,
                        Quantity = b.requestQty,
                        price = c.price.Value,
                        Amount = c.price.Value * b.requestQty
                    };
            return n.ToList();
        }
       
        public void cancel(int s)
        {
            var x = from a in ctx.purchases
                    where a.purchaserId == s
                    select a;
            purchase o = x.SingleOrDefault();
            o.status = "Canceled";
            ctx.SaveChanges();
        }
        public List<string> getcompanyname(int k, int i, int x)
        {
            List<string> ls = new List<string>();
            var l = (from a in ctx.purchases
                     join b in ctx.purchase_item on a.purchaserId equals b.purchaseId
                     join c in ctx.items on b.itemId equals c.itemId
                     join d in ctx.item_supplier on c.itemId equals d.itemId
                     join e in ctx.suppliers on d.supplierId equals e.supplierId
                     where (e.supplierId != i) && (b.itemId == k) && (b.purchaseId == x)
                     select e.compName).Distinct();

            return l.ToList();
        }
        public void changesupplier(int itemcode,int purchaseid,string comname,string userid ){
            var n = from a in ctx.purchase_item
                    from b in ctx.purchases
                    where (a.itemId == itemcode) && (b.purchaserId == purchaseid)
                    &&(a.purchaseId==b.purchaserId)
                    select a;
            purchase_item pt=n.SingleOrDefault();
            int x = pt.itemId;
            ctx.purchase_item.Remove(pt);
            var l = from a in ctx.suppliers
                    where a.compName == comname
                    select a.supplierId;
            int ls = l.FirstOrDefault();
            purchase po = new purchase();
            po.supplierId = ls;
            po.purchaseDate = DateTime.Today.Date;           
            po.expectedDeliveryDate = DateTime.Today.Date.AddDays(14);
            po.status = "waiting";
            po.userId = userid;
            ctx.purchases.Add(po);
            var xo = from a in ctx.items
                     where a.itemId == x
                     select a;
            item xx = xo.SingleOrDefault();
            purchase_item npt = new purchase_item();
            npt.purchaseId = po.purchaserId;
            npt.itemId = xx.itemId;
            npt.requestQty = xx.reorderQty;
            npt.supplierid = ls;
            ctx.purchase_item.Add(npt);
            ctx.SaveChanges();
        }
        public void additems(int itemcode, int supplierid,int purchaseid,int qt)
        {
            purchase_item pitem = new purchase_item();
            pitem.purchaseId = purchaseid;
            pitem.itemId = itemcode;
            pitem.requestQty = qt;
            pitem.supplierid = supplierid;
            ctx.purchase_item.Add(pitem);
            ctx.SaveChanges();
        }
        public List<string> showitemsbysupplier(int supplierid)
        {
            var n = from a in ctx.items
                    from b in ctx.item_supplier
                    from c in ctx.suppliers
                    where a.itemId == b.itemId && b.supplierId == c.supplierId && c.supplierId == supplierid
                    select a.description;
            return n.ToList();
        }
        public int finditemcode(string description, int supplierid)
        {
            var n = from a in ctx.items
                    from b in ctx.item_supplier
                    from c in ctx.suppliers
                    where a.itemId==b.itemId && b.supplierId == c.supplierId && c.supplierId == supplierid
                    && a.description==description
                    select a.itemId;
            return n.SingleOrDefault();
        }
        public void deleteitem(int itemcode, int supplierid, int purchaseid) 
        {
            var n = from a in ctx.purchase_item
                    where a.purchaseId == purchaseid && a.itemId == itemcode && a.supplierid == supplierid
                    select a;
            ctx.purchase_item.Remove(n.FirstOrDefault());
            ctx.SaveChanges();
        }
        public purchase newpurchase(int supplierid,string userid)
        {
            purchase po = new purchase();
            po.supplierId = supplierid;
            po.purchaseDate = DateTime.Today.Date;
            po.expectedDeliveryDate = DateTime.Today.Date.AddDays(14);
            po.status = "waiting";
            po.userId = userid;
            ctx.purchases.Add(po);
            ctx.SaveChanges();
            return po;
        }
        public int findsupplier(int itemcode)
        {
            var n = from a in ctx.items
                    from b in ctx.item_supplier
                    from c in ctx.suppliers
                    where a.itemId == itemcode && a.itemId == b.itemId && c.supplierId == b.supplierId
                    && b.priority == 1
                    select c.supplierId;
            int x = Convert.ToInt32(n.SingleOrDefault());
            return x ;
        }
        /////////////////mobile///////////////////////////////
        public List<purchaseEntity> getPurchaseOrder()
        {
            var n = from a in ctx.purchases
                    select new purchaseEntity
                    {
                        purchaserId = a.purchaserId,
                        supplierId = a.supplierId,
                        purchaseDate = a.purchaseDate,
                        userId = a.userId,
                        expectedDeliveryDate = a.expectedDeliveryDate,
                        status = a.status
                    };
            return n.ToList();

        }
    }
}
