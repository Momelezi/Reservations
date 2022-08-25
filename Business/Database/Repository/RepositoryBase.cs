using Business.Database.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Database.Repository
{ 


      public abstract class RepositoryBase<T> : RepositoryBase<T> where T : class
       {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext) { this.RepositoryContext = repositoryContext; }

        public IQueryable<T> FindAll() { return this.RepositoryContext.Set<T>().AsNoTracking(); }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) { return RepositoryContext.Set<T>().Where(expression).AsNoTracking(); }

        public void Create(T entity) { this.RepositoryContext.Set<T>().Add(entity); }

        public void Update(T entity) { this.RepositoryContext.Set<T>().Update(entity); }

        public void Delete(T entity) { this.RepositoryContext.Set<T>().Remove(entity); }

        public void Save() { this.RepositoryContext.SaveChanges(); }

        public async Task CreateAsync(T entity) { this.RepositoryContext.Set<T>().Add(entity); await this.RepositoryContext.SaveChangesAsync(); }

        public async Task UpdateAsync(T entity) { this.RepositoryContext.Set<T>().Update(entity); await this.RepositoryContext.SaveChangesAsync(); }

        public async Task DeleteAsync(T entity) { this.RepositoryContext.Set<T>().Remove(entity); await this.RepositoryContext.SaveChangesAsync(); }

        public async Task SaveAsync() { await this.RepositoryContext.SaveChangesAsync(); }
    }


}
