using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{     
    [DataContract]
    public class DisbursementList
    {
    string description;
    int disbusementId;
    string photourl;
    string contacName;
    DateTime collectionDate;

    string status;

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
    public string ContacName
    {
        get { return contacName; }
        set { contacName = value; }
    }
    string address;

        [DataMember]
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    string time;
        [DataMember]

    public string Time
    {
        get { return time; }
        set { time = value; }
    }

         [DataMember]
    public string Photourl
    {
        get { return photourl; }
        set { photourl = value; }
    }
     [DataMember]
    public int DisbusementId
    {
        get { return disbusementId; }
        set { disbusementId = value; }
    }



    [DataMember]
public string Description
{
  get { return description; }
  set { description = value; }
}
    int collectQty;


    [DataMember]
public int CollectQty
{
  get { return collectQty; }
  set { collectQty = value; }
}
    }

}
