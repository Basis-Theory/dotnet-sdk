using NUnit.Framework;

namespace BasisTheory.Client.Test;

/// <summary>
/// Pins the host each environment resolves to. Us and Eu both resolved to the
/// compatibility host until the spec grew per-region servers, so the constants
/// existed but selected nothing. These assertions fail if a regeneration
/// collapses them back.
/// </summary>
[TestFixture]
public class EnvironmentTests
{
    [Test]
    public void EnvironmentUrls()
    {
        Assert.That(BasisTheoryEnvironment.Default, Is.EqualTo("https://api.basistheory.com"));
        Assert.That(BasisTheoryEnvironment.Us, Is.EqualTo("https://api.us.basistheory.com"));
        Assert.That(BasisTheoryEnvironment.Eu, Is.EqualTo("https://api.eu.basistheory.com"));
        Assert.That(BasisTheoryEnvironment.Test, Is.EqualTo("https://api.test.basistheory.com"));
    }

    [Test]
    public void EnvironmentsAreDistinct()
    {
        var urls = new[]
        {
            BasisTheoryEnvironment.Default,
            BasisTheoryEnvironment.Us,
            BasisTheoryEnvironment.Eu,
            BasisTheoryEnvironment.Test,
        };

        Assert.That(urls, Is.Unique);
    }
}
