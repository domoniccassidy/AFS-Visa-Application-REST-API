using AFS_Visa_Application_REST_API.Data_Contracts.Country;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface ICountryBusiness
    {
        List<CountryDto> Get();
        CountryDto GetById(Guid id);
        Guid Create(AddEditCountryDto country);
        Guid Update(AddEditCountryDto country);
    }
}
