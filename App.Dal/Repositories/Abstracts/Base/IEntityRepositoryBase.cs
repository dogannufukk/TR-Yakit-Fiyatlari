using App.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.Repositories.Abstracts.Base
{
    public interface IEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        Task AddAsync(T entity);
        void Update(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetAllAsyncWithIncludeTable(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> GetAsyncWithIncludeTable(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);
        void Delete(long id);
        Task AddRangeAsync(IEnumerable<T> entities);
    }
}
