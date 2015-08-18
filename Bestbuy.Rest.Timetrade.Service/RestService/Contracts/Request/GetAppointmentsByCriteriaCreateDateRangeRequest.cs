using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Request
{
    [DataContract]
    public class GetAppointmentsByCriteriaCreateDateRangeRequest
    {
        [DataMember]
        public string ActivityExternalId { get; set; }
        [DataMember]
        public string CampaignExternalId { get; set; }
        [DataMember]
        public string ClientExternalId { get; set; }
        [DataMember]
        public string LocationExternalId { get; set; }
        [DataMember]
        public string LocationUrl { get; set; }
        [DataMember]
        public string ProgramExternalId { get; set; }
        [DataMember]
        public string ResourceExternalId { get; set; }
        [DataMember]
        public string StartCreateDateTime { get; set; }
        [DataMember]
        public string EndCreateDateTime { get; set; }
    }
}