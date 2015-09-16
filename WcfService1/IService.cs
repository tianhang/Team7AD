using ClassLibraryBL;
using ClassLibraryBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/test", ResponseFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //start 
        //requisition
        [OperationContract]
        [WebInvoke(Method="GET",
            BodyStyle=WebMessageBodyStyle.Bare, 
            UriTemplate = "/getAllRequisition", 
            ResponseFormat = WebMessageFormat.Json)]
        List<requisitionEntity> getAllRequisition();

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getPendingRequisition",
            ResponseFormat = WebMessageFormat.Json)]
        List<requisitionEntity> getPendingRequisition();

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getWaitingRequisition",
            ResponseFormat = WebMessageFormat.Json)]
        List<requisitionEntity> getWaitingRequisition();

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getCompletedRequisition",
            ResponseFormat = WebMessageFormat.Json)]
        List<requisitionEntity> getCompletedRequisition();


        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getRequisitionDetail/{rid}",
            ResponseFormat = WebMessageFormat.Json)]
        List<RequisitionDetails> getRequisitionDetail(string rid);

       //retrieve form
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getCurrentWeekRetrieveFormByItem",
            ResponseFormat = WebMessageFormat.Json)]
        List<RequisitionMix> getCurrentWeekRetrieveFormByItem();

       //disbursement list by department
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getCurrentDisbursementByDepartment/{v}",
            ResponseFormat = WebMessageFormat.Json)]
        List<RequisitionMix> getCurrentDisbursementByDepartment(string v);

        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    BodyStyle = WebMessageBodyStyle.Bare,
        //    UriTemplate = "/getCurrentDisbursementByDepartmentDetail/{disbursementId}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //List<disbursementEntity> getCurrentDisbursementByDepartmentDetail(string disbursementId);
        
        //department name list
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getDepartmentNameList",
            ResponseFormat = WebMessageFormat.Json)]
        List<departmentEntity> getDepartmentNameList();

        //Purchase
        //get purchase order list
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getPurchaseOrderList",
            ResponseFormat = WebMessageFormat.Json)]
        List<purchaseEntity> getPurchaseOrderList();

        //purchase item
        //get purchase_item
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/getPurchaseOrderDetailbyId/{PurchaseId}",
            ResponseFormat = WebMessageFormat.Json)]
        List<Purchaseitem111> getPurchaseOrderDetail(string PurchaseId);

        //comfirm purchase
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/comfirmPurchase/{PurchaseId}",
            ResponseFormat = WebMessageFormat.Json)]
        bool comfirmPurchase(string PurchaseId);

        //cancel purchase
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/cancelPurchase/{PurchaseId}",
            ResponseFormat = WebMessageFormat.Json)]
        bool cancelPurchase(string PurchaseId);

        //delete purchase item
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/deletePurchaseItem/{itemId}/{supplierid}/{purchaseid}",
            ResponseFormat = WebMessageFormat.Json)]
        bool deletePurchaseItem(string itemid, string supplierid, string purchaseid);

        //add purchase item
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/addPurchaseItem/{itemId}/{supplierid}/{purchaseid}/{qty}",
            ResponseFormat = WebMessageFormat.Json)]
        bool addPurchaseItem(string itemid, string supplierid, string purchaseid,string qty);

        //////////discrepancy//////////////////////
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/discrepancyListHistory",
            ResponseFormat = WebMessageFormat.Json)]
        List<discrepancyEntity> discrepancyListHistory();

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "/discrepancyListHistoryDetail/{discrepancyId}",
            ResponseFormat = WebMessageFormat.Json)]
        List<discrepancyDetailEntityMobile> discrepancyListHistoryDetail(string discrepancyId);


        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/addDiscrepancy",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json
            )]
        bool addDiscrepancy(List<discrepancyDetailEntityMobile> ddem, User u);

        /////get item by id
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/getItemById/{id}",
            ResponseFormat = WebMessageFormat.Json
            )]
        itemEntity getItemById(string id);

        //get item by name
        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/getItemByName/{name}",
            ResponseFormat = WebMessageFormat.Json
            )]
        List<itemEntity> getItemByName(string name);
          

       // end 

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
