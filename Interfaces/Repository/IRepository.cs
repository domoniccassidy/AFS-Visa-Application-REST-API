namespace AFS_Visa_Application_REST_API.Interfaces.Repository
{
    public interface IRepository<T>
    {
        List<T> Get();
        T GetById(Guid id);
        Guid Create(T entity);
        Guid Update(T entity);
    }
}
