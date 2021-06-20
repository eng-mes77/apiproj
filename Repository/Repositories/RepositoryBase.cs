using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Contracts.IServices;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PersonDbContext _personDbContext;
        public RepositoryBase(PersonDbContext companyEmployeeDbContext)
        {
            _personDbContext = companyEmployeeDbContext;
        }

        public void Create(T entity)
        {
            _personDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _personDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        => !trackChanges ?
                _personDbContext.Set<T>().AsNoTracking() :
                _personDbContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        =>
            !trackChanges ? _personDbContext.Set<T>().Where(expression).AsTracking() :
                _personDbContext.Set<T>().Where(expression);
        public void Update(T entity)
        {
            _personDbContext.Set<T>().Update(entity);
        }
    }
}
