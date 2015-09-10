using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.stockClerk
{
    public class ViewRetrievalFormController
    {
        RequisiitonFacade req = new RequisiitonFacade();
        public List<RequisitionMix> checkcurrentweekbyitem()
        {
           return req.currentweekbyitem();
        }
        public List<RequisitionMix> checkcurrentweekbydepartment(string s)
        {
            return req.currentweekbydepartment(s);
        }
        public List<RequisitionMix> checkhistorybyitemwithdate(string start, string end)
        {
            return req.itemwithdate(start, end);
        }
        public List<RequisitionMix> checkhistorybydepartmentwithdate(string ts, string start, string end)
        {
            return req.departmentwithdate(ts, start, end);
        }
        public List<RequisitionMix> checkhistorybydepartmentwithoutdate(string s)
        {
            return req.departmentwithoutdate(s);
        }
        public List<RequisitionMix> checkhistorybyitemwithoutdate()
        {
            return req.itemwithoutdate();
        }
    }
}
