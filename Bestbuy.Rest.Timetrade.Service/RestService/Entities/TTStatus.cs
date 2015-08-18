using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bestbuy.Rest.Timetrade.Service.Entities
{
    [DataContract]
    public class TTStatus
    {
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public string Cause { get; set; }
    }
}