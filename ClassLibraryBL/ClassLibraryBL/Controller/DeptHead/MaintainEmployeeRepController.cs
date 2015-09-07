using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
namespace ClassLibraryBL.Controller.DeptHead
{
    public class MaintainEmployeeRepController
    {
        UserFacade uf = new UserFacade();
        public List<user> getAllEmployee(Entities.User u)
        {
            return uf.getAllEmployee(u);
        }

        public void AssignNewRep(string uid)
        {
            uf.AssignNewRep(uid);
        }

        public void mailNotification(string startDate, string endDate, Entities.User u, string name)
        {
            uf.mailNotificationForRep(startDate, endDate, u, name);
        }
    }
}
