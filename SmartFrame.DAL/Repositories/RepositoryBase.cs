using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SmartFrame.DAL.Interfaces.Repositories;
using System.Data.Entity.Migrations;

namespace SmartFrame.DAL.Repositories
{
   public abstract class RepositoryBase<T> : IRepository<T> 
        where T : class 
    {
        protected SmartFrameDbContext dbContext;
        protected DbSet<T> items;

        public RepositoryBase(SmartFrameDbContext dbContext)
        {
            this.dbContext = dbContext;
            items = dbContext.Set<T>();
        }

        public virtual T Create(T item)
        {
            return items.Add(item);
        }

        public virtual void Edit(T item)
        {
            items.AddOrUpdate(item);
        }

        public virtual void Remove(T item)
        {
            items.Remove(item);
        }

        public virtual T Get(int id)
        {
            return items.Find(id);
        }

        public virtual IQueryable<T> Get()
        {
            return items;
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> where)
        {
            return items.Where(where);
        }
    }
}
