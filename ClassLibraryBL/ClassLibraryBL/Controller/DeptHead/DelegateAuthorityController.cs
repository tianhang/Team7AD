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

        public void delegateAuthority(string uid)
        {
            uf.delegateAuthority(uid);
        }
        public List<user> getAllEmployee(User u)
        {
            return uf.getAllEmployee(u);
        }

        public void mailNotification(string dt0, string dt1,User u,string name)
        {
            uf.mailNotification(dt0,dt1,u,name);
        }
    }
}
