using System.Threading.Tasks;
using AuthAspApp.Entities;

namespace AuthAspApp.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> SignInAsync(string email, string password);

        Task<User> SignUpAsync(string email, string userName, string password);

        Task Logout();
    }
}
