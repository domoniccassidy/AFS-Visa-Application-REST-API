using AFS_Visa_Application_REST_API.Data_Contracts;
using AFS_Visa_Application_REST_API.Data_Contracts.VisaApplication;
using AFS_Visa_Application_REST_API.Entity;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface IVisaApplicationBusiness
    {
        List<VisaApplicationDto> Get();
        VisaApplicationDto GetById(Guid id);
        Guid Create(AddEditVisaApplicationDto visaApplication);
        Guid Update(AddEditVisaApplicationDto visaApplication);
    }
}
