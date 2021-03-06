using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace netCoreMongoDbApi.Domain.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> ListAsync();
        void Update(TEntity obj);
        void Remove(Guid id);
        void RemoveAll();
    }
}
