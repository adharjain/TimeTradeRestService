using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bestbuy.Rest.Timetrade.Service.AppointmentService;
using System.Runtime.Serialization;
using Bestbuy.Rest.Timetrade.Service.Entities;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Request
{
    [DataContract]
    public class BookAppointmentRequest
    {
        [DataMember]
        public AppointmentCriteria AppointmentCriteria { get; set; }
        [DataMember]
        public string StartDateTime { get; set; }
        [DataMember]
        public string ExternalClientId { get; set; }
    }
}