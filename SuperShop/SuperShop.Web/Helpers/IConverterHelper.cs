using SuperShop.Web.Data.Entities;
using SuperShop.Web.Models;

namespace SuperShop.Web.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}
