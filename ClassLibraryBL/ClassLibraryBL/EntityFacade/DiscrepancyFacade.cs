using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Collections;
using ClassLibraryBL;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;


namespace ClassLibraryBL.EntityFacade
{
    public class DiscrepancyFacade
    {

        LogicUnivSystemEntities lg = new LogicUnivSystemEntities();

//**********************************DU DU********************************
        public Object getCategory()
        {
            var data = from c in lg.categories
                       select c.categoryName;
            return data.ToList();
        }
        public Object getCategoryItem(String transfer)
        {
            var dataItem = from a in lg.items
                           join g in lg.categories on a.categoryId equals g.categoryId
                           where g.categoryName == transfer
                           select a.description;
            return dataItem.ToList();
        }

        public String getUnit(String transfer)
        {
            var dataunit = from c in lg.categories
                           join i in lg.items on c.categoryId equals i.categoryId
                           where c.categoryName == transfer
                           select i.unit;
            return dataunit.FirstOrDefault();
        }
        public void confirmOperation(DataTable Data,User u)
        {
            for (int i = 0; i < Data.Rows.Count; i++)
            {

                String category = Data.Rows[i].ItemArray[0].ToString();
                String description = Data.Rows[i].ItemArray[1].ToString();
                int amount = Convert.ToInt32(Data.Rows[i].ItemArray[2]);
                String unit = Data.Rows[i].ItemArray[3].ToString();
                String type = Data.Rows[i].ItemArray[4].ToString();
                String remark = Data.Rows[i].ItemArray[5].ToString();
                DateTime reportdate = DateTime.Now;
                addToDiscrepancyTable(description, reportdate, remark, u.UserId, 50, amount, type);

            }
        }

        protected void addToDiscrepancyTable(String description, DateTime reportdate, String remark, String userId, int totalprice, int amount, String type)
        {
            int getitemId = getItemId(description);
            discrepancy addDiscrepancy = new discrepancy();
            addDiscrepancy.reportDate = reportdate;
            addDiscrepancy.Remark = remark;
            addDiscrepancy.userId = userId;
            addDiscrepancy.totalPrice = totalprice;

            lg.discrepancies.Add(addDiscrepancy);
            lg.SaveChanges();

            discrepancy_item addDI = new discrepancy_item();
            addDI.discrepancyId = addDiscrepancy.discrepancyId;
            addDI.reportQty = amount;
            addDI.type = type;
            addDI.itemId = getitemId;

            lg.discrepancy_item.Add(addDI);
            lg.SaveChanges();

        }

        protected int getItemId(String description)
        {
            String d = description;
            var data = from i in lg.items
                       where i.description == d
                       select i.itemId;
            int value = data.FirstOrDefault();
            return value;
        }

        public Object ListHistory()
        {
            var data = from d in lg.discrepancies
                       select new { d.discrepancyId, d.reportDate, d.totalPrice,d.status};
            return data.ToList();
        }

        public Object ListSelectedHistory(DateTime begin,DateTime end)
        {
            var data = from d in lg.discrepancies
                       where d.reportDate>begin
                       where d.reportDate<end
                       select new { d.discrepancyId, d.reportDate, d.totalPrice, d.status };
            return data.ToList();
        }

        public Boolean validateBlank(String cIn,String cOut)
        {
            if(cIn==""|| cOut=="")
            {
                return false; 
            }
            return true;

        }

        public Object getDiscrepanyDetail(String id)
        {
            int getId=Convert.ToInt32(id);
            var data = from d in lg.discrepancies
                       join di in lg.discrepancy_item on d.discrepancyId equals di.discrepancyId
                       join i in lg.items on di.itemId equals i.itemId
                       join c in lg.categories on i.categoryId equals c.categoryId
                       where d.discrepancyId==getId
                       select new { c.categoryName, i.description, i.balance, i.unit, di.type, d.Remark,d.status };
            return data.ToList();
        }

        //**********************************DU DU********************************



        //PENG XIAO MENG***************************************
        public List<DiscrepancyMixBean> getpendingdiscrepancy()
        {
            var N = from a in lg.discrepancies
                    join b in lg.users on a.userId equals b.userId
                    where a.status == "Pending"
                    select new DiscrepancyMixBean
                    {
                        DiscrepancyId = a.discrepancyId,
                        Clerk = b.name,
                        Date = a.reportDate,
                        Remark = a.Remark,
                        TotalPrice = a.totalPrice,
                        Status = a.status
                    };
            return N.ToList();
        }
        public List<DiscrepancyItemMix> getdiscrepancyitem(int s)
        {
            var N = from a in lg.discrepancy_item
                    join b in lg.items on a.itemId equals b.itemId
                    join c in lg.categories on b.categoryId equals c.categoryId
                    where a.discrepancyId == s
                    select new DiscrepancyItemMix
                    {
                        Catogory = c.categoryName,
                        Item = b.description,
                        Quantity = a.reportQty,
                        Type = a.type
                    };
            return N.ToList();
        }
        public void approvediscrepancy(int s)
        {
            discrepancy ac = (from a in lg.discrepancies
                              where a.discrepancyId == s
                              select a).SingleOrDefault();
            ac.status = "Approved";
            lg.SaveChanges();
        }
        public void rejectdiscrepancy(int s)
        {
            discrepancy ac = (from a in lg.discrepancies
                              where a.discrepancyId == s
                              select a).SingleOrDefault();
            ac.status = "Rejected";
            lg.SaveChanges();
        }





        //PENG XIAO MENG***************************************
    }
    
}
