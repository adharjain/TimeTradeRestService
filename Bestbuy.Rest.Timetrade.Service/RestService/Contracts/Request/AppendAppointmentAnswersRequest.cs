using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Request
{
    [DataContract]
    public class AppointmentAnswer
    {
        [DataMember]
        public int Answer { get; set; }
        [DataMember]
        public string Question { get; set; }
        [DataMember]
        public string QuestionExternalId { get; set; }
    }

    [DataContract]
    public class AppendAppointmentAnswersRequest
    {
        [DataMember]
        public AppointmentAnswer[] Answers { get; set; }
        [DataMember]
        public string ConfirmationNumber { get; set; }
    }
}