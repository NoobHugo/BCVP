using BCVP.IService;
using BCVP.Model;
using BCVP.Repository;
using BCVP.Repository.Base;

namespace BCVP.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            var userRepo = new BaseRepository<User>();
            var userList = await userRepo.Query();
            return [..userList.Select(user => new UserVo() { Username = user.Name })];
        }
    }
}
