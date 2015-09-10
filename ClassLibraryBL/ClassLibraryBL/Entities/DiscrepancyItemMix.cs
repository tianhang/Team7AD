using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    [DataContract]
    public  class DiscrepancyItemMix
    {
        [DataMember]
       public string Catogory {get;set;}
        [DataMember]
       public string  Item {get;set;}
        [DataMember]
       public int   Quantity{get;set;}
        [DataMember]
       public string Type { get; set; }
    }
}
