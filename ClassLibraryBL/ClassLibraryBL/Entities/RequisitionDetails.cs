using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBL.Entities
{
      [DataContract]
    public class RequisitionDetails
    {
        string description;
        string unit;
        string name;
          [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string status;
        string collectionPoint;

           [DataMember]
        public string CollectionPoint
        {
            get { return collectionPoint; }
            set { collectionPoint = value; }
        }
          [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        DateTime reqDate;

          [DataMember]
        public DateTime ReqDate
        {
            get { return reqDate; }
            set { reqDate = value; }
        }

           [DataMember]
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
          [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        int number;

          [DataMember]
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

          public string photourl;
           [DataMember]
          public string Photourl
          {
              get { return photourl; }
              set { photourl = value; }
          }
    }
}
