using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AuthAspApp.Constants;
using AuthAspApp.Entities;
using AuthAspApp.Services.Interfaces;

namespace AuthAspApp.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager) => _userManager = userManager;

        public IQueryable<User> FindAll()
            => _userManager.Users;

        public IQueryable<User> GetByCondition(Expression<Func<User, bool>> expression, bool trackChanges)
        {
            var query = _userManager.Users.Where(expression);

            return trackChanges ? query : query.AsNoTracking();
        }

        public async Task DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            else
            {
                throw new ArgumentException($"User with id {id} not found");
            }
        }

        public async Task ChangeStatus(string id, UserStatuses status)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                user.Status = status;
                await _userManager.UpdateAsync(user);
            }
            else
            {
                throw new ArgumentException($"User with id {id} not found");
            }
        }
    }
}
