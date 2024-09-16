using Library;
using NUnit.Framework;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(Enano))]
public class EnanoTests
{

    [Test]
    public void METHOD()
    {

    }
    [Test]
    //Este test controla que el constructor de Enano funcione correctamente.
    //Los valores de los atributos del enano creado deben coincidir con los valores preestablecidos de los
    //atributos de todos los objetos de esta clase.
    public void TestCrearEnano() 
    {
        string nombreEsperado = "Enano1";
        int vidaActualEsperada = 600;
        int vidaBaseEsperada = 600;
        int ataqueEsperado = 300;

        Enano enano1 = new Enano("Enano1");

        Assert.That(nombreEsperado, Is.EqualTo(enano1.GetNombre()));
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.VidaActual));
        Assert.That(vidaBaseEsperada, Is.EqualTo(enano1.GetVidaBase()));
        Assert.That(ataqueEsperado, Is.EqualTo(enano1.GetAtaque()));

    }
    
    [Test]
    //Este test controla que el método Atacar Elfo funcione correctamente.
    //La vida del elfo atacado debe coincidir con su vida anterior menos el ataque del enano atacante.
    public void TestAtacarElfo() 
    {
        Enano enano1 = new Enano("Enano1");
        Elfo elfo1 = new Elfo("Elfo1");

        int VidaActualEsperadaElfo1 = elfo1.VidaActual - enano1.GetAtaque();
        
        enano1.AtacarElfo(elfo1);
        
        Assert.That(VidaActualEsperadaElfo1, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Atacar Mago funcione correctamente.
    //La vida del mago atacado debe coincidir con su vida anterior menos el ataque del enano atacante.
    public void TestAtacarMago() 
    {
        Enano enano1 = new Enano("Enano1");
        Mago mago1 = new Mago("Mago1");

        int vidaActualEsperadaMago1 = mago1.VidaActual - enano1.GetAtaque();

        enano1.AtacarMago(mago1);
        
        Assert.That(vidaActualEsperadaMago1, Is.EqualTo(mago1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano funcione correctamente.
    //La vida del enano atacado debe coincidir con su vida anterior menos el ataque del enano atacante.
    public void TestAtacarEnano() 
    {
        Enano enano1 = new Enano("Enano1");
        Enano enano2 = new Enano("Enano2");

        int vidaActualEsperadaEnano2 = enano2.VidaActual - enano1.GetAtaque();
        
        enano1.AtacarEnano(enano2);
        
        Assert.That(vidaActualEsperadaEnano2, Is.EqualTo(enano2.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Elfo no deje atacar cuando la vida del elfo atacado es
    //menor al ataque del enano atacante.
    //La vida del elfo atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarElfoFallido() 
    {
        Enano enano1 = new Enano("Enano1");
        Elfo elfo1 = new Elfo("Elfo1");

        int VidaActualEsperadaElfo1 = elfo1.VidaActual - enano1.GetAtaque(); 
        
        enano1.AtacarElfo(elfo1);
        enano1.AtacarElfo(elfo1);//En este intento de ataque el elfo atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(VidaActualEsperadaElfo1, Is.EqualTo(elfo1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Mago no deje atacar cuando la vida del mago atacado es
    //menor al ataque del enano atacante.
    //La vida del mago atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarMagoFallido()
    {
        Enano enano1 = new Enano("Enano1");
        Mago mago1 = new Mago("Mago1");

        int vidaActualEsperadaMago1 = mago1.VidaActual - 2*enano1.GetAtaque();
        
        enano1.AtacarMago(mago1);
        enano1.AtacarMago(mago1);
        enano1.AtacarMago(mago1);//En este intento de ataque el mago atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaMago1, Is.EqualTo(mago1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano no deje atacar cuando la vida del enano atacado es
    //menor al ataque del enano atacante.
    //La vida del enano atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarEnanoFallido()
    
    {
        Enano enano1 = new Enano("Enano1");
        Enano enano2 = new Enano("Enano2");

        int vidaActualEsperadaEnano2 = enano2.VidaActual - 2*enano1.GetAtaque();
        
        enano1.AtacarEnano(enano2);
        enano1.AtacarEnano(enano2);
        enano1.AtacarEnano(enano2);//En este intento de ataque el enano atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaEnano2, Is.EqualTo(enano2.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Agregar Elemento funcione correctamente.
    //La vida y el ataque del enano luego de llamar al método deben haber sumado el ataque y la defensa
    //del elemento agregado.
    public void TestAgregarElemento()
    {
        Enano enano1 = new Enano("Enano1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = enano1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = enano1.VidaActual + elemento1.GetDefensa();

        enano1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(enano1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento funcione correctamente.
    //La vida y el ataque del enano luego de llamar al método deben haber restado el ataque y la defensa
    //del elemento agregado.
    public void TestQuitarElemento()
    {
        Enano enano1 = new Enano("Enano1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);
        enano1.AgregarElemento(elemento1);

        int ataqueEsperado = enano1.GetAtaque() - elemento1.GetAtaque();
        int vidaActualEsperada = enano1.VidaActual - elemento1.GetDefensa();
        
        enano1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(enano1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Agregar Elemento no deje agregar más de una vez el elemento,
    //de manera que tampoco se sumen más de una vez el ataque y la defensa del elemento a
    //la vida y ataque del enano.
    public void TestAgregarElementoFallido()
    {
        Enano enano1 = new Enano("Enano1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = enano1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = enano1.VidaActual + elemento1.GetDefensa();
        
        enano1.AgregarElemento(elemento1);
        enano1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(enano1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento no deje quitar un elemento que nunca agregó.
    //Esto implica que tampoco se restan el ataque y la defensa de ese elemento al ataque y vida del enano.
    public void TestQuitarElementoFallido()
    {
        Enano enano1 = new Enano("Enano1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = enano1.GetAtaque();
        int vidaActualEsperada = enano1.VidaActual;

        enano1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(enano1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Curar funcione correctamente.
    //Si la vida actual del enano es menor a su vida base, puede restaurarla a la vida base.
    public void TestCurar()
    {
        Enano enano1 = new Enano("Enano1");
        Enano enano2 = new Enano("Enano2");
        enano1.AtacarEnano(enano2);

        int vidaActualEsperadaEnano2 = enano2.VidaActual + enano1.GetAtaque();
        
        enano2.Curar();
        
        Assert.That(vidaActualEsperadaEnano2, Is.EqualTo(enano2.GetVidaBase()));
    }

    [Test]
    //Este test controla que el método Curar no deje curar cuando el enano tiene más vida o igual vida
    //que su vida base.
    public void TestCurarFallido()
    {
        Enano enano1 = new Enano("Enano1");

        int vidaActualEsperada = enano1.VidaActual;
        
        enano1.Curar();
        
        Assert.That(vidaActualEsperada, Is.EqualTo(enano1.GetVidaBase()));
    }
}