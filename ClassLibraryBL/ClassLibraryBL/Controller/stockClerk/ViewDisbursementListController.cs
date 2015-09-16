using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ViewDisbursementListController
    {
        DisbursementFacade disF = new DisbursementFacade();
        DepartmentFacade df = new DepartmentFacade();
        public Object getCurrentList(String value)
        {
            return disF.getCurrentList(value);
        }

        public Object getDetailedItem(int session)
        {
            return disF.getDetailedItem(session);
        }

        public Object getCollectionPoint(String value)
        {
            return disF.getCollectionPoint(value);
        }

        public Object getAllHistoryList()
        {
            return disF.getAllHistoryList();
        }

        public Object getSelectedHistoryList(DateTime begin,DateTime end)
        {
            return disF.getSelectedHistoryList(begin, end);
        }
        
        public Object getHistoryListDetails(String disbursementId)
        {
            return disF.getHistoryListDetails(disbursementId);
        }

        //////////////////////////////mobile///////////////////////////////////
        public List<RequisitionMix> getCurrentList2(String v)
        {
            return disF.getCurrentList2(v);
        }
        public List<department> GetDepName2()
        {
            return df.GetDepName2();
        }

        public List<departmentEntity> transferDepartment(List<department> deps)
        {
            List<departmentEntity> deList = new List<departmentEntity>();
            foreach (department d in deps)
            {
                departmentEntity de = new departmentEntity();
                de.departmentId = d.departmentId;
                de.deptName = d.deptName;
                de.contacName = d.contacName;
                de.phoneNo = d.phoneNo;
                de.faxNo = d.faxNo;
                de.collectionPointId = d.collectionPointId;
                deList.Add(de);
            }
            return deList;
        }


    }
}
