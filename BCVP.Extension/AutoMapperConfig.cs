﻿using AutoMapper;

namespace BCVP.Extension;

public class AutoMapperConfig
{
    public static MapperConfiguration RegisterMappings()
    {
        return new MapperConfiguration(config => config.AddProfile(new CustomProfile()));
    }
}
