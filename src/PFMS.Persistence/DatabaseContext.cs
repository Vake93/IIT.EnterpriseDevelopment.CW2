using Microsoft.EntityFrameworkCore;
using PFMS.Domain;
using PFMS.Domain.Models;
using PFMS.Persistence.Extensions;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence
{
    public class DatabaseContext : DbContext, IUnitOfWork
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            UpdateTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurations(
                typeof(DatabaseContext).Assembly,
                typeof(IEntityTypeConfiguration<>));
        }

        private void UpdateTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(e => e.Entity is IEntity &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            var timestamp = DateTime.UtcNow;

            foreach (var entity in entities)
            {
                var entry = (IEntity)entity.Entity;

                if (entity.State == EntityState.Added)
                {
                    entry.Created = timestamp;
                    entry.Modified = timestamp;
                }
                else if (entity.State == EntityState.Modified)
                {
                    entry.Modified = timestamp;
                }
            }
        }
    }
}
