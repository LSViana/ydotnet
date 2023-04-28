using System.Runtime.InteropServices;
using NUnit.Framework;
using YDotNet.Document;

namespace YDotNet.Tests.Unit.Document;

public class GuidTests
{
    [Test]
    public void Active()
    {
        // Arrange
        var doc = new Doc();

        // Act
        var guid = doc.Guid;

        // Assert
        Assert.That(guid, Is.Not.EqualTo(string.Empty));
    }

    [Test]
    public void Disposed()
    {
        // Arrange
        var doc = new Doc();
        doc.Dispose();

        // Act and Assert
        Assert.Throws<SEHException>(
            () =>
            {
                var _ = doc.Guid;
            });
    }
}