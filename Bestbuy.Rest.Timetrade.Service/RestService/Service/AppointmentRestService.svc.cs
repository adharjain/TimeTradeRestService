using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

using Bestbuy.Rest.Timetrade.Service.Contracts.Request;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;

namespace Bestbuy.Rest.Timetrade.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AppointmentRestService : IAppointmentRestService
    {
        private readonly HttpContext context;
        public AppointmentRestService()
        {
            context = HttpContext.Current;
        }

        #region AppendAppointmentAnswers Members
        public AppendAppointmentAnswersResponse AppendAppointmentAnswers(AppendAppointmentAnswersRequest jsonRequest)
        {
            return new AppointmentServiceManager().AppendAppointmentAnswers(jsonRequest);
        }

        public BookAppointmentResponse BookAppointment(BookAppointmentRequest jsonRequest)
        {
            return new AppointmentServiceManager().BookAppointment(jsonRequest);
        }

        #endregion
    }
}