using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using ClassLibraryBL;
namespace ClassLibraryBL.EntityFacade
{
    public class SupplierFacade
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();
        public List<supplier> checksupplierList()
        {
            var n = from a in ctx.suppliers
                    select a;
            return n.ToList();
        }
        public void editsupplier(int id, string name, string contactname, string phonenNO, string faxno, string address, string gst)
        {
         supplier ac = (from a in ctx.suppliers
                              where a.supplierId == id
                              select a).SingleOrDefault();
          ac.compName = name;
          ac.contactName = contactname;
          ac.phoneNo = phonenNO;
          ac.faxNo = faxno;
          ac.address = address;
          ac.GST_RegistrationNo = gst;
          ctx.SaveChanges();
        }
        public void deletesupplier(int id)
        {
            supplier ac = (from a in ctx.suppliers
                           where a.supplierId == id
                           select a).SingleOrDefault();
            ctx.suppliers.Remove(ac);
            ctx.SaveChanges();
        }
        public void addsupplier(string name, string contactname, string phonenNO, string faxno, string address, string gst)
        {
            supplier ac = new supplier();
            ac.compName = name;
            ac.contactName = contactname;
            ac.phoneNo = phonenNO;
            ac.faxNo = faxno;
            ac.address = address;
            ac.GST_RegistrationNo = gst;
            ctx.suppliers.Add(ac);
            ctx.SaveChanges();
        }
        public List<SupplieritemMix> searchbydescription(string keyword, int id)
        {
            var n = from a in ctx.item_supplier
                    join b in ctx.items on a.itemId equals b.itemId
                    where b.description.Contains(keyword) && a.supplierId == id
                    select new SupplieritemMix
                    {
                        Itemdescription = b.description,
                        itemid = b.itemId,
                        Unit = b.unit,
                        price = a.price.Value

                    };
            return n.ToList();

        }
        public List<SupplieritemMix> showitems(int id)
        {
            var n = from a in ctx.item_supplier
                    join b in ctx.items on a.itemId equals b.itemId
                    where  a.supplierId == id
                    select new SupplieritemMix
                    {
                        Itemdescription = b.description,
                        itemid = b.itemId,
                        Unit = b.unit,
                        price = a.price.Value

                    };
            return n.ToList();
        }
        public void editprice(int itemid,int supplierid,int price) {
            item_supplier s = (from a in ctx.item_supplier
                              where (a.itemId == itemid) && (a.supplierId == supplierid)
                              select a).SingleOrDefault();
            s.price = price;
            ctx.SaveChanges();
        }
        public SupplieritemMix showsingleitem(int itemid, int supplierid)
        {
            var n = from a in ctx.item_supplier
                    from b in ctx.items 

                    where ((a.itemId==itemid) && (a.supplierId==supplierid) &&(a.itemId==b.itemId))
                    select new SupplieritemMix
                    {
                        Itemdescription = b.description,
                        itemid = a.itemId.Value,
                        Unit = b.unit,
                        price = a.price.Value

                    };
            return n.SingleOrDefault();
        }
        public supplier findsupplier(int s)
        {
            var n = from a in ctx.suppliers
                    where a.supplierId == s
                    select a;
            return n.SingleOrDefault();
        }
    }
}
