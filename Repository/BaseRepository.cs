using AFS_Visa_Application_REST_API.Db;
using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Repository;

namespace AFS_Visa_Application_REST_API.Repository
{
    public class BaseRepository<T> : IRepository<T> where T: EntityBase
    {
        public BaseRepository()
        {
            DB = new VisaApplicationContext();
        }

        protected static VisaApplicationContext DB { get; set; }

        public virtual Guid Create(T entity)
        {
            DB.Set<T>().Add(entity);
            DB.SaveChanges();
            return (Guid) entity.GetType().GetProperty(typeof(T).Name + "Id").GetValue(entity, null);
        }

        public List<T> Get()
        {
            return DB.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return DB.Set<T>().ToList().FirstOrDefault(va => (Guid) va.GetType().GetProperty(typeof(T).Name + "Id").GetValue(va, null) == id);
        }

        public Guid Update(T entity)
        {
            DB.Update(entity);
            DB.SaveChanges();
            return (Guid) entity.GetType().GetProperty(typeof(T).Name + "Id").GetValue(entity, null);
        }
    }
}
