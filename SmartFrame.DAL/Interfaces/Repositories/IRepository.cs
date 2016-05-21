using System;
using System.Linq;
using System.Linq.Expressions;

namespace SmartFrame.DAL.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);

        IQueryable<T> Get();

        IQueryable<T> Get(Expression<Func<T, bool>> where);

        T Create(T item);

        void Edit(T item);

        void Remove(T item);
    }
}
