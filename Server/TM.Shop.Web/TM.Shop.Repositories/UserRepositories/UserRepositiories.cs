using System.Collections.Generic;
using System.Linq;
using TM.Shop.IRepositories.UserRepositories;
using TM.Shop.Models.UserModel;
using UI.Common.IocUtil;

namespace TM.Shop.Repositories.UserRepositories
{
    [Scope]
    public class UserRepositiories : IUserRepositiories
    {
        private ShopDBContext context;

        public UserRepositiories(ShopDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToArray();
        }
    }
}
