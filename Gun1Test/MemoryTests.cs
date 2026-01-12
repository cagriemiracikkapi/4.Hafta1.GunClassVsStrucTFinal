using NUnit.Framework;
using Week4.Gun1Lab.Models;
using Week4.Gun1Lab.Services;

[TestFixture]
public class MemoryTests
{
    [Test]
    public void Struct_Kopyalandiginda_Orijinal_Degismez()
    {
        // Arrange
        var p1 = new PointStruct(1, 1);

        // Act
        var p2 = p1; // Kopyalandı
        p2.X = 5; // Kopya değişti

        // Assert - NUnit 4.x modern syntax
        Assert.That(p1.X, Is.Not.EqualTo(p2.X)); // p1 etkilenmemeli
        Assert.That(p1.X, Is.EqualTo(1));
    }

    [Test]
    public void Class_Kopyalandiginda_Orijinal_Degisir()
    {
        // Arrange
        var p1 = new PointClass(1, 1);

        // Act
        var p2 = p1; // Referans kopyalandı
        p2.X = 5; // Heap'teki veri değişti

        // Assert - NUnit 4.x modern syntax
        Assert.That(p1.X, Is.EqualTo(p2.X)); // p1 de değişmiş olmalı
        Assert.That(p1, Is.SameAs(p2)); // Bellekteki adresleri aynı olmalı
    }
}
