using AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication;
using AFS_Visa_Application_REST_API.Interfaces.Business;
using System;

namespace AFS_Visa_Application_REST_API.Router
{
    public static class VisaApplicationRouter
    {
        private const string DefaultRoute = "VisaApplication";
        public static void ConfigureVisaApplicationEndpoints(this WebApplication app) 
        {
            app.MapGet(DefaultRoute, GetVisaApplications).RequireAuthorization("authorised_visa_applicant");
            app.MapGet(DefaultRoute + "/{id:guid}", GetVisaApplicationById).RequireAuthorization("authorised_visa_applicant");
            app.MapPut(DefaultRoute + "/{id:guid}", UpdateVisaApplication).RequireAuthorization("authorised_visa_applicant");
            app.MapPost(DefaultRoute, CreateVisaApplication).RequireAuthorization("authorised_visa_applicant");
        }

        private async static Task<IResult> GetVisaApplications(IVisaApplicationBusiness _visaApplicationBusiness)
        {
            var applications = _visaApplicationBusiness.Get();
            return Results.Ok(applications);
        }

        private async static Task<IResult> GetVisaApplicationById(IVisaApplicationBusiness _visaApplicationBusiness, Guid id)
        {
            var application = _visaApplicationBusiness.GetById(id);
            return Results.Ok(application);
        }

        private async static Task<IResult> UpdateVisaApplication(IVisaApplicationBusiness _visaApplicationBusiness, AddEditVisaApplicationDto visaApplication)
        {
            var applicationId = _visaApplicationBusiness.Update(visaApplication);
            return Results.Ok(applicationId);
        }

        private async static Task<IResult> CreateVisaApplication(IVisaApplicationBusiness _visaApplicationBusiness, AddEditVisaApplicationDto visaApplication)
        {
            var applicationId = _visaApplicationBusiness.Create(visaApplication);
            return Results.Ok(applicationId);
        }
    }
}
