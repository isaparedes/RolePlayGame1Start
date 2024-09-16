using Library;
using NUnit.Framework;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(Hechizo))]
public class HechizoTests
{

    [Test]
    public void METHOD()
    {
        
    }
    
    [Test] 
    public void TestCrearHechizo() //Este test controla que el constructor de hechizo funcione correctamente
    {
        string nombreEsperado = "Hechizo1";
        int ataqueEsperado = 20;

        Hechizo hechizo1 = new Hechizo("Hechizo1", 20);
        
        Assert.That(nombreEsperado, Is.EqualTo(hechizo1.GetNombre()));
        Assert.That(ataqueEsperado, Is.EqualTo(hechizo1.GetAtaque()));
    }
}