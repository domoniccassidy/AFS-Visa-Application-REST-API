    using System.ComponentModel.DataAnnotations.Schema;

namespace AFS_Visa_Application_REST_API.Entity
{
    public class VisaApplication : EntityBase
    {
        public Guid VisaApplicationId { get; set; }
        public Guid OriginCountryId { get; set; }
        public Guid DestinationCountryId { get; set; }
        public Guid VisaId { get; set; }
        public Guid BranchId { get; set; }
        public Guid? AppointmentId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Visa Visa { get; set; }  
        public Branch Branch { get; set; }
        public Appointment Appointment { get; set; }    
    }
}