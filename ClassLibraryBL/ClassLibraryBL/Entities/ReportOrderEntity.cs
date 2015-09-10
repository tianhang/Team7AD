using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class ReportOrderEntity
    {
        [DataMember]
        public string categoryName { get; set; }
        [DataMember]
        public int requestQty { get; set; }
        [DataMember]
        public DateTime purchaseDate { get; set; }
    }
}
