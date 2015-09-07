using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using System.Net.Mail;
using System.Net;
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
        public void mailNotification(string dt0, string dt1, string name0)
        {
            string startDate = dt0;

            string endDate = dt1;
            string name = name0;
            string from = "lujianfeng1990@hotmail.com";
            string to = "tictaclu@gmail.com";
            string content = "<strong>Delegate Information:";
            MailMessage messge = new MailMessage(from, to);
            messge.Body = content;
            messge.Subject = "Notification of Delegate of English Department"; //change and use session
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.live.com";
            client.Credentials = new NetworkCredential("lujianfeng1990@hotmail.com", "1990324");
            client.EnableSsl = true;
            client.Send(messge);
            messge.Attachments.Dispose();
        }
    }
}
