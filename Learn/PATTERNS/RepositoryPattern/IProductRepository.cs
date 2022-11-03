using System.Collections;
using System.Linq.Expressions;

namespace Learn.PATTERNS.RepositoryPattern
{
    public interface IProductRepository : IRepository
    {
        IEnumerable GetProductsByCategory(int id);
    }
}
