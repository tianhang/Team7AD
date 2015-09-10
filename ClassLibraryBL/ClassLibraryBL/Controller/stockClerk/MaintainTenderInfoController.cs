using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
namespace ClassLibraryBL.Controller.stockClerk
{
     public class MaintainTenderInfoController
    {
         SupplierFacade supplier = new SupplierFacade();
         public List<SupplieritemMix> searchbydescription(string keyword,int id)
         {
             return supplier.searchbydescription(keyword, id);
         }
         public void editprice(int itemid, int supplierid, int price) 
         {
             supplier.editprice(itemid, supplierid, price);
         }
         public List<SupplieritemMix> showitems(int id)
         {
             return supplier.showitems(id);
         }
         public SupplieritemMix showsingleitem(int itemid, int supplierid)
         {
             return supplier.showsingleitem(itemid, supplierid);
         }
    }
}
