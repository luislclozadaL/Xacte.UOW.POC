using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xacte.Data.Model;

namespace Xacte.Data.Shared.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Where(Expression<Func<T, bool>> func);
        T FirstOrDefault(Expression<Func<T, bool>> func);
        void Add(T record);
        T SingleOrDefault(Func<T, bool> func);
        void Remove(T existingEntity);
        dynamic AsNoTracking();
        T Find(object key);
        dynamic Include(string entityToInclude);
        IEnumerable<T> ToList();
    }
}
