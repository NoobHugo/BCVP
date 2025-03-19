using BCVP.Model;

namespace BCVP.IService;

public interface IUserService
{
    Task<List<UserVo>> Query(); 
}
