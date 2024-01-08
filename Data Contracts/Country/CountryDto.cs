using AFS_Visa_Application_REST_API.Data_Contracts.Base;
using AFS_Visa_Application_REST_API.Data_Contracts.Branch;

namespace AFS_Visa_Application_REST_API.Data_Contracts.Country
{
    public class CountryDto : IDataContract
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public List<BranchDto> Branch { get; set; }
    }
}
