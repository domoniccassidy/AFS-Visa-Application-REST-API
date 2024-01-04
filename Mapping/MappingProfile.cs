using AFS_Visa_Application_REST_API.Data_Contracts;
using AFS_Visa_Application_REST_API.Data_Contracts.Country;
using AFS_Visa_Application_REST_API.Data_Contracts.DocumentationRequired;
using AFS_Visa_Application_REST_API.Data_Contracts.Visa;
using AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication;
using AFS_Visa_Application_REST_API.Entity;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<AddEditCountryDto, Country>();
            CreateMap<DocumentationRequired, DocumentationRequiredDto>();
            CreateMap<Visa, VisaDto>();
            CreateMap<AddEditVisaDto, Visa>().ForMember(entity => entity.CountriesExempt, mapper => mapper.MapFrom(dto => dto.CountriesExempt.Select(countryId => new Country() { CountryId = countryId })));
            CreateMap<VisaApplication, VisaApplicationDto>();
            CreateMap<AddEditVisaApplicationDto, VisaApplication>();
        }
    }
}
