using App.Dal.Extensions.EntityFrameworkExtensions;
using App.Dal.Repositories.Abstracts.Base;
using App.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Dal.Repositories.Concretes.Base
{
    public class EntityRepositoryBase<T> : IEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        protected DbContext _dbContext;
        protected DbSet<T> _dbSet;
        public EntityRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Delete(long id)
        {
            var obj = _dbSet.Find(id);
            _dbSet.Remove(obj);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? await _dbSet.Where(filter).ToListAsync() : await _dbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsyncWithIncludeTable(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbSet;
            var list = filter != null ? entities.AsNoTracking().Where(filter).AsQueryable() : entities.AsNoTracking().AsQueryable();
            entities = entities.IncludeMultiple(includes);
            return await entities.AsQueryable().ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetAsyncWithIncludeTable(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbSet;
            entities = entities.IncludeMultiple(includes);
            return await entities.SingleOrDefaultAsync(filter);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
