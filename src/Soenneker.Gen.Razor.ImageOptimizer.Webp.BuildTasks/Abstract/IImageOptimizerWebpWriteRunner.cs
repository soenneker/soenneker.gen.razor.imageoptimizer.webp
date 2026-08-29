using System.Threading;
using System.Threading.Tasks;
namespace Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks.Abstract;
/// <summary>
/// Runs the build-time step that writes generated WebP image-optimization output.
/// </summary>
public interface IImageOptimizerWebpWriteRunner
{
    /// <summary>
    /// Runs image Optimizer Webp Write Runner for the Image Optimizer Webp Write Runner.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the application.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested value.</returns>
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
