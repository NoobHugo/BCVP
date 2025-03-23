namespace BCVP.IService;

public interface IBaseService<TEntity, TVo> where TEntity : class where TVo : class
{
    Task<List<TVo>> Query();
}