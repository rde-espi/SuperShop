using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperShop.Web.Data.Entities;
using System.Linq;

namespace SuperShop.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails{ get; set; }
        public DbSet<OrderDetailTemp> OrderDetailTemps { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }



        //Habilita a regra de apagar em cascata chama-se cascate delete rule
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var cascadeFKs = modelBuilder.Model
        //        .GetEntityTypes()
        //        .SelectMany(t => t.GetForeignKeys())
        //        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            
        //    foreach (var fk in cascadeFKs)
        //    {
        //        fk.DeleteBehavior = DeleteBehavior.Restrict;
        //    }
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
