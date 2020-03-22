using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TM.Shop.IServices;
using TM.Shop.Models.UserModel;

namespace TM.Shop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService) {
            this.userService = userService;
        }

        public IEnumerable<User> Get(long userId)
        {
            return userService.GetUsers();
        }
    }
}