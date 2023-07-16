using SuperShop.Web.Data.Entities;
using SuperShop.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Web.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string userName);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);

        Task AddItemToOrderAsync(AddItemViewModel model, string userName);

        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

        Task DeleteDetailTempAsync(int id);

    }
}
