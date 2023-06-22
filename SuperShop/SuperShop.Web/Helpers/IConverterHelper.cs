using SuperShop.Web.Data.Entities;
using SuperShop.Web.Models;
using System;

namespace SuperShop.Web.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, Guid imageId, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}
