using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Interfaces.Business
{
    public interface IBusiness<TOne, TTwo> where TOne : IDataContract
                                           where TTwo : IDataContract
    {
        List<TOne> Get();
        TOne GetById(Guid id);
        Guid Create(TTwo country);
        Guid Update(TTwo country);
    }
}
