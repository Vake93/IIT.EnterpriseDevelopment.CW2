using Microsoft.EntityFrameworkCore;
using PFMS.Domain;
using PFMS.Domain.Models;
using PFMS.Persistence.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Queries
{
    public abstract class Query<TEntity> : IQuery<TEntity>
        where TEntity : class, IEntity
    {
        public Query(DatabaseContext context)
        {
            Context = context;
        }

        protected DatabaseContext Context { get; private set; }

        public Task<bool> AnyAsync(
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .AnyAsync(cancellationToken);
        }

        public Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .AnyAsync(predicate, cancellationToken);
        }

        public Task<int> CountAsync(
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .CountAsync(cancellationToken);
        }

        public Task<int> CountAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .CountAsync(cancellationToken);
        }

        public Task<TEntity> FindAsync(
            Guid id,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        }

        public Task<TEntity[]> FindAsync(
            Guid[] ids,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(e => ids.Contains(e.Id))
                .ToArrayAsync(cancellationToken);
        }

        public Task<TEntity[]> FindAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .ToArrayAsync(cancellationToken);
        }

        public Task<TResult[]> FindAsync<TResult>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .Select(selector)
                .ToArrayAsync(cancellationToken);
        }

        public Task<TResult[]> FindAsync<TResult>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            int skip,
            int limit,
            string orderBy,
            string orderDirection,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .Skip(skip)
                .Take(limit)
                .OrderBy(orderBy, orderDirection)
                .Select(selector)
                .ToArrayAsync(cancellationToken);
        }
    }
}
