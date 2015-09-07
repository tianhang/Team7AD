using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using System.Net.Mail;
using System.Net;
using System.Collections;
namespace ClassLibraryBL.EntityFacade
{
    public class UserFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();
        

        public void delegateAuthority(string uid)
        {
            var t = (from x in luse.users
                     from y in luse.roles
                     where x.userId == uid
                     select x).First();

            var m = (from x in luse.roles
                     where x.roleName == "deptHead"
                     select x.roleId).First();
            t.roleId = m;
            luse.SaveChanges();
        }
        public List<user> getAllEmployee(User u)
        {
            var t = (from x in luse.users
                     where x.departmentId == u.DepartmentId
                     select x).ToList();
            return t;
        }
        public void mailNotification(string dt0, string dt1, User u,string newname)
        {
            var t = (from x in luse.users
                     where x.roleId == 4 || x.departmentId == u.DepartmentId
                     select x).ToList();
            var r = (from x in luse.users
                     from y in luse.departments
                     where x.userId == u.UserId && x.departmentId == y.departmentId
                     select y.deptName
                    ).First().Trim();

            string startDate = dt0;
            string endDate = dt1;
            string name = u.Name;
            string from = "lujianfeng1990@hotmail.com";
            string to = "lujianfeng1990@hotmail.com";

            string content = "<strong>Delegate Information: <strong> <br> Dear All,<br>" + newname + ", will take my responsibility to approve requisition from our department between" + dt0 + " and " + dt1 + "<br><br> Regards," + u.Name;
            MailMessage messge = new MailMessage(from, to);
             foreach (user u2 in t)
            {
                messge.To.Add(u2.email);
            }
            messge.Body = content;
            messge.Subject = "Notification: Delegation changed of " +r; //change and use session
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.live.com";
            client.Credentials = new NetworkCredential("lujianfeng1990@hotmail.com", "ibm1990324");
            client.EnableSsl = true;
            client.Send(messge);
            messge.Attachments.Dispose();
        }

        public void AssignNewRep(string uid)
        {
            var t = (from x in luse.users
                     from y in luse.roles
                     where x.userId == uid
                     select x).First();

            var m = (from x in luse.roles
                     where x.roleName == "deptEmployeeRep"
                     select x.roleId).First();
            t.roleId = m;
            luse.SaveChanges();
        }

        public void mailNotificationForRep(string dt0, string dt1, User u, string newname)
        {
            var t = (from x in luse.users
                     where x.roleId == 4 || x.departmentId == u.DepartmentId
                     select x).ToList();
            var r = (from x in luse.users
                     from y in luse.departments
                     where x.userId == u.UserId && x.departmentId == y.departmentId
                     select y.deptName
                    ).First().Trim();

            string startD = dt0;
            string endD = dt1;
            string name = u.Name;
            string from = "lujianfeng1990@hotmail.com";
            string to = "lujianfeng1990@hotmail.com";

            string content = "<strong>Employee Representitives changed Information: <strong> <br> Dear All,<br>" + newname + ", will take responsibility to collect stationeries for my department between" + dt0 + " and " + dt1 + "<br><br> Regards," + u.Name;
            MailMessage messge = new MailMessage(from, to);
            foreach (user u2 in t)
            {
                messge.To.Add(u2.email);
            }
            messge.Body = content;
            messge.Subject = "Notification: Employee Representitives changed for " + r; //change and use session
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.live.com";
            client.Credentials = new NetworkCredential("lujianfeng1990@hotmail.com", "ibm1990324");
            client.EnableSsl = true;
            client.Send(messge);
            messge.Attachments.Dispose();
        }


    }
}
