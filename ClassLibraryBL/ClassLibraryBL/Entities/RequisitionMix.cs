using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class RequisitionMix
    {
     [DataMember]
      public int  itemID{get;set;}
     [DataMember]
      public string  Category{get;set;}
     [DataMember]
      public string  Itemname{get;set;}
     [DataMember]
      public int   amount{get;set;}
      [DataMember]
      public string Unit{get;set;}
      [DataMember]
      public string Bin { get; set; }
    }
}
