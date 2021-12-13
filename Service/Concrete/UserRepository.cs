using DataAccess.Context;
using DataAccess.ViewModels;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantContext restaurantContext;

        public UserRepository(RestaurantContext _restaurantContext)
        {
            restaurantContext = _restaurantContext;
        }
        public List<UserRoleVM> GetUserForRole()
        {
            var userList = from user in restaurantContext.Users
                           join userRole in restaurantContext.UserRoles on user.Id equals userRole.UserId
                           join role in restaurantContext.Roles on userRole.RoleId equals role.Id
                           select new UserRoleVM
                           {
                               Id = user.Id,
                               UserName = user.UserName,
                               Email = user.Email,
                               IsActive = user.IsActive,
                               RoleName = role.Name
                           };
            return userList.ToList();
        }
    }
}
