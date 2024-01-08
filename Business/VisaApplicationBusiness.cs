using AFS_Visa_Application_REST_API.Data_Contracts;
using AFS_Visa_Application_REST_API.Data_Contracts.Documentation;
using AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication;
using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using AFS_Visa_Application_REST_API.Interfaces.Repository;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Business
{
    public class VisaApplicationBusiness: IVisaApplicationBusiness
    {
        private IVisaApplicationRepository _visaApplicationRepository;
        private IMapper _mapper; 
        public VisaApplicationBusiness(IVisaApplicationRepository visaApplicationRepository, IMapper mapper)
        {
            _visaApplicationRepository = visaApplicationRepository;
            _mapper = mapper;
        }

        public Guid Create(AddEditVisaApplicationDto visaApplication)
        {
            var visaApplicationEntity = _mapper.Map<VisaApplication>(visaApplication);
            return _visaApplicationRepository.Create(visaApplicationEntity);
        }

        public List<VisaApplicationDto> Get()
        {
            return _mapper.Map<List<VisaApplicationDto>>(_visaApplicationRepository.Get());
        }

        public VisaApplicationDto GetById(Guid id)
        {
            return _mapper.Map<VisaApplicationDto>(_visaApplicationRepository.GetById(id));
        }

        public Guid Update(AddEditVisaApplicationDto visaApplication)
        {
            var visaApplicationEntity = _mapper.Map<VisaApplication>(visaApplication);
            return _visaApplicationRepository.Update(visaApplicationEntity);
        }

        private void UploadDocumentation(List<DocumentationDto> documentation)
        {
            foreach (var document in documentation)
            {
                // Upload docuemntation to blob storage
            }
        }
    }
}
