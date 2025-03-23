using AutoMapper;
using BCVP.Model;

namespace BCVP.Extension;

public class CustomProfile : Profile
{
    public CustomProfile()
    {
        CreateMap<User, UserVo>().ForMember(a => a.Username, o => o.MapFrom(d => d.Name));
        CreateMap<UserVo, User>().ForMember(a => a.Name, o => o.MapFrom(d => d.Username));
    }
}