using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class ShoppingItem
    {
        string description;
        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        int amount;
        [DataMember]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        string photourl;
        [DataMember]
        public string Photourl
        {
            get { return photourl; }
            set { photourl = value; }
        }

        int itemId;
        [DataMember]
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

    }
}
