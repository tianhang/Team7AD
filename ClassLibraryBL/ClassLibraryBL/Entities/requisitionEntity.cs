using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class requisitionEntity
    {
       
       
        [DataMember]
        public int requisitionId { get; set; }
        [DataMember]
        public string departmentId { get; set; }
        [DataMember]
        public System.DateTime requestDate { get; set; }
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string userId { get; set; }
        [DataMember]
        public string rejectReason { get; set; }
    }
}
