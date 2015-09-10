using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    public class Department
    {
         
         [DataMember]
         public string departmentId { get; set; }
         [DataMember]
         public string deptName { get; set; }
         [DataMember]
         public string requisitionId { get; set; }
         [DataMember]
         public string requisitionItemId { get; set; }
         public void test()
         {

         }
    }
}
