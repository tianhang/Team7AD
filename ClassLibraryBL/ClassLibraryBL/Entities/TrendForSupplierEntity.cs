using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class TrendForSupplierEntity
    {
        [DataMember]
        public int requestQty { get; set; }
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string categoryName { get; set; }
        [DataMember]
        public DateTime requestDate { get; set; }
        [DataMember]
        public Nullable<int> price { get; set; }
        [DataMember]
        public Nullable<int> categoryCost { get; set; } 
        
    }
}
