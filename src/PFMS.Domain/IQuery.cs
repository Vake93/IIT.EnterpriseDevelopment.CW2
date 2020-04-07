using PFMS.Domain.Models;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain
{
    public interface IQuery<TEntity>
        where TEntity : IEntity
    {
        Task<bool> AnyAsync(
            CancellationToken cancellationToken = default);

        Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default);

        Task<TEntity> FindAsync(
            Guid id,
            CancellationToken cancellationToken = default);

        Task<TEntity[]> FindAsync(
            Guid[] ids,
            CancellationToken cancellationToken = default);

        Task<TEntity[]> FindAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default);

        Task<TResult[]> FindAsync<TResult>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            CancellationToken cancellationToken = default);

        Task<TResult[]> FindAsync<TResult>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            int skip,
            int limit,
            string orderBy,
            string orderDirection,
            CancellationToken cancellationToken = default);

        Task<int> CountAsync(
            CancellationToken cancellationToken = default);

        Task<int> CountAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default);
    }
}
