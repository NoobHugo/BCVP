using BCVP.Model;
using System.Text.Json;

namespace BCVP.Repository;

public class UserRepository : IUserRepository
{
    public async Task<List<User>> Query()
    {
        await Task.CompletedTask;
        var jsonString = "[{\"Id\": 18 ,\"Name\": \"laozhang\"}]";
        return JsonSerializer.Deserialize<List<User>>(jsonString) ?? [];
    }
}
