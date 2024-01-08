using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Data_Contracts.Country
{
    public class AddEditCountryDto : IDataContract
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }
    }
}
