using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class discrepancyEntity
    {
        [DataMember]
        public int discrepancyId { get; set; }
        [DataMember]
        public System.DateTime reportDate { get; set; }
        [DataMember]
        public string Remark { get; set; }
        [DataMember]
        public string userId { get; set; }
        [DataMember]
        public int totalPrice { get; set; }
        [DataMember]
        public string status { get; set; }

    }
}
