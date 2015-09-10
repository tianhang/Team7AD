using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.Controller.stockClerk
{
      public class MaintainSupplierController
        {
         SupplierFacade supplier = new SupplierFacade();
         public List<supplier> checksupplierList()
         {
             return supplier.checksupplierList();
         }
       
         public void editsupplier(int id, string name, string contactname, string phonenNO, string faxno, string address, string gst)
         {
             supplier.editsupplier(id,name,contactname,phonenNO,faxno,address,gst);
         }
         public void deteleSupplier(int id)
         {
            supplier.deletesupplier(id);
         }
         public void addsupplier(string name, string contactname, string phonenNO, string faxno, string address, string gst)
         {
             supplier.addsupplier(name, contactname, phonenNO, faxno, address, gst);
         }
         public supplier findsupplier(int s)
         {
            return supplier.findsupplier(s);
         }
    }
}
