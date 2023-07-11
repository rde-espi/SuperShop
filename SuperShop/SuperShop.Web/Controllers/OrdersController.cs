using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Web.Data;
using System.Threading.Tasks;

namespace SuperShop.Web.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _orderRepository.GetOrderAsync(this.User.Identity.Name);
            return View(model);
        }
    }
}
