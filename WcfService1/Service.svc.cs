using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using ClassLibraryBL;
using ClassLibraryBL.Controller.deptEmp;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string GetData()
        {
            //LogicUnivSystemEntities a = new LogicUnivSystemEntities();
            return "aaaa";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //requisition
        ProcessRequistionController prc = new ProcessRequistionController();
        ViewCurrentRequisitionController vcrc = new ViewCurrentRequisitionController();
        ViewRetrievalFormController vrfc = new ViewRetrievalFormController();
        ViewDisbursementListController vdlc = new ViewDisbursementListController();
        public List<requisitionEntity> getAllRequisition()
        {
            List<requisitionEntity> reList = new List<requisitionEntity>();
            reList = prc.getAllRequisitionData();            
            return reList;
        }

        public List<requisitionEntity> getPendingRequisition()
        {
            List<requisitionEntity> reList = new List<requisitionEntity>();
            reList = prc.getPendingRequisitionData();
            return reList;

        }

        public List<requisitionEntity> getWaitingRequisition()
        {
            List<requisitionEntity> reList = new List<requisitionEntity>();
            reList =prc.getWaitingRequisitionData();
            return reList;

        }
        public List<requisitionEntity> getCompletedRequisition()
        {
            List<requisitionEntity> reList = new List<requisitionEntity>();
            reList = prc.getCompletedRequisitionData();
            return reList;

        }

        public List<RequisitionDetails> getRequisitionDetail(string rid)
        {
            return vcrc.RequisitionDetail(rid);

        }

        //retrieve form
        public List<RequisitionMix> getCurrentWeekRetrieveFormByItem() { 
            return vrfc.checkcurrentweekbyitem();
        }

        //disbursement list by department
        public List<RequisitionMix> getCurrentDisbursementByDepartment(string v)
        {
            return vdlc.getCurrentList2(v);
        }

        //public List<disbursementEntity> getCurrentDisbursementByDepartment(string v)
        //{
        //    return vdlc.getCurrentList2(v);
        //}

        //department name list
        public List<departmentEntity> getDepartmentNameList() {
            List<departmentEntity> deList = vdlc.transferDepartment(vdlc.GetDepName2());
            return deList;
        }


        //purchase
        PlaceOrderController poc = new PlaceOrderController();
        public List<purchaseEntity> getPurchaseOrderList()
        {
            List<purchaseEntity> pList = poc.getPurchaseOrder();
            return pList;

        }

        public List<Purchaseitem111> getPurchaseOrderDetail(string PurchaseId)
        {
            int id = Convert.ToInt32(PurchaseId.Trim());
            List<Purchaseitem111> piList = poc.showpurchaseitems(poc.findpurchaseorder(id));
            return piList;
        }
        public bool comfirmPurchase(string PurchaseId) 
        {
            int id = Convert.ToInt32(PurchaseId.Trim());
            poc.confirmorder(id);
            return true;
        }

        public bool cancelPurchase(string PurchaseId)
        {
            int id = Convert.ToInt32(PurchaseId.Trim());
            poc.cancel(id);
            return true;
        }

        public bool deletePurchaseItem(string itemid, string supplierid, string purchaseid)
        {
            int itid = Convert.ToInt32(itemid.Trim());
            int sid = Convert.ToInt32(supplierid.Trim());
            int pid = Convert.ToInt32(purchaseid.Trim());
            poc.delete(itid, sid, pid);
            return true;
        }
        public bool addPurchaseItem(string itemid, string supplierid, string purchaseid, string qty)
        {
            int itid = Convert.ToInt32(itemid.Trim());
            int sid = Convert.ToInt32(supplierid.Trim());
            int pid = Convert.ToInt32(purchaseid.Trim());
            int quantity = Convert.ToInt32(qty);
            poc.additems(itid, sid, pid, quantity);
            return true;
        }

        //discrepancy//////////////////////////////
        ProcessDiscrepancyController pdc = new ProcessDiscrepancyController();
        public List<discrepancyEntity> discrepancyListHistory() {
            return pdc.ListHistory2();
        }

        public List<discrepancyDetailEntityMobile> discrepancyListHistoryDetail(string discrepancyId) 
        {
            return pdc.getDiscrepanyDetail2(discrepancyId);
            
        }

        public bool addDiscrepancy(List<discrepancyDetailEntityMobile> ddem, User u)
        {
            pdc.confirmOperation2(ddem, u);
            return true;
        }

        //get item by id
        ViewInventoryController vic = new ViewInventoryController();
        public itemEntity getItemById(string id) {
            int i = Convert.ToInt32(id);
            return vic.getItemById(i);

        }

        //get item by name
        public List<itemEntity> getItemByName(string name) 
        {
            return vic.getItemByName(name);

        }
    }
}
