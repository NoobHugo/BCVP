using BCVP.Model;

namespace BCVP.Repository;

public interface IUserRepository
{
    Task<List<User>> Query();
}
