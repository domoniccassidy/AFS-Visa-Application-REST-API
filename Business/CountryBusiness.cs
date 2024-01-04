using AFS_Visa_Application_REST_API.Data_Contracts.Country;
using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using AFS_Visa_Application_REST_API.Interfaces.Repository;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Business
{
    public class CountryBusiness : ICountryBusiness
    {
        private ICountryRepository _countryRepository;
        private IMapper _mapper;

        public CountryBusiness(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public Guid Create(AddEditCountryDto country)
        {
            var countryEntity = _mapper.Map<Country>(country);
            return _countryRepository.Create(countryEntity);
        }

        public List<CountryDto> Get()
        {
            return _mapper.Map<List<CountryDto>>(_countryRepository.Get());
        }

        public CountryDto GetById(Guid id)
        {
            return _mapper.Map<CountryDto>(_countryRepository.GetById(id));
        }

        public Guid Update(AddEditCountryDto country)
        {
            var countryEntity = _mapper.Map<Country>(country);
            return _countryRepository.Update(countryEntity);
        }
    }
}
