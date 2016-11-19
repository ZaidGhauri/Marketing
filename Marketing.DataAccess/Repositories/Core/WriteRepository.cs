using System.Data;
using System.Data.Entity;

namespace Marketing.DataAccess.Repositories.Core
{
    public abstract class WriteRepository<TContext> : IWriteRepository
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        protected TContext Context { get { return _context; } }

        protected WriteRepository()
        {
            _context = new TContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public TItem Update<TItem>(TItem item, bool saveImmediately = true) where TItem : class, new()
        {
            return PerformAction(item, System.Data.Entity.EntityState.Modified, saveImmediately);
        }

        public TItem Delete<TItem>(TItem item, bool saveImmediately = true) where TItem : class, new()
        {
            return PerformAction(item, System.Data.Entity.EntityState.Deleted, saveImmediately);
        }

        public TItem Insert<TItem>(TItem item, bool saveImmediately = true) where TItem : class, new()
        {
            return PerformAction(item, System.Data.Entity.EntityState.Added, saveImmediately);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual TItem PerformAction<TItem>(TItem item, System.Data.Entity.EntityState entityState, bool saveImmediately = true) where TItem : class, new()
        {
            _context.Entry(item).State = entityState;
            if (saveImmediately)
            {
                _context.SaveChanges();
            }
            return item;
        }
    }
}