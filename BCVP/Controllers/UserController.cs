using AutoMapper;
using BCVP.Model;
using BCVP.Service;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<List<UserVo>> Get()
        {
            var userService = new BaseService<User, UserVo>(mapper);
            return await userService.Query();
        }
    }
}
