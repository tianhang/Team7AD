using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class itemEntity
    { 
       
        [DataMember]
        public int itemId { get; set; }
        [DataMember]
        public string unit { get; set; }
        [DataMember]
        public string categoryName { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int reorderlevel { get; set; }
        [DataMember]
        public int reorderQty { get; set; }
        [DataMember]
        public int balance { get; set; }
        [DataMember]
        public string binNumber { get; set; }
        [DataMember]
        public string photourl { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string companyName { get; set; }
       
    }
}
