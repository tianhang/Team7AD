using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    [DataContract]
    public class itemValidate
    {

        int itemreorderlevel;

        [DataMember]
        public int Itemreorderlevel
        {
            get { return itemreorderlevel; }
            set { itemreorderlevel = value; }
        }

        int itemid;
        [DataMember]
        public int Itemid
        {
            get { return itemid; }
            set { itemid = value; }
        }
        int stockBalance;

         [DataMember]
        public int StockBalance
        {
            get { return stockBalance; }
            set { stockBalance = value; }
        }
        int requestQty;

         [DataMember]
        public int RequestQty
        {
            get { return requestQty; }
            set { requestQty = value; }
        }

    }
}
