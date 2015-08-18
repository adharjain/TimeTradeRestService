using Bestbuy.Rest.Timetrade.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Response
{
    [DataContract]
    public class AppendAppointmentAnswersResponse
    {
        [DataMember]
        public TTStatus TTStatus { get; set; }
    }

    [DataContract]
    public class BookAppointmentResponse 
    {
        [DataMember]
        public TTStatus TTStatus { get; set; }
    }

    [DataContract]
    public class GetAppointmentsByCriteriaCreateDateRangeResponse
    {
        [DataMember]
        public TTStatus TTStatus { get; set; }
        [DataMember]
        public TTStatus[] Result { get; set; }
        [DataMember]
        public Appointment[] Appointments { get; set; }
    }
}