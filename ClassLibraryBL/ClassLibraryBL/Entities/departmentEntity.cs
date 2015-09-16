using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class departmentEntity
    {
        public departmentEntity()
        {
            this.disbursements = new HashSet<disbursement>();
            this.requisitions = new HashSet<requisition>();
            this.users = new HashSet<user>();
        }
        [DataMember]
        public string departmentId { get; set; }
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string contacName { get; set; }
        [DataMember]
        public string phoneNo { get; set; }
        [DataMember]
        public string faxNo { get; set; }
        [DataMember]
        public string collectionPointId { get; set; }
        [DataMember]
    
        public virtual collectionPoint collectionPoint { get; set; }
        [DataMember]
        public virtual ICollection<disbursement> disbursements { get; set; }
        [DataMember]
        public virtual ICollection<requisition> requisitions { get; set; }
        [DataMember]
        public virtual ICollection<user> users { get; set; }
    }
}
