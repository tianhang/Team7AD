using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;

namespace ClassLibraryBL.Controller.DeptHead
{
    
    public class DelegateAuthorityController
    {
        UserFacade uf = new UserFacade();

        public void delegateAuthority(string rid)
        {
            uf.delegateAuthority(rid);
        }
        public List<user> getAllEmployee(User u)
        {
            return uf.getAllEmployee(u);
        }

        public void mailNotification(string dt0, string dt1, string name0)
        {
            uf.mailNotification(dt0,dt1,name0);
        }
    }
}
