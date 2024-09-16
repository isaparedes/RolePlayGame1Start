using Library;
using NUnit.Framework;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(Elemento))]
public class ElementoTests
{

    [Test]
    public void METHOD()
    {
        
    }

    [Test]
    public void TestCrearElemento() //Este test controla que el constructor de elemento funcione correctamente
    {
        string nombreEsperado = "Elemento1";
        int ataqueEsperado = 10;
        int defensaEsperada = 40;

        Elemento elemento1 = new Elemento("Elemento1", 10, 40);
        
        Assert.That(nombreEsperado, Is.EqualTo(elemento1.GetNombre()));
        Assert.That(ataqueEsperado, Is.EqualTo(elemento1.GetAtaque()));
        Assert.That(defensaEsperada, Is.EqualTo(elemento1.GetDefensa()));
    }
}