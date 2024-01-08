using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Data_Contracts.Branch
{
    public class BranchDto : IDataContract
    {
        public Guid BranchId { get; set; }
        public Guid CountryId { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
    }
}
