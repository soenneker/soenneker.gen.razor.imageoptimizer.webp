using Microsoft.Extensions.DependencyInjection;
using Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks.Abstract;
using Soenneker.Libvips.Util.Registrars;
namespace Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks;
public static class Startup
{
    /// <summary>
    /// Registers the services required by the application host.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IImageOptimizerWebpWriteRunner, ImageOptimizerWebpWriteRunner>();
        services.AddLibvipsUtilAsSingleton();
        services.AddHostedService<ConsoleHostedService>();
    }
}
