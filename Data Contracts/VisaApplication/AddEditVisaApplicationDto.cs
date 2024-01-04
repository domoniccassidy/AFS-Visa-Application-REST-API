namespace AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication
{
    public class AddEditVisaApplicationDto
    {
        public Guid VisaApplicationId { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid OriginCountryId { get; set; }
        public Guid DestinationCountryId { get; set; }
        public Guid AgentAssignedToId { get; set; }
        public Guid VisaId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
