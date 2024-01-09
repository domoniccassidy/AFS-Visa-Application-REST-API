using AFS_Visa_Application_REST_API.Data_Contracts.Base;
using AFS_Visa_Application_REST_API.Data_Contracts.VisaApplicationApplicationAdditionalInformation;

namespace AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication
{
    public class AddEditVisaApplicationDto : IDataContract
    {
        public Guid VisaApplicationId { get; set; }
        public Guid OriginCountryId { get; set; }
        public Guid DestinationCountryId { get; set; }
        public Guid VisaId { get; set; }
        public Guid BranchId { get; set; }
        public Guid? AppointmentId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate {  get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } 

        public List<VisaApplicationApplicationAdditionalInformationDto> VisaApplicationApplicationAdditionalInformation { get; set; }
    }
}
