using System.Text.Json;

namespace BCVP.Repository.Base;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    public async Task<List<TEntity>> Query()
    {
        await Task.CompletedTask;
        var dataString = "[{\"Id\": 18, \"Name\":\"tom\"}]";
        return JsonSerializer.Deserialize<List<TEntity>>(dataString) ?? [];
        // 正常项目中，此处应该是读取数据库返回对象，这里做 mock 处理
    }
}
