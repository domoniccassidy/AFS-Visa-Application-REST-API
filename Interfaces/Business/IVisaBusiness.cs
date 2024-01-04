using AFS_Visa_Application_REST_API.Data_Contracts.Visa;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface IVisaBusiness
    {
        List<VisaDto> Get();
        VisaDto GetById(Guid id);
        Guid Create(AddEditVisaDto visa);
        Guid Update(AddEditVisaDto visa);
        List<VisaDto> GetVisasByHomeAndDestinationCountry(Guid homeCountryId, Guid destinationCountryId);
    }
}
