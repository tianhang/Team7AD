using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ViewPendingFormController
    {
        ViewPendingFormFacade vpff = new ViewPendingFormFacade();
        public Object getAllPendingItem()
        {
            return vpff.getAllPendingItems();
        }

        public Object getListByDept(String selectedValue)
        {
            return vpff.getListByDept(selectedValue);
        }

        public Object getListByDeptDetail(String rId)
        {
            return vpff.getListByDeptDetail(rId);
        }

    }
}
