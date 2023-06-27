using Microsoft.AspNetCore.Identity;
using SuperShop.Web.Data.Entities;
using SuperShop.Web.Models;
using System.Threading.Tasks;

namespace SuperShop.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User>GetUserByEmailAsync(string email);
        Task<IdentityResult>AddUserAsync(User user, string password);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
    }
}
