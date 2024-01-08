namespace AFS_Visa_Application_REST_API.Entity
{
    public class Visa : EntityBase
    {
        public Guid VisaId { get; set; }
        public Guid CountryId { get; set; }
        public string VisaType { get; set; }
        public bool AppointmentRequired { get; set; }
        public float Price { get; set; }
        public int DaysValid { get; set; }
        public int? EntryTimes { get; set; }

        public Country OfferingCountry { get; set; }
        public List<VisaApplication> VisaApplications { get; set; }
        public List<Country> CountriesExempt { get; set; }
        public List<DocumentationRequired> DocumentationRequired { get; } = new();
        public List<AdditionalInformation> AdditionalInformation { get; } = new();
    }
}
    