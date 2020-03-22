using System;
using System.Collections.Generic;
using System.Text;

namespace TM.Shop.IRepositories.UserRepositories
{
    public interface IUserRepositiories
    {
        IEnumerable<Models.UserModel.User> GetUsers();
    }
}
