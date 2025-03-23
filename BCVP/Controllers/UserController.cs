using BCVP.IService;
using BCVP.Model;
using Microsoft.AspNetCore.Mvc;

namespace BCVP.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IBaseService<User, UserVo> userService) : ControllerBase
{
    [HttpGet]
    public async Task<List<UserVo>> Get()
    {
        return await userService.Query();
    }
}