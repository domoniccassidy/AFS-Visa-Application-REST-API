using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Data_Contracts.Appointment
{
    public class AddEditAppointmentDto : IDataContract
    {
        public Guid AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Guid BranchId { get; set; }
    }
}
