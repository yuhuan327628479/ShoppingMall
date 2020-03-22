using System;
using System.Collections.Generic;
using System.Text;
using TM.Shop.IServices;
using TM.Shop.Models.UserModel;
using UI.Common.IocUtil;

namespace TM.Shop.Services.User
{
    [SingleService]
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public Models.UserModel.User Get()
        {
            return new Models.UserModel.User
            {
                Name = "abc" 
            };
        }
    }
}
