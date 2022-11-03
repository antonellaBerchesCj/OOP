using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.PATTERNS.RepositoryPattern
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }

        int SaveChanges();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext db;

        public UnitOfWork()
        {
            //db = new DbContext();

            // example
            //using (var context = new DbContext())
            //{
            //    var users = context.Users.Where(x => x.ClassId == 4).ToList();
            //}
        }

        private ICategoryRepository _Categories;
        public ICategoryRepository Categories
        {
            get
            {
                if (this._Categories == null)
                {
                    this._Categories = new CategoryRepository(db);
                }
                return this._Categories;
            }
        }

        private IProductRepository _Products;
        public IProductRepository Products
        {
            get
            {
                if (this._Products == null)
                {
                    this._Products = new ProductRepository(db);
                }
                return this._Products;
            }
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
