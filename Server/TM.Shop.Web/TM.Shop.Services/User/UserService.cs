using System.Collections.Generic;
using TM.Shop.IRepositories.UserRepositories;
using TM.Shop.IServices;
using UI.Common.IocUtil;

namespace TM.Shop.Services.User
{
    [Scope]
    public class UserService : IUserService
    {
        private IUserRepositiories repositiories;

        public UserService(IUserRepositiories repositiories)
        {
            this.repositiories = repositiories;
        }

        public IEnumerable<Models.UserModel.User> GetUsers()
        {
            return repositiories.GetUsers();
        }
    }
}
