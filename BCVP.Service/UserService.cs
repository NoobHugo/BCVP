using BCVP.IService;
using BCVP.Model;
using BCVP.Repository;

namespace BCVP.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            var userRepo = new UserRepository();
            var userList = await userRepo.Query();
            return [..userList.Select(user => new UserVo() { Username = user.Name })];
        }
    }
}
