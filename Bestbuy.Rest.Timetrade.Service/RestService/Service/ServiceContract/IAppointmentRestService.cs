using System.ServiceModel;
using System.ServiceModel.Web;

using Bestbuy.Rest.Timetrade.Service.Contracts.Request;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;

namespace Bestbuy.Rest.Timetrade.Service
{
    [ServiceContract]
    public interface IAppointmentRestService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
                    RequestFormat = WebMessageFormat.Json,
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "api/appointmentservices/AppendAppointmentAnswers")]
        AppendAppointmentAnswersResponse AppendAppointmentAnswers(AppendAppointmentAnswersRequest jsonRequest);

        [OperationContract]
        [WebInvoke(Method = "POST",
                            RequestFormat = WebMessageFormat.Json,
                            ResponseFormat = WebMessageFormat.Json,
                            UriTemplate = "api/appointmentservices/BookAppointment")]
        BookAppointmentResponse BookAppointment(BookAppointmentRequest jsonRequest);

    }
}