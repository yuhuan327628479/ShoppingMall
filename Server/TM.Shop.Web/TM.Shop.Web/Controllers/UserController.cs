using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        private ILogger<UserController> logger;

        public UserController(IUserService userService, ILogger<UserController> logger) {
            this.userService = userService;
            this.logger = logger;
        }

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns>返回所有用户</returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            logger.LogDebug("test");
            return userService.GetUsers();
        }
    }
}