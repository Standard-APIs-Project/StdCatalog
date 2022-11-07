using Domain.Entities;


namespace StdCatalog.Persistence.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Guid id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);

    }
}