    using System.ComponentModel.DataAnnotations.Schema;

namespace AFS_Visa_Application_REST_API.Entity
{
    public class VisaApplication : EntityBase
    {
        public Guid VisaApplicationId { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid OriginCountryId { get; set; }
        public Guid DestinationCountryId { get; set; }
        public Guid AgentAssignedToId { get; set; }
        public Guid VisaId { get; set; }

        public Visa Visa { get; set; }  
        public Branch Branch { get; set; }
        public Appointment Appointment { get; set; }    
    }
}