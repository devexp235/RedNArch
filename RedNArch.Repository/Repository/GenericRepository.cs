using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RedNArch.Repository.Interface;
using RedNArch.Model.Model;
using System.Linq.Expressions;

namespace RedNArch.Repository.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;
        

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }
        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T,bool>> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }
        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }
        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }
        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
