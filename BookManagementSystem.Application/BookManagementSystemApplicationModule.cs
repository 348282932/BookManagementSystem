﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace BookManagementSystem
{
    [DependsOn(typeof(BookManagementSystemCoreModule), typeof(AbpAutoMapperModule))]
    public class BookManagementSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
