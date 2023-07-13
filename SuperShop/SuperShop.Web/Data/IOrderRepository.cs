using SuperShop.Web.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Web.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string userName);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);

    }
}
