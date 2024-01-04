namespace AFS_Visa_Application_REST_API.Data_Contracts.Visa
{
    public class AddEditVisaDto
    {
        public Guid VisaId { get; set; }
        public Guid CountryId { get; set; }
        public string VisaType { get; set; }
        public bool AppointmentRequired { get; set; }
        public float Price { get; set; }
        public int DaysValid { get; set; }
        public int? EntryTimes { get; set; }

        public List<Guid> CountriesExempt { get; set; }
    }
}
