using AFS_Visa_Application_REST_API.Entity;

namespace AFS_Visa_Application_REST_API.Interfaces.Repository
{
    public interface IVisaRepository : IRepository<Visa>
    {
        List<Visa> GetVisasByHomeAndDestinationCountry(Guid homeCountryId, Guid destinationCountryId);
    }
}
