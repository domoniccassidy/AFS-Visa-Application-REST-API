using AFS_Visa_Application_REST_API.Data_Contracts.Visa;
using AFS_Visa_Application_REST_API.Interfaces.Business;

namespace AFS_Visa_Application_REST_API.Router
{
    public static class VisaRouter
    {
        private const string DefaultRoute = "Visa";
        public static void ConfigureVisaEndpoints(this WebApplication app) 
        {
            app.MapGet(DefaultRoute, GetVisas).RequireAuthorization("authorised_visa_applicant");
            app.MapGet(DefaultRoute + "/{id:guid}", GetVisaById).RequireAuthorization("authorised_visa_applicant");
            app.MapGet(DefaultRoute + "/{homeCountryId:guid},{destinationCountryId:guid}", GetVisasByHomeAndDestinationCountry).RequireAuthorization("authorised_visa_applicant");
            app.MapPut(DefaultRoute + "/{id:guid}", UpdateVisa).RequireAuthorization("authorised_visa_applicant");
            app.MapPost(DefaultRoute, CreateVisa).RequireAuthorization("authorised_visa_applicant");
        }

        private async static Task<IResult> GetVisas(IVisaBusiness _visaBusiness)
        {
            var visas = _visaBusiness.Get();
            return Results.Ok(visas);
        }

        private async static Task<IResult> GetVisaById(IVisaBusiness _visaBusiness, Guid id)
        {
            var visa = _visaBusiness.GetById(id);
            return Results.Ok(visa);
        }

        private async static Task<IResult> UpdateVisa(IVisaBusiness _visaBusiness, AddEditVisaDto visa)
        {
            var visaId = _visaBusiness.Update(visa);
            return Results.Ok(visaId);
        }

        private async static Task<IResult> CreateVisa(IVisaBusiness _visaBusiness, AddEditVisaDto visa)
        {
            var visaId = _visaBusiness.Create(visa);
            return Results.Ok(visaId);
        }

        private async static Task<IResult> GetVisasByHomeAndDestinationCountry(IVisaBusiness _visaBusiness, Guid homeCountryId, Guid destinationCountryId)
        {
            var visas = _visaBusiness.GetVisasByHomeAndDestinationCountry(homeCountryId, destinationCountryId);
            return Results.Ok(visas);
        }
    }
}
