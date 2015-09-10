using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.deptEmpRep
{

    
    public class ViewPastDisbursementListController
    {
        DisbursementFacade df = new DisbursementFacade();
        public List<DisbursementList> getHisDisbursementList(User u)
        {
            return df.getHisDisbursementList(u);
        }


        public List<DisbursementList> getDetailDisbursementList(User u, int p)
        {
            return df.getHisDetailDisbursementList(u,p);
        }
    }
}
