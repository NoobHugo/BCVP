using Autofac;
using BCVP.IService;
using BCVP.Repository.Base;
using BCVP.Service;
using System.Reflection;

namespace BCVP.Extension;

public class AutofacModuleRegister : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var basePath = AppContext.BaseDirectory;

        var servicesDllFile = Path.Combine(basePath, "BCVP.Service.dll");
        var repositoryDllFile = Path.Combine(basePath, "BCVP.Repository.dll");

        builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();
        builder.RegisterGeneric(typeof(BaseService<,>)).As(typeof(IBaseService<,>)).InstancePerDependency();

        var assemblyServices = Assembly.LoadFrom(servicesDllFile);
        builder.RegisterAssemblyTypes(assemblyServices).AsImplementedInterfaces().InstancePerDependency().PropertiesAutowired();

        var assemblyRepository = Assembly.LoadFrom(repositoryDllFile);
        builder.RegisterAssemblyTypes(assemblyRepository).AsImplementedInterfaces().InstancePerDependency().PropertiesAutowired();
    }
}