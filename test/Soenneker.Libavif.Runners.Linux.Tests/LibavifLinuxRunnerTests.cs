using Soenneker.Tests.HostedUnit;

namespace Soenneker.Libavif.Runners.Linux.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LibavifLinuxRunnerTests : HostedUnitTest
{
    public LibavifLinuxRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
