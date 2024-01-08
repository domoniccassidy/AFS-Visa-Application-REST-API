namespace AFS_Visa_Application_REST_API.Entity
{
    public class AdditionalInformation : EntityBase
    {
        public Guid AdditionalInformationId { get; set; }
        public string InformationTitle { get; set; }
        public string InformationDataType { get; set; }

        public List<Visa> Visa { get; set; }
    }
}
