using PFMS.Domain.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PFMS.Persistence.Extensions
{
    public static class QueryableExtensions
    {
        private const string DefaultSortColumnName = nameof(IEntity.Created);

        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string name, string direction)
        {
            var orderByString = false;

            if (string.IsNullOrEmpty(name))
            {
                name = DefaultSortColumnName;
            }
            else
            {
                var propertyInfo = Array.Find(
                    typeof(T).GetProperties(),
                    p => string.Equals(p.Name, name, StringComparison.InvariantCultureIgnoreCase));

                if (propertyInfo is null)
                {
                    name = DefaultSortColumnName;
                }
                else
                {
                    orderByString = propertyInfo.PropertyType == typeof(string);
                }
            }

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, name);
            var lambda = default(LambdaExpression);

            if (orderByString)
            {
                var method = Expression.Call(property, nameof(string.ToLower), Array.Empty<Type>());
                lambda = Expression.Lambda(method, parameter);
            }
            else
            {
                lambda = Expression.Lambda(property, parameter);
            }

            var expression = Expression.Call(
                typeof(Queryable),
                string.Equals(direction, "asc", StringComparison.OrdinalIgnoreCase) ? "OrderBy" : "OrderByDescending",
                new Type[] { typeof(T), property.Type },
                source.Expression,
                lambda);

            return (IOrderedQueryable<T>)source.Provider.CreateQuery<T>(expression);
        }
    }
}
