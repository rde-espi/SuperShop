using SuperShop.Web.Data.Entities;
using System.Linq;

namespace SuperShop.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
