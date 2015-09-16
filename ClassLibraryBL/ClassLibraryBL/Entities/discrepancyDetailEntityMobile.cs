using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
     [DataContract]
    public class discrepancyDetailEntityMobile
    {
        [DataMember]
        public string type { get; set; }
         [DataMember]
        public string categoryName { get; set; }
         [DataMember]
        public string description { get; set; }
         [DataMember]
        public int balance { get; set; }
         [DataMember]
        public string unit { get; set; }
         [DataMember]
        public string Remark { get; set; }
         [DataMember]
        public string status { get; set; }
    }
}
