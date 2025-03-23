namespace BCVP.Repository.Base;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> Query();
}
