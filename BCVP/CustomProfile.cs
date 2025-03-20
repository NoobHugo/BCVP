using AutoMapper;
using BCVP.Model;

namespace BCVP;

public class CustomProfile: Profile
{
    public CustomProfile()
    {
        CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
        CreateMap<RoleVo, Role>().ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));

        CreateMap<User, UserVo>().ForMember(a => a.Username, o => o.MapFrom(d => d.Name));
        CreateMap<UserVo, User>().ForMember(a => a.Name, o => o.MapFrom(d => d.Username));
    }
}
