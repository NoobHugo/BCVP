using BCVP.Model;
using BCVP.Service;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<List<User>> Get()
        {
            var userService = new BaseService<User, UserVo>();
            return await userService.Query();
        }
    }
}
