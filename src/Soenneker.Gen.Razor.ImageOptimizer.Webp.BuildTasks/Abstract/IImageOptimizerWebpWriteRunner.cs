using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Gen.Razor.ImageOptimizer.Webp.BuildTasks.Abstract;

public interface IImageOptimizerWebpWriteRunner
{
    ValueTask<int> Run(string[] args, CancellationToken cancellationToken);
}
