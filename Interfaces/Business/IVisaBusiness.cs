using AFS_Visa_Application_REST_API.Data_Contracts.Visa;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface IVisaBusiness : IBusiness<VisaDto, AddEditVisaDto>
    {
        List<VisaDto> GetVisasByHomeAndDestinationCountry(Guid homeCountryId, Guid destinationCountryId);
    }
}
