using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Data_Contracts.VisaApplicationApplicationAdditionalInformation
{
    public class VisaApplicationApplicationAdditionalInformationDto : IDataContract
    {
        public Guid VisaApplicationId { get; set; }
        public Guid AdditionalInformationId { get; set; }
        public string AdditionalInformationEntered { get; set; }

    }
}