namespace AFS_Visa_Application_REST_API.Entity
{
    public class Appointment : EntityBase
    {
        public Guid AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Branch Branch { get; set; }
    }
}
