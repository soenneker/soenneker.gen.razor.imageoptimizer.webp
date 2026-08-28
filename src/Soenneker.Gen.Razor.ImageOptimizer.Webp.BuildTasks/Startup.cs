using Microsoft.Extensions.DependencyInjection;
using Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks.Abstract;
using Soenneker.Libvips.Util.Registrars;

namespace Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IImageOptimizerWebpWriteRunner, ImageOptimizerWebpWriteRunner>();
        services.AddLibvipsUtilAsSingleton();
        services.AddHostedService<ConsoleHostedService>();
    }
}
