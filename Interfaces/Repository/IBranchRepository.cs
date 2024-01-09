using AFS_Visa_Application_REST_API.Entity;

namespace AFS_Visa_Application_REST_API.Interfaces.Repository
{
    public interface IBranchRepository : IRepository<Branch>
    {
        public List<List<DateTime>> GetAppointmentDates(Guid branchId, DateTime departureDate);
        void BookAppointment(Appointment appointment);
    }
}
