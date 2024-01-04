using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Repository;

namespace AFS_Visa_Application_REST_API.Repository
{
    public class VisaRepository : BaseRepository<Visa>, IVisaRepository
    {
        public List<Visa> GetVisasByHomeAndDestinationCountry(Guid homeCountryId, Guid destinationCountryId)
        {
            return DB.Set<Visa>().Where(v => homeCountryId != destinationCountryId && !v.CountriesExempt.Any(ce => ce.CountryId == homeCountryId) && v.CountryId == destinationCountryId).ToList();
        }
        public override Guid Create(Visa entity)
        {
            foreach (var country in entity.CountriesExempt)
            {
                DB.Country.Attach(country);
            }
            DB.Set<Visa>().Add(entity);
            DB.SaveChanges();
            return (Guid)entity.GetType().GetProperty(typeof(Visa).Name + "Id").GetValue(entity, null);
        }
    }
}
