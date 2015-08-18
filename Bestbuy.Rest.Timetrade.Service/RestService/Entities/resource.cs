namespace Bestbuy.Rest.Timetrade.Service.Contracts.Response
{
    public class Resource
    {
        public string deleted{ get; set; }

        public System.DateTime deletedDate{ get; set; }

        public string deletedDateFieldSpecified;

        public string description{ get; set; }

        public emailAddressData emailAddressData{ get; set; }

        public Gender gender{ get; set; }

        public string genderFieldSpecified;

        public string isAlwaysAvailable{ get; set; }

        public string isAlwaysAvailableFieldSpecified;

        public string isEnabled{ get; set; }

        public string isEnabledFieldSpecified;

        public string locationExternalId{ get; set; }

        public phoneData phoneData{ get; set; }

        public string propertyGroupExternalId{ get; set; }

        public string resourceExternalId{ get; set; }

        public string resourceName{ get; set; }

        public ResourceRules resourceRules{ get; set; }

        public string timezone{ get; set; }
    }
}