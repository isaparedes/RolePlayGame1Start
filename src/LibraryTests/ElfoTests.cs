using System.Collections;
using Library;
using NUnit.Framework;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(Elfo))]
public class ElfoTests
{

    [Test]
    public void METHOD()
    {
        
    }

    [Test]
    //Este test controla que el constructor de Elfo funcione correctamente.
    //Los valores de los atributos del elfo creado deben coincidir con los valores preestablecidos de los
    //atributos de todos los objetos de esta clase.
    public void TestCrearElfo() 
    {
        string nombreEsperado = "Elfo1";
        int vidaActualEsperada = 500;
        int vidaBaseEsperada = 500;
        int ataqueEsperado = 100;

        Elfo elfo1 = new Elfo("Elfo1");

        Assert.That(nombreEsperado, Is.EqualTo(elfo1.GetNombre()));
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.VidaActual));
        Assert.That(vidaBaseEsperada, Is.EqualTo(elfo1.GetVidaBase()));
        Assert.That(ataqueEsperado, Is.EqualTo(elfo1.GetAtaque()));
    }

    [Test]
    //Este test controla que el método Atacar Elfo funcione correctamente.
    //La vida del elfo atacado debe coincidir con su vida anterior menos el ataque del elfo atacante.
    public void TestAtacarElfo() 
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elfo elfo2 = new Elfo("Elfo2");

        int VidaActualEsperadaElfo2 = elfo2.VidaActual - elfo1.GetAtaque();
        
        elfo1.AtacarElfo(elfo2);
        
        Assert.That(VidaActualEsperadaElfo2, Is.EqualTo(elfo2.VidaActual));
    }

    [Test]
    //Este test controla que el método Atacar Mago funcione correctamente.
    //La vida del mago atacado debe coincidir con su vida anterior menos el ataque del elfo atacante.
    public void TestAtacarMago() 
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Mago mago1 = new Mago("Mago1");

        int vidaActualEsperadaMago1 = mago1.VidaActual - elfo1.GetAtaque();
        
        elfo1.AtacarMago(mago1);
        
        Assert.That(vidaActualEsperadaMago1, Is.EqualTo(mago1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano funcione correctamente.
    //La vida del enano atacado debe coincidir con su vida anterior menos el ataque del elfo atacante.
    public void TestAtacarEnano() 
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Enano enano1 = new Enano("Enano1");

        int vidaActualEsperadaEnano1 = enano1.VidaActual - elfo1.GetAtaque();
        
        elfo1.AtacarEnano(enano1);
        
        Assert.That(vidaActualEsperadaEnano1, Is.EqualTo(enano1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Elfo no deje atacar cuando la vida del elfo atacado es
    //menor al ataque del elfo atacante.
    //La vida del elfo atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarElfoFallido() 
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elfo elfo2 = new Elfo("Elfo2");

        int VidaActualEsperadaElfo2 = elfo2.VidaActual - 5*elfo1.GetAtaque(); 
        
        elfo1.AtacarElfo(elfo2);
        elfo1.AtacarElfo(elfo2);
        elfo1.AtacarElfo(elfo2);
        elfo1.AtacarElfo(elfo2);
        elfo1.AtacarElfo(elfo2);
        elfo1.AtacarElfo(elfo2); //En este intento de ataque el elfo atacado ya tiene menos vida que el
                                 //ataque que puede recibir.
        
        Assert.That(VidaActualEsperadaElfo2, Is.EqualTo(elfo2.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Mago no deje atacar cuando la vida del mago atacado es
    //menor al ataque del elfo atacante.
    //La vida del mago atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarMagoFallido()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Mago mago1 = new Mago("Mago1");

        int vidaActualEsperadaMago1 = mago1.VidaActual - 8*elfo1.GetAtaque();
        
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);
        elfo1.AtacarMago(mago1);//En este intento de ataque el mago atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaMago1, Is.EqualTo(mago1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano no deje atacar cuando la vida del enano atacado es
    //menor al ataque del elfo atacante.
    //La vida del enano atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarEnanoFallido()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Enano enano1 = new Enano("Enano1");

        int vidaActualEsperadaEnano1 = enano1.VidaActual - 6*elfo1.GetAtaque();
        
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);
        elfo1.AtacarEnano(enano1);//En este intento de ataque el enano atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaEnano1, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Agregar Elemento funcione correctamente.
    //La vida y el ataque del elfo luego de llamar al método deben haber sumado el ataque y la defensa
    //del elemento agregado.
    public void TestAgregarElemento()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = elfo1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = elfo1.VidaActual + elemento1.GetDefensa();

        elfo1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(elfo1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento funcione correctamente.
    //La vida y el ataque del elfo luego de llamar al método deben haber restado el ataque y la defensa
    //del elemento agregado.
    public void TestQuitarElemento()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);
        elfo1.AgregarElemento(elemento1);

        int ataqueEsperado = elfo1.GetAtaque() - elemento1.GetAtaque();
        int vidaActualEsperada = elfo1.VidaActual - elemento1.GetDefensa();
        
        elfo1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(elfo1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Agregar Elemento no deje agregar más de una vez el elemento,
    //de manera que tampoco se sumen más de una vez el ataque y la defensa del elemento a
    //la vida y ataque del elfo.
    public void TestAgregarElementoFallido()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = elfo1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = elfo1.VidaActual + elemento1.GetDefensa();

        elfo1.AgregarElemento(elemento1);
        elfo1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(elfo1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento no deje quitar un elemento que nunca agregó.
    //Esto implica que tampoco se restan el ataque y la defensa de ese elemento al ataque y vida del elfo.
    public void TestQuitarElementoFallido()
    {
        Elfo elfo1 = new Elfo("Elfo1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = elfo1.GetAtaque();
        int vidaActualEsperada = elfo1.VidaActual;

        elfo1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(elfo1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Curar funcione correctamente.
    //Si la vida actual del elfo es menor a su vida base, puede restaurarla a la vida base.
    public void TestCurar()
    {
        Enano enano1 = new Enano("Enano1");
        Elfo elfo1 = new Elfo("Elfo1");
        enano1.AtacarElfo(elfo1);

        int vidaActualEsperadaElfo1 = elfo1.VidaActual + enano1.GetAtaque();
        
        elfo1.Curar();
        
        Assert.That(vidaActualEsperadaElfo1, Is.EqualTo(elfo1.GetVidaBase()));
    }

    [Test]
    //Este test controla que el método Curar no deje curar cuando el elfo tiene más vida o igual vida
    //que su vida base.
    public void TestCurarFallido()
    {
        Elfo elfo1 = new Elfo("Elfo1");

        int vidaActualEsperada = elfo1.VidaActual;
        
        elfo1.Curar();
        
        Assert.That(vidaActualEsperada, Is.EqualTo(elfo1.GetVidaBase()));
    }
}