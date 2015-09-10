using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class RequestItem
    {
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int itemId { get; set; }
        [DataMember]
        public int requisitionId { get; set; }
        [DataMember]
        public string departmentId { get; set; }
        [DataMember]
        public int requestQty { get; set; }
        //[DataMember]
        //public int reorderQty { get; set; }
        //[DataMember]
        //public int balance { get; set; }
        //[DataMember]
        //public string binNumber { get; set; }
        //[DataMember]
        //public string photourl { get; set; }

        //[DataMember]
        //public virtual category category { get; set; }
    }
}
