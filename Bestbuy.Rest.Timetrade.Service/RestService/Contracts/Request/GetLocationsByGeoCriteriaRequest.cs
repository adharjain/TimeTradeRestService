namespace Bestbuy.Rest.Timetrade.Service.Contracts.Request
{
    public class GetLocationsByGeoCriteriaRequest
    {
        public System.DateTime createDate{ get; set; }

        public bool createDateFieldSpecified;

        public string locationExternalId{ get; set; }

        public string locationName{ get; set; }

        public string locationUrl{ get; set; }

        public string state{ get; set; }

        public string zipCode{ get; set; }

        public string locationGroupExtId{ get; set; }

        public string locationGroupName{ get; set; }

        public string[] locationExtIdsList{ get; set; }

        public int locationGroupId{ get; set; }

        public bool exactMatchOnly{ get; set; }
    }
}