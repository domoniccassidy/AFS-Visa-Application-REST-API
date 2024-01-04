using AFS_Visa_Application_REST_API.Data_Contracts;
using AFS_Visa_Application_REST_API.Data_Contracts.Visa;
using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using AFS_Visa_Application_REST_API.Interfaces.Repository;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Business
{
    public class VisaBusiness : IVisaBusiness
    {
        private IVisaRepository _visaRepository;
        private IMapper _mapper;
        public VisaBusiness(IVisaRepository visaRepository, IMapper mapper)
        {
            _visaRepository = visaRepository;
            _mapper = mapper;
        }
        public Guid Create(AddEditVisaDto visa)
        {
            var visaEntity = _mapper.Map<Visa>(visa);
            return _visaRepository.Create(visaEntity);
        }

        public List<VisaDto> Get()
        {
            return _mapper.Map<List<VisaDto>>(_visaRepository.Get());
        }

        public VisaDto GetById(Guid id)
        {
            return _mapper.Map<VisaDto>(_visaRepository.GetById(id));
        }

        public List<VisaDto> GetVisasByHomeAndDestinationCountry(Guid homeCountryId, Guid destinationCountryId)
        {
            return _mapper.Map<List<VisaDto>>(_visaRepository.GetVisasByHomeAndDestinationCountry(homeCountryId, destinationCountryId));
        }

        public Guid Update(AddEditVisaDto visa)
        {
            var visaEntity = _mapper.Map<Visa>(visa);
            return _visaRepository.Update(visaEntity);
        }
    }
}
