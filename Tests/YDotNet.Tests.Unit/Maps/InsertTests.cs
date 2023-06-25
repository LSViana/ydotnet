using NUnit.Framework;
using YDotNet.Document;
using YDotNet.Document.Cells;
using YDotNet.Document.Transactions;
using YDotNet.Document.Types;

namespace YDotNet.Tests.Unit.Maps;

public class InsertTests
{
    [Test]
    public void InsertBoolean()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();
        var value1 = true;
        var value2 = false;

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "value1", Input.Boolean(value1));
        map.Insert(transaction, "value2", Input.Boolean(value2));

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 2));
    }

    [Test]
    public void InsertDouble()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();
        var value1 = 24.69;
        var value2 = -4.20;

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "value1", Input.Double(value1));
        map.Insert(transaction, "value2", Input.Double(value2));

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 2));
    }

    [Test]
    public void InsertLong()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();
        var value1 = 2469L;
        var value2 = -420L;

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "value1", Input.Long(value1));
        map.Insert(transaction, "value2", Input.Long(value2));

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 2));
    }

    [Test]
    public void InsertString()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();
        var name = "Lucas";

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "name", Input.String(name));

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 1));
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertBytes()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertCollection()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertObject()
    {
    }

    [Test]
    public void InsertNull()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "value", Input.Null());

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 1));
    }

    [Test]
    public void InsertUndefined()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "value", Input.Undefined());

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 1));
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertText()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertArray()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertMap()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertXmlElement()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertXmlText()
    {
    }

    [Test]
    public void InsertDoc()
    {
        // Arrange
        var (map, transaction) = ArrangeDoc();
        var subDoc = new Doc();

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 0));

        // Act
        map.Insert(transaction, "sub-doc", Input.Doc(subDoc));

        // Assert
        Assert.That(map.Length(transaction), Is.EqualTo(expected: 1));
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertEqualTypeOnExistingKey()
    {
    }

    [Test]
    [Ignore("To be implemented.")]
    public void InsertDifferentTypeOnExistingKey()
    {
    }

    private (Map?, Transaction?) ArrangeDoc()
    {
        var doc = new Doc();
        var map = doc.Map("map");
        var transaction = doc.WriteTransaction();

        return (map, transaction);
    }
}