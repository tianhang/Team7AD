using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class Purchaseitem111
    {
        [DataMember]
        public int Itemcode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int price { get; set; }
        [DataMember]
        public int Amount { get; set; }

    }
}
