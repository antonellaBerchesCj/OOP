using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Learn.PATTERNS.RepositoryPattern
{
    public class Repository : IRepository
    {
        protected readonly DbContext db;

        public Repository(DbContext _db)
        {
            db = _db;
        }

        //public IEnumerable GetAll() => db.ToList();

        //public IEnumerable Find(Expression predicate) => db.Where(predicate);

        //public List<int> Get(object Id) => db.Find((Type)Id);

        public void Add(List<int> entity)
        {
            db.Add(entity);
        }

        public void AddRange(IEnumerable entities)
        {
            db.AddRange(entities);
        }

        public void Remove(List<int> entity)
        {
            db.Remove(entity);
        }

        public void RemoveRange(IEnumerable entities)
        {
            db.RemoveRange(entities);
        }

        public void Remove(object Id)
        {
            var entity = db.Find((Type)Id);
            this.Remove(entity);
        }

        public void Update(List<int> entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
