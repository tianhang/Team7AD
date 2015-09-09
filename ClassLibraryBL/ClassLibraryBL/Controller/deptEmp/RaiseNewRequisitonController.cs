using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Controller.deptEmp
{
    public class RaiseNewRequisitonController
    {
        List<string> idlistBuy = new List<string>();
        List<int> idlistInt = new List<int>();
        List<string> amountlist = new List<string>();
        List<int> amountlistInt = new List<int>();
        List<string> namelist = new List<string>();
        List<ShoppingItem> sclist = new List<ShoppingItem>();
        RequisiitonFacade rf = new RequisiitonFacade();
        public List<int> getIdlistInt(string idstr) {
            idlistBuy = idstr.Split('/').ToList();
            for (int i = 0; i < idlistBuy.Count; i++)
            {
                if (idlistBuy[i] != "")
                {

                    idlistInt.Add(Convert.ToInt32(idlistBuy[i]));

                }
            }
            return idlistInt;
        }


        public List<int> getAmountlistInt(string amountstr) {
            amountlist = amountstr.Split('/').ToList();
            for (int i = 0; i < amountlist.Count; i++)
            {
                if (amountlist[i] != "")
                {

                    amountlistInt.Add(Convert.ToInt32(amountlist[i]));

                }
            }
            return amountlistInt;
        }

        public List<string> getNamelist(List<item> itemList, List<int> idlistInt)
        {
            for (int i = 0; i < idlistInt.Count; i++)
            {
                for (int j = 0; j < itemList.Count; j++)
                {
                    if (idlistInt[i] == itemList[j].itemId)
                    {
                        namelist.Add(itemList[j].description);
                    }

                }
            }
            return namelist;
        }

        public List<ShoppingItem> addShoppingItem(List<string> namelist, List<int> amountlistInt, List<int> idlistInt)
        {
            for (int i = 0; i < namelist.Count; i++)
            {
                ShoppingItem si = new ShoppingItem();
                si.Description = namelist[i];
                si.Amount = amountlistInt[i];
                si.Photourl = "../images/" + namelist[i].Trim() + ".jpg";
                si.ItemId = idlistInt[i];
                sclist.Add(si);
            }
            return sclist;
        }

        public void addRequisitionController(User u, List<ShoppingItem> sclist)
        {
            rf.addRequisition(u, sclist);
        }


    }
}
