using System;
using System.Linq;
using System.Linq.Expressions;

namespace Classroom.Backend.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges = true);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges = true);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
