using AFS_Visa_Application_REST_API.Data_Contracts.DocumentationRequired;

namespace AFS_Visa_Application_REST_API.Data_Contracts.Visa
{
    public class VisaDto
    {
        public Guid VisaId { get; set; }
        public string VisaType { get; set; }
        public bool AppointmentRequired { get; set; }
        public float Price { get; set; }
        public int DaysValid { get; set; }
        public int? EntryTimes { get; set; }

        public List<DocumentationRequiredDto> DocumentationRequired { get; set; }
    }
}
