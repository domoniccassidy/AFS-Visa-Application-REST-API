using AFS_Visa_Application_REST_API.Business;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using AFS_Visa_Application_REST_API.Interfaces.Repository;
using AFS_Visa_Application_REST_API.Repository;
using AutoMapper;

namespace AFS_Visa_Application_REST_API.Service
{
    public static class ServiceHandler
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ICountryRepository, CountryRepository>();
            builder.Services.AddScoped<ICountryBusiness, CountryBusiness>();
            builder.Services.AddScoped<IVisaApplicationRepository, VisaApplicationRepository>();
            builder.Services.AddScoped<IVisaApplicationBusiness, VisaApplicationBusiness>();
            builder.Services.AddScoped<IVisaRepository,  VisaRepository>();
            builder.Services.AddScoped<IVisaBusiness, VisaBusiness>();
            builder.Services.AddScoped<IMapper, Mapper>();
        }
    }
}
