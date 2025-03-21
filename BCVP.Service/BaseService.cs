using AutoMapper;
using BCVP.IService;
using BCVP.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.Service
{
    public class BaseService<TEntity, TVo>(IMapper mapper, IBaseRepository<TEntity> baseRepository) 
        : IBaseService<TEntity, TVo> 
        where TEntity : class 
        where TVo : class
    {
        public async Task<List<TVo>> Query()
        {
            var entities = await baseRepository.Query();
            var vos = mapper.Map<List<TVo>>(entities);
            return vos;
        }
    }
}
