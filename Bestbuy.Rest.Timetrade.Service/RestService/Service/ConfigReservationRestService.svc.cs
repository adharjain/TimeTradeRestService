using Bestbuy.Rest.Timetrade.Service.Service.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using Bestbuy.Rest.Timetrade.Service.SoapManager;
using Bestbuy.Rest.Timetrade.Service.Contracts.Request;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;

namespace Bestbuy.Rest.Timetrade.Service.Service
{
    public class ConfigReservationRestService : IConfigReservationRestService
    {
        private readonly HttpContext context;
        public ConfigReservationRestService()
        {
            context = HttpContext.Current;
        }

        public GetLocationsByGeoCriteriaResponse GetLocationsByGeoCriteria(GetLocationsByGeoCriteriaRequest jsonRequest)
        {
            return new ConfigReservationServiceManager().GetLocationsByGeoCriteria(jsonRequest);
        }
    }
}
