using CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext;
using CleanArchitectureConcept_Infrastructure.RepositoryBase.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureConcept_Infrastructure.RepositoryBase.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataBaseContext _context;
        public RepositoryBase(DataBaseContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? _context.Set<T>().Where(expression)
                .AsNoTracking() : _context.Set<T>().Where(expression);

        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
