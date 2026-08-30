using System.Threading;
using System.Threading.Tasks;
namespace Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks.Abstract;
/// <summary>
/// Runs the WebP build-time optimizer from its command-line arguments.
/// </summary>
public interface IImageOptimizerWebpWriteRunner
{
    /// <summary>
    /// Discovers configured source images and writes their WebP counterparts.
    /// </summary>
    /// <param name="args">Optimizer command-line arguments supplied by the MSBuild target.</param>
    /// <param name="cancellationToken">Cancels discovery or conversion.</param>
    /// <returns>Zero when the run succeeds; otherwise a nonzero process exit code.</returns>
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
