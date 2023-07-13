using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShop.Web.Data.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
