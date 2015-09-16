using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class purchaseEntity
    {

        [DataMember]
        public int purchaserId { get; set; }
        [DataMember]
        public int supplierId { get; set; }
        [DataMember]
        public System.DateTime purchaseDate { get; set; }
        [DataMember]
        public string userId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> expectedDeliveryDate { get; set; }
        [DataMember]
        public string status { get; set; }
    
       
    }
}
