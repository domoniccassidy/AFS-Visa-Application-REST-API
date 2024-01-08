using AFS_Visa_Application_REST_API.Data_Contracts.Base;
using AFS_Visa_Application_REST_API.Data_Contracts.Documentation;

namespace AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication
{
    public class AddEditVisaApplicationDto : IDataContract
    {
        public Guid VisaApplicationId { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid OriginCountryId { get; set; }
        public Guid DestinationCountryId { get; set; }
        public Guid AgentAssignedToId { get; set; }
        public Guid VisaId { get; set; }
        public Guid AppointmentId { get; set; }

        public List<Guid> VisaApplicationApplicationAdditionalInformation { get; set; }
        public List<DocumentationDto> Documentation { get; set; }
    }
}
