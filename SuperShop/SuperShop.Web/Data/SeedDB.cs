using Microsoft.AspNetCore.Identity;
using SuperShop.Web.Data.Entities;
using SuperShop.Web.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Web.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random;
        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("reinaldo_7531@hotmail.com");
            if(user == null)
            {
                user = new User
                {
                    FirstName = "Reinaldo",
                    LastName = "Souza",
                    Email = "reinaldo_7531@hotmail.com",
                    UserName = "reinaldo_7531@hotmail.com",
                    PhoneNumber = "936232511"
                };
                var result= await _userHelper.AddUserAsync(user,"123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user  in seeder");
                }
            }

            if (!_context.Products.Any())
            {
                AddProduct("Iphone X",user);
                AddProduct("Magic Mause",user);
                AddProduct("Iwatch",user);
                AddProduct("Ipad mini",user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User = user
            });
        }
    }
}
