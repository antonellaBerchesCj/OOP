using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Learn.PATTERNS.RepositoryPattern
{
    public class ProductRepository : Repository, IProductRepository
    {
        public DbContext context
        {
            get
            {
                return db as DbContext;
            }
        }

        public ProductRepository(DbContext _db) : base(_db)
        {

        }

        public IEnumerable GetProductsByCategory(int id)
        {
            //return context.Products.Where(p => p.CategoryId == id).ToList();
            throw new NotImplementedException();
        }
    }
}
