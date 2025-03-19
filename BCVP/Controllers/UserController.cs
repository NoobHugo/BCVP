using BCVP.Model;
using BCVP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<List<UserVo>> Get()
        {
            var userService = new UserService();
            return await userService.Query();
        }
    }
}
