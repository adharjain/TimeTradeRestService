using Bestbuy.Rest.Timetrade.Service.ConfigReservationService;
using System.Runtime.Serialization;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Response
{
    [DataContract]
    public class GetLocationsByGeoCriteriaResponse
    {
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public string Cause { get; set; }

        public TTStatus status{ get; set; }

        public TTStatus[] result{ get; set; }

        public location[] locations{ get; set; }
    }
}