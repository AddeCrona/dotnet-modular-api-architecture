using Modular.Architecture.Api.Modules;

namespace Modular.Architecture.Api.Extensions;

public static class ModuleExtensions
{
    // this could also be added into the DI container
    static readonly List<IModule> _registeredModules = new ();

    public static IServiceCollection RegisterModules(this IServiceCollection services)
    {
        var modules = DiscoverModules();
        foreach (var module in modules)
        {
            module.RegisterModule(services);
            _registeredModules.Add(module);
        }

        return services;
    }

    private static IEnumerable<IModule> DiscoverModules()
    {
        return typeof(IModule).Assembly
            .GetTypes()
            .Where(p => p.IsClass && p.IsAssignableTo(typeof(IModule)))
            .Select(Activator.CreateInstance)
            .Cast<IModule>();
    }
}
