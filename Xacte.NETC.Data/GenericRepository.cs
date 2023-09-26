using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Xacte.Data.Shared.Interfaces;

namespace Xacte.NETC.Data
{
    public  class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbset;

        public GenericRepository(DbContext context)
        { 
            _dbset = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> func)
        {
            return _dbset.Where(func);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> func)
        {
            return _dbset.FirstOrDefault(func);
        }

        public void Add(TEntity record)
        {
            _dbset.Add(record);
        }

        public TEntity SingleOrDefault(Func<TEntity, bool> func)
        {
            return _dbset.SingleOrDefault(func);
        }

        public void Remove(TEntity existingEntity)
        {
            _dbset.Remove(existingEntity);
        }

        public dynamic AsNoTracking()
        {
            return _dbset.AsNoTracking();
        }

        public TEntity Find(object key)
        {
            return _dbset.Find(key);
        }

        public dynamic Include(string entityToInclude)
        {
            return _dbset.Include(entityToInclude);
        }

        public IEnumerable<TEntity> ToList()
        {
            return _dbset.ToList();
        }
    }
}
