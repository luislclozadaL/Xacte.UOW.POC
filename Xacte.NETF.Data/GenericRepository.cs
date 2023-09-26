using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Xacte.Data.Shared.Interfaces;

namespace Xacte.NETF.Data
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbset;

        public GenericRepository(dynamic context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> func)
        {
            return _dbset.Where(func);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> func)
        {
            return _dbset.FirstOrDefault(func);
        }

        public void Add(T record)
        {
            _dbset.Add(record);
        }

        public T SingleOrDefault(Func<T, bool> func)
        {
            return _dbset.SingleOrDefault(func);
        }

        public void Remove(T existingEntity)
        {
            _dbset.Remove(existingEntity);
        }

        public dynamic AsNoTracking()
        {
            return _dbset.AsNoTracking();
        }

        public T Find(object key)
        {
            return _dbset.Find(key);
        }

        public dynamic Include(string entityToInclude)
        {
            return _dbset.Include(entityToInclude);
        }

        public IEnumerable<T> ToList()
        {
            return _dbset.ToList();
        }
    }
}
