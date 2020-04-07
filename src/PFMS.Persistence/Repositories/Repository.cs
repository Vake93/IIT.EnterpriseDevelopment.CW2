using Microsoft.EntityFrameworkCore;
using PFMS.Domain;
using PFMS.Domain.Models;
using PFMS.Persistence.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        public Repository(DatabaseContext context)
        {
            Context = context;
        }

        protected DatabaseContext Context { get; }

        public void Add(
            TEntity entity)
        {
            Context.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Context.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
        }

        public Task<bool> AnyAsync(
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AnyAsync(cancellationToken);
        }

        public Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .Where(predicate)
                .AnyAsync(cancellationToken);
        }

        public Task<int> CountAsync(
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .CountAsync(cancellationToken);
        }

        public Task<int> CountAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .Where(predicate)
                .CountAsync(cancellationToken);
        }

        public Task<TEntity> FindAsync(
            Guid id,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public Task<TEntity[]> FindAsync(
            Guid[] ids,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .Where(e => ids.Contains(e.Id))
                .ToArrayAsync(cancellationToken);
        }

        public Task<TEntity[]> FindAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .Where(predicate)
                .ToArrayAsync(cancellationToken);
        }

        public Task<TEntity[]> FindAsync(
            Expression<Func<TEntity, bool>> predicate,
            int skip,
            int limit,
            string orderBy,
            string orderDirection,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .Where(predicate)
                .Skip(skip)
                .Take(limit)
                .OrderBy(orderBy, orderDirection)
                .ToArrayAsync(cancellationToken);
        }
    }
}
