using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bestbuy.Rest.Timetrade.Service.Contracts.Request;
using Bestbuy.Rest.Timetrade.Service.Contracts.Response;

using Bestbuy.Rest.Timetrade.Service.AppointmentService;
using System.ServiceModel;

namespace Bestbuy.Rest.Timetrade.Service
{
    public class AppointmentServiceManager
    {
        AppointmentServicesClient service = new AppointmentServicesClient();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUI"></param>
        /// <returns></returns>
        public AppendAppointmentAnswersResponse AppendAppointmentAnswers(AppendAppointmentAnswersRequest requestFromUI)
        {
            try
            {
                var request = new List<appointmentAnswer>();
                foreach (var item in requestFromUI.Answers)
                {
                    appointmentAnswer a = new appointmentAnswer()
                    {
                        answer = item.Answer.ToString(),
                        //question = item.Question,
                        questionExternalId = item.QuestionExternalId
                    };
                    request.Add(a);
                }

                //service.ClientCredentials.UserName.UserName = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                //service.ClientCredentials.UserName.Password = System.Configuration.ConfigurationManager.AppSettings["Password"];

                appointmentAnswer[] answers = request.ToArray<appointmentAnswer>();

                var serviceResponse = service.appendAppointmentAnswers(requestFromUI.ConfirmationNumber, answers);
                return new AppendAppointmentAnswersResponse()
                {
                   TTStatus = new Entities.TTStatus()
                   {
                       Cause = serviceResponse.cause,
                       Result = serviceResponse.result,
                       Status = serviceResponse.status
                   }
                };
            }
            catch (FaultException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestFromUI"></param>
        /// <returns></returns>
        public BookAppointmentResponse BookAppointment(BookAppointmentRequest requestFromUI)
        {
            try
            {
                if (requestFromUI == null || requestFromUI.AppointmentCriteria == null)
                    throw new FaultException("Request can not be empty");

                //service.ClientCredentials.UserName.UserName = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                //service.ClientCredentials.UserName.Password = System.Configuration.ConfigurationManager.AppSettings["Password"];

                appointmentCriteria reqCriteria = new appointmentCriteria()
                {
                    activityExternalId = requestFromUI.AppointmentCriteria.ActivityExternalId,
                    appointmentDurationMin = requestFromUI.AppointmentCriteria.AppointmentDurationMin,
                    campaignExternalId = requestFromUI.AppointmentCriteria.CampaignExternalId,
                    campaignTimezone = requestFromUI.AppointmentCriteria.CampaignTimezone,
                    clientExternalId = requestFromUI.AppointmentCriteria.ClientExternalId,
                    clientTimezone = requestFromUI.AppointmentCriteria.ClientTimezone,
                    numberOfAttendees = requestFromUI.AppointmentCriteria.NumberOfAttendees,
                    programExternalId = requestFromUI.AppointmentCriteria.ProgramExternalId,
                    resourceExternalId = requestFromUI.AppointmentCriteria.ResourceExternalId,
                    locationExternalId = requestFromUI.AppointmentCriteria.LocationExternalId,
                    resourcepoolExternalId = requestFromUI.AppointmentCriteria.ResourcepoolExternalId,
                    setupDurationMin = requestFromUI.AppointmentCriteria.SetupDurationMin,
                };

                var serviceResponse = service.bookAppointment(reqCriteria, DateTime.Now, requestFromUI.ExternalClientId);
                return new BookAppointmentResponse()
                {
                    TTStatus = new Entities.TTStatus()
                    {
                        Cause = serviceResponse.cause,
                        Result = serviceResponse.result,
                        Status = serviceResponse.status
                    }
                };
            }
            catch (FaultException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestFromUI"></param>
        /// <returns></returns>
        public GetAppointmentsByCriteriaCreateDateRangeResponse GetAppointmentsByCriteriaCreateDateRange(GetAppointmentsByCriteriaCreateDateRangeRequest requestFromUI)
        {
            try
            {
                service.ClientCredentials.UserName.UserName = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                service.ClientCredentials.UserName.Password = System.Configuration.ConfigurationManager.AppSettings["Password"];

                appointmentSearchCriteria reqCriteria = new appointmentSearchCriteria()
                {
                    activityExternalId = requestFromUI.ActivityExternalId,
                    campaignExternalId = requestFromUI.CampaignExternalId,
                    clientExternalId = requestFromUI.ClientExternalId,
                    programExternalId = requestFromUI.ProgramExternalId,
                    resourceExternalId = requestFromUI.ResourceExternalId,
                    locationExternalId = requestFromUI.LocationExternalId
                };

                appointmentListResult serviceResponse = service.getAppointmentsByCriteriaCreateDateRange(reqCriteria, DateTime.Now, DateTime.Now);

                var appts = new Appointment[] { };
                for (int i = 0; i < serviceResponse.appointments.Count(); i++)
                {
                    appts[i] = new Appointment()
                    {
                        activityExternalId = serviceResponse.appointments[i].activityExternalId,
                        activityName = serviceResponse.appointments[i].activityName,
                        appointmentDurationMin = serviceResponse.appointments[i].appointmentDurationMin.ToString(),
                        appointmentEndDate = serviceResponse.appointments[i].appointmentEndDate.ToString(),
                        appointmentStartDate = serviceResponse.appointments[i].appointmentStartDate.ToString(),
                        apptOriginName = serviceResponse.appointments[i].apptOriginName,
                        campaignExternalId = serviceResponse.appointments[i].campaignExternalId,
                        campaignName = serviceResponse.appointments[i].campaignName,
                        campaignTimezone = serviceResponse.appointments[i].campaignTimezone,
                        cancelled = serviceResponse.appointments[i].cancelled.ToString(),
                        checkedIn = serviceResponse.appointments[i].checkedIn.ToString(),
                        checkedOut = serviceResponse.appointments[i].checkedOut.ToString(),
                        clientExternalId = serviceResponse.appointments[i].clientExternalId,
                        clientFirstname = serviceResponse.appointments[i].clientFirstname,
                        clientLastname = serviceResponse.appointments[i].clientLastname,
                        clientTimezone = serviceResponse.appointments[i].clientTimezone,
                        compoundAppointmentConfirmationNumber = serviceResponse.appointments[i].compoundAppointmentConfirmationNumber,
                        confirmationNumber = serviceResponse.appointments[i].confirmationNumber,
                        confirmed = serviceResponse.appointments[i].confirmed.ToString(),
                        createdByExtUserId = serviceResponse.appointments[i].createdByExtUserId,
                        createdByUserName = serviceResponse.appointments[i].createdByUserName,
                        createdDate = serviceResponse.appointments[i].createdDate,
                        custom0 = serviceResponse.appointments[i].custom0,
                        custom1 = serviceResponse.appointments[i].custom1,
                        custom3 = serviceResponse.appointments[i].custom3,
                        custom2 = serviceResponse.appointments[i].custom2,
                        custom4 = serviceResponse.appointments[i].custom4,
                        custom5 = serviceResponse.appointments[i].custom5,
                        comments = serviceResponse.appointments[i].comments,
                        custom6 = serviceResponse.appointments[i].custom6,
                        custom7 = serviceResponse.appointments[i].custom7,
                        custom8 = serviceResponse.appointments[i].custom8,
                        custom9 = serviceResponse.appointments[i].custom9,
                        lastModifiedDateTime = serviceResponse.appointments[i].lastModifiedDateTime,
                        lateCanceled = serviceResponse.appointments[i].lateCanceled.ToString(),
                        locationExternalId = serviceResponse.appointments[i].locationExternalId,
                        numberOfAttendees = serviceResponse.appointments[i].numberOfAttendees.ToString(),
                        programExternalId = serviceResponse.appointments[i].programExternalId,
                        programName = serviceResponse.appointments[i].programName,
                        resourceExternalId = serviceResponse.appointments[i].resourceExternalId,
                        resourceName = serviceResponse.appointments[i].resourceName,
                        setupDurationMin = serviceResponse.appointments[i].setupDurationMin.ToString(),
                        walkIn = serviceResponse.appointments[i].walkIn.ToString(),
                        workFlowId = serviceResponse.appointments[i].workFlowId
                    };
                }

                var response = new GetAppointmentsByCriteriaCreateDateRangeResponse()
                {
                    Appointments = appts,
                    TTStatus = new Entities.TTStatus()
                    {
                        Cause = serviceResponse.status.cause,
                        Result = serviceResponse.status.result,
                        Status = serviceResponse.status.status
                    }
                };

                for (int i = 0; i < serviceResponse.result.Length; i++)
                {
                    response.Result[i].Cause = serviceResponse.result[i].cause;
                    response.Result[i].Result = serviceResponse.result[i].result;
                    response.Result[i].Status = serviceResponse.result[i].status;
                }
                return response;
            }
            catch (FaultException exception)
            {
                throw exception;
            }
        }

    }
}
