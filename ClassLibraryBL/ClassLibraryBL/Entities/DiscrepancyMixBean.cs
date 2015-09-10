using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class DiscrepancyMixBean
    {
        [DataMember]
        public int DiscrepancyId { get; set; }
        [DataMember]
        public string Clerk { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Remark { get; set; }
        [DataMember]
        public int TotalPrice { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
