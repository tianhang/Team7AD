using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class SupplieritemMix
    {
        [DataMember]
        public string Itemdescription { get; set; }
        [DataMember]
        public int itemid { get; set; }
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public int price { get; set; }

    }
}
