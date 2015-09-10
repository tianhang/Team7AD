using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller;
using ClassLibraryBL.EntityFacade;
namespace ClassLibraryBL.Controller.stockClerk
{
    public  class PlaceOrderController
    {
        PurchaseOrderFacade f=new PurchaseOrderFacade();
        public purchase findpurchaseorder(int s){
            return f.findpurchaseorder(s);
        }
        public void confirmorder(int s){
            f.confirmorder(s);
        }
       public  void formorder(user u){
           f.formorder(u);
       }
       public List<Purchaseitem111> showpurchaseitems(purchase p)
       {
          return f.showpurchaseitems(p);
       }
       public void cancel(int s)
       {
           f.cancel(s);
       }
       public List<string> getcompanyname(int i, int s,int x)
       {
           return f.getcompanyname(i, s,x);
       }
       public void changesupplier(int itemcode, int purchaseid, string comname)
       {
           f.changesupplier(itemcode, purchaseid, comname);
       }
       public void additems(int itemcode, int supplierid, int purchaseid, int qt)
       {
           f.additems(itemcode, supplierid, purchaseid, qt);
       }
       public List<string> showitemsbysupppier(int supplierid)
       {
           return f.showitemsbysupplier(supplierid);
       }
       public int finditemcode(string description, int supplierid)
       {
           return f.finditemcode(description, supplierid);
       }
       public void delete(int itemcode, int supplierid, int purchaseid)
       {
           f.deleteitem(itemcode, supplierid, purchaseid);
       }
    }
    
}
