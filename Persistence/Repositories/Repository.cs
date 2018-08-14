using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using switch_api.Core.Repositories;

namespace switch_api.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> entities;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            entities = this.dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this.entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.entities.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.entities.Where(predicate);
        }

        public async Task<TEntity> Get(Guid id)
        {
            return await this.entities.FindAsync(id);
        }

        public async Task<TEntity> Get(int id)
        {
            return await this.entities.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await this.entities.ToListAsync();
        }

        public void Remove(TEntity entity)
        {
            this.entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.entities.RemoveRange(entities);
        }
    }
}