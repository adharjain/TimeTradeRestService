using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bestbuy.Rest.Timetrade.Service.Entities
{
    public class AppointmentCriteria
    {
        public string ActivityExternalId { get; set; }

        public int AppointmentDurationMin { get; set; }

        public string CampaignExternalId { get; set; }

        public string CampaignTimezone { get; set; }

        public string ClientExternalId { get; set; }

        public string ClientTimezone { get; set; }

        public string LocationExternalId { get; set; }

        public int NumberOfAttendees { get; set; }

        public string ProgramExternalId { get; set; }

        public string ResourceExternalId { get; set; }

        public string ResourcepoolExternalId { get; set; }

        public int SetupDurationMin { get; set; }
    }
}