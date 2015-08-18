namespace Bestbuy.Rest.Timetrade.Service.Contracts.Response
{
    public enum appointmentLifeCycleState
    {

        /// <remarks/>
        None,

        /// <remarks/>
        Scheduled,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Checked In")]
        CheckedIn,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In Progress")]
        InProgress,

        /// <remarks/>
        Completed,

        /// <remarks/>
        Cancelled,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No Show")]
        NoShow,
    }
}