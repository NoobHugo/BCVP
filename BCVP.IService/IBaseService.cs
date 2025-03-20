using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.IService
{
    public interface IBaseService<TEntity, TVo> where TEntity : class where TVo : class
    {
        Task<List<TEntity>> Query();
    }
}
