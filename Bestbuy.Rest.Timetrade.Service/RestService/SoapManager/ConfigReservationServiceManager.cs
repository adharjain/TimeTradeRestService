using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bestbuy.Rest.Timetrade.Service.ConfigReservationService;
using System.ServiceModel;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;
using Bestbuy.Rest.Timetrade.Service.Contracts.Request;

namespace Bestbuy.Rest.Timetrade.Service.SoapManager
{
    public class ConfigReservationServiceManager
    {
        ConfigurationServicesClient service = new ConfigurationServicesClient();
        public GetLocationsByGeoCriteriaResponse GetLocationsByGeoCriteria(GetLocationsByGeoCriteriaRequest requestFromUI)
        {
            try
            {
                locationSearchCriteria c = new locationSearchCriteria()
                {
                    createDate = requestFromUI.createDate,
                    exactMatchOnly = requestFromUI.exactMatchOnly,
                    locationExternalId = requestFromUI.locationExternalId,
                    locationExtIdsList = requestFromUI.locationExtIdsList,
                    locationGroupExtId = requestFromUI.locationGroupExtId,
                    locationGroupId = requestFromUI.locationGroupId,
                    locationGroupName = requestFromUI.locationGroupName,
                    locationName = requestFromUI.locationName,
                    locationUrl = requestFromUI.locationUrl,
                    state = requestFromUI.state,
                    zipCode = requestFromUI.zipCode
                };

                locationListResult serviceResponse = service.getLocationsByCriteria(c);

                GetLocationsByGeoCriteriaResponse response = new GetLocationsByGeoCriteriaResponse();
                response.locations = serviceResponse.locations;
                response.result = serviceResponse.result;
                response.status = serviceResponse.status;
            }
            catch (FaultException exception)
            {
                throw exception;
            }
            return new GetLocationsByGeoCriteriaResponse();
        }
    }

}