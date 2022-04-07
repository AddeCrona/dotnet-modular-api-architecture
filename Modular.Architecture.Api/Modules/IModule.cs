namespace Modular.Architecture.Api.Modules;

public interface IModule
{
    IServiceCollection RegisterModule(IServiceCollection services);
}

