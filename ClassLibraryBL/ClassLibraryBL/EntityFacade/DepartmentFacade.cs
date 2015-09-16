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
    public class DepartmentFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();
        public List<collectionPoint> getCollectionPointTime(User u)
        {

            var t = (from x in luse.collectionPoints
                     select x
                ).ToList();
            return t;
        }
        public void changeCollectionPoint(User u, string collectionP)
        {
            
            var t = (from x in luse.departments 
                     where x.departmentId == u.DepartmentId
               select x).First();
            var y = (from r in luse.collectionPoints
                     where r.address == collectionP
                     select r).First();
            t.collectionPointId = y.collectionPointId;
            luse.SaveChanges();
        }


        public void mailNotificationCollectionPoint(User u, string collectionP, string deptid)
        {
            var t = (from x in luse.users
                     where x.roleId == 4 || x.departmentId == u.DepartmentId
                     select x).ToList();
            var r = (from x in luse.users
                     from y in luse.departments
                     where x.userId == u.UserId && x.departmentId == y.departmentId
                     select y.deptName
                    ).First().Trim();

            string name = u.Name;
            string from = "lujianfeng1990@hotmail.com";
            string to = "lujianfeng1990@hotmail.com";

            string content = "<strong>Delegate Information: <strong> <br> Dear All,<br>" + "Our Collection Point has been changed as " + collectionP + ". FYI." + "<br><br> Regards," + u.Name;
            MailMessage messge = new MailMessage(from, to);
            foreach (user u2 in t)
            {
                messge.To.Add(u2.email);
            }
            messge.Body = content;
            messge.Subject = "Notification: Collection Point changed for Department " + r; //change and use session
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.live.com";
            client.Credentials = new NetworkCredential("lujianfeng1990@hotmail.com", "ibm1990324");
            client.EnableSsl = true;
            client.Send(messge);
            messge.Attachments.Dispose();
        }

        //************************Jin yu meng ***************************
        public List<Department> GetDepName()
        {
            var query = from d in luse.departments
                        select new Department
                        {
                            departmentId = d.departmentId,
                            deptName = d.deptName
                        };
            return query.ToList();
        }

        //mobile
        public List<department> GetDepName2()
        {
            var query = from d in luse.departments
                        select d;

            return query.ToList();
        }

    }
}
