using SuperShop.Web.Data.Entities;
using SuperShop.Web.Models;
using System.IO;

namespace SuperShop.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model, string path, bool isNew)
        {
            return new Product
            {
                Id = isNew ? 0 : model.Id,
                ImageUrl = path,
                IsAvailable = model.IsAvailable,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                User = model.User
            };
        }

        public ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                IsAvailable = product.IsAvailable,
                LastPurchase = product.LastPurchase,
                LastSale = product.LastSale,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Name = product.Name,
                Stock = product.Stock,
                User = product.User
            };
        }
    }
}
