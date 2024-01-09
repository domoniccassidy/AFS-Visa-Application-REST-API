using AFS_Visa_Application_REST_API.Data_Contracts.Appointment;
using AFS_Visa_Application_REST_API.Data_Contracts.Branch;
using AFS_Visa_Application_REST_API.Interfaces.Business;

namespace AFS_Visa_Application_REST_API.Router
{
    public static class BranchRouter 
    {
        private const string DefaultRoute = "Branch";
        public static void ConfigureBranchEndpoints(this WebApplication app) 
        {
            app.MapGet(DefaultRoute, GetCountries).RequireAuthorization("authorised_visa_applicant");
            app.MapGet(DefaultRoute + "/{id:guid}", GetBranchById).RequireAuthorization("authorised_visa_applicant");
            app.MapGet(DefaultRoute + "/Appointment/{id:guid},{departureDate:dateTime}", GetAppointmentDates).RequireAuthorization("authorised_visa_applicant");
            app.MapPut(DefaultRoute + "/{id:guid}", UpdateBranch).RequireAuthorization("authorised_visa_applicant");
            app.MapPost(DefaultRoute, CreateBranch).RequireAuthorization("authorised_visa_applicant");
            app.MapPost(DefaultRoute + "/BookAppointment", BookAppointment).RequireAuthorization("authorised_visa_applicant");
        }

        private async static Task<IResult> GetCountries(IBranchBusiness _branchBusiness)
        {
            var branchs = _branchBusiness.Get();
            return Results.Ok(branchs);
        }

        private async static Task<IResult> GetBranchById(IBranchBusiness _branchBusiness, Guid id)
        {
            var branch = _branchBusiness.GetById(id);
            return Results.Ok(branch);
        }

        private async static Task<IResult> UpdateBranch(IBranchBusiness _branchBusiness, AddEditBranchDto branch)
        {
            var branchId = _branchBusiness.Update(branch);
            return Results.Ok(branchId);
        }

        private async static Task<IResult> CreateBranch(IBranchBusiness _branchBusiness, AddEditBranchDto branch)
        {
            var branchId = _branchBusiness.Create(branch);
            return Results.Ok(branchId);
        }

        private async static Task<IResult> GetAppointmentDates(IBranchBusiness _branchBusiness, Guid id, DateTime departureDate)
        {
            var appointmentDates = _branchBusiness.GetAppointmentDates(id, departureDate);
            return Results.Ok(appointmentDates); 
        }

        private async static Task<IResult> BookAppointment(IBranchBusiness _branchBusiness, AddEditAppointmentDto appointment)
        {
            _branchBusiness.BookAppointment(appointment);
            return Results.Ok(appointment.AppointmentId);
        }
    }
}
