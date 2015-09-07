using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.Controller.DeptHead
{
    public class MaintainCollectionPointController
    {
        DepartmentFacade df = new DepartmentFacade();
        public List<collectionPoint> getCollectionPointTime(Entities.User u)
        {
            return df.getCollectionPointTime(u);
        }
        public void mailNotificationCollectionPoint(User u, string collectionP, string deptid)
        {
            df.mailNotificationCollectionPoint(u, collectionP, deptid);
        }

        public void changeCollectionPoint(User u, string collectionP)
        {
            df.changeCollectionPoint(u, collectionP);
        }
    }
}
