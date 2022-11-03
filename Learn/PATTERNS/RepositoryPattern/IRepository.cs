using System;
using System.Collections;
using System.Linq.Expressions;

namespace Learn.PATTERNS.RepositoryPattern
{
    public interface IRepository
    {
        //IEnumerable GetAll();
        //IEnumerable Find(Expression predicate);
        //List<int> Get(object Id);

        void Add(List<int> entity);
        void AddRange(IEnumerable entities);

        void Update(List<int> entity);

        void Remove(object Id);
        void Remove(List<int> entity);
        void RemoveRange(IEnumerable entities);
    }
}
