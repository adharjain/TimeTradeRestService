using Bestbuy.Rest.Timetrade.Service.AppointmentService;

namespace Bestbuy.Rest.Timetrade.Service.Contracts.Response
{
    public class Appointment
    {
        public string activityExternalId{ get; set; }

        public string activityName{ get; set; }

        public string appointmentDurationMin{ get; set; }

        public  string  appointmentEndDate{ get; set; }

        public string appointmentEndDateFieldSpecified;

        public  string  appointmentStartDate{ get; set; }

        public string appointmentStartDateFieldSpecified;

        public string apptOriginName{ get; set; }

        public string campaignExternalId{ get; set; }

        public string campaignName{ get; set; }

        public string campaignTimezone{ get; set; }

        public string cancelled{ get; set; }

        public string checkedIn{ get; set; }

        public string checkedOut{ get; set; }

        public string clientExternalId{ get; set; }

        public string clientFirstname{ get; set; }

        public string clientLastname{ get; set; }

        public string clientTimezone{ get; set; }

        public string confirmationNumber{ get; set; }

        public string confirmed{ get; set; }

        public string createdByExtUserId{ get; set; }

        public string createdByUserName{ get; set; }

        public string createdDate{ get; set; }

        public string custom0{ get; set; }

        public string custom1{ get; set; }

        public string custom2{ get; set; }

        public string custom3{ get; set; }

        public string custom4{ get; set; }

        public string custom5{ get; set; }

        public string custom6{ get; set; }

        public string custom7{ get; set; }

        public string custom8{ get; set; }

        public string custom9{ get; set; }

        public string lateCanceled{ get; set; }

        public string locationExternalId{ get; set; }

        public string numberOfAttendees{ get; set; }

        public string programExternalId{ get; set; }

        public string programName{ get; set; }

        public string resourceExternalId{ get; set; }

        public ResourcePool resourcepool{ get; set; }

        public string setupDurationMin{ get; set; }

        public string walkIn{ get; set; }

        public string comments{ get; set; }

        public string workFlowId{ get; set; }

        public Characteristic[] Characteristics{ get; set; }

        public string compoundAppointmentConfirmationNumber{ get; set; }

        public AppointmentLifeCycleState lifeCycleState{ get; set; }

        public string lifeCycleStateFieldSpecified;

        public string lastModifiedDateTime{ get; set; }

        public string resourceName{ get; set; }
    }
}