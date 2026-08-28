using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Libavif.Runners.Linux.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask<string> Process(CancellationToken cancellationToken = default);
}
