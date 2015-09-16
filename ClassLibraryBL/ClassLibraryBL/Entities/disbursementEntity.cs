using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class disbursementEntity
    {
        public string deptName;
        public int disbursementId;
        public DateTime collectionDate;
        public string status;


        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        [DataMember]
        public DateTime CollectionDate
        {
            get { return collectionDate; }
            set { collectionDate = value; }
        }

        [DataMember]
        public int DisbusementId
        {
            get { return disbursementId; }
            set { disbursementId = value; }
        }



        [DataMember]
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
    }
}
