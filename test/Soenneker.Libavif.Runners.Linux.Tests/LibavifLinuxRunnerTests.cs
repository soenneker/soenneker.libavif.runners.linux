using Soenneker.Libavif.Runners.Linux.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Libavif.Runners.Linux.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LibavifLinuxRunnerTests : HostedUnitTest
{
    private readonly ILibavifLinuxRunner _runner;

    public LibavifLinuxRunnerTests(Host host) : base(host)
    {
        _runner = Resolve<ILibavifLinuxRunner>(true);
    }

    [Test]
    public void Default()
    {

    }
}
