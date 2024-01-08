using AFS_Visa_Application_REST_API.Data_Contracts.Branch;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface IBranchBusiness : IBusiness<BranchDto, AddEditBranchDto>
    {
        public List<List<DateTime>> GetAppointmentDates(Guid branchId, DateTime departureDate);
    }
}
