using Microsoft.EntityFrameworkCore;
using SuperShop.Web.Data.Entities;

namespace SuperShop.Web.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Product>Products { get; set; }
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
    }
}
