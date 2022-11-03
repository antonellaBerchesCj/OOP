using Microsoft.EntityFrameworkCore;

namespace Learn.PATTERNS.RepositoryPattern
{
    internal class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository(DbContext db)
        {

        }
    }
}