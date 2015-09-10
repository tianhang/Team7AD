using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class RequestThreeMonthsEntity
    {
        [DataMember]
        public int requisitionId { get; set; }
    
        [DataMember]
        public int requestQty { get; set; }//
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string categoryName { get; set; }
        [DataMember]
        public DateTime requestDate { get; set; }  
       
        //
    }
}
