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
        }
        public void formorder(user u)
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
                po.userId = u.userId;
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
    }
}
