using AFS_Visa_Application_REST_API.Data_Contracts.Country;
using AFS_Visa_Application_REST_API.Interfaces.Business;

namespace AFS_Visa_Application_REST_API.Router
{
    public static class CountryRouter
    {
        private const string DefaultRoute = "Country";
        public static void ConfigureCountryEndpoints(this WebApplication app) 
        {
            app.MapGet(DefaultRoute, GetCountries);
            app.MapGet(DefaultRoute + "/{id:guid}", GetCountryById).RequireAuthorization("authorised_visa_applicant");
            app.MapPut(DefaultRoute + "/{id:guid}", UpdateCountry).RequireAuthorization("authorised_visa_applicant");
            app.MapPost(DefaultRoute, CreateCountry).RequireAuthorization("authorised_visa_applicant");
        }

        private async static Task<IResult> GetCountries(ICountryBusiness _countryBusiness)
        {
            var countrys = _countryBusiness.Get();
            return Results.Ok(countrys);
        }

        private async static Task<IResult> GetCountryById(ICountryBusiness _countryBusiness, Guid id)
        {
            var country = _countryBusiness.GetById(id);
            return Results.Ok(country);
        }

        private async static Task<IResult> UpdateCountry(ICountryBusiness _countryBusiness, AddEditCountryDto country)
        {
            var countryId = _countryBusiness.Update(country);
            return Results.Ok(countryId);
        }

        private async static Task<IResult> CreateCountry(ICountryBusiness _countryBusiness, AddEditCountryDto country)
        {
            var countryId = _countryBusiness.Create(country);
            return Results.Ok(countryId);
        }
    }
}
