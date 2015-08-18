using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Bestbuy.Rest.Timetrade.Service.Contracts.Request;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;

namespace Bestbuy.Rest.Timetrade.Service.Service.ServiceContract
{
    public interface IConfigReservationRestService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
                    RequestFormat = WebMessageFormat.Json,
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "api/appointmentservices/AppendAppointmentAnswers")]
        GetLocationsByGeoCriteriaResponse GetLocationsByGeoCriteria(GetLocationsByGeoCriteriaRequest jsonRequest);


    }
}
