using Autofac;
using Autofac.Extensions.DependencyInjection;
using BCVP.Extension;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule<AutofacModuleRegister>();
    });

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

// builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
// builder.Services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();