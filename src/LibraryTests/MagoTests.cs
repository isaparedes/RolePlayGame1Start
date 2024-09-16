using Library;
using NUnit.Framework;

namespace LibraryTests;

[TestFixture]
[TestOf(typeof(Mago))]
public class MagoTests
{

    [Test]
    public void METHOD()
    {
        
    }
    [Test]
    //Este test controla que el constructor de Mago funcione correctamente.
    //Los valores de los atributos del mago creado deben coincidir con los valores preestablecidos de los
    //atributos de todos los objetos de esta clase.
    public void TestCrearMago() 
    {
        string nombreEsperado = "Mago1";
        int vidaActualEsperada = 800;
        int vidaBaseEsperada = 800;
        int ataqueEsperado = 200;

        Mago mago1 = new Mago("Mago1");

        Assert.That(nombreEsperado, Is.EqualTo(mago1.GetNombre()));
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.VidaActual));
        Assert.That(vidaBaseEsperada, Is.EqualTo(mago1.GetVidaBase()));
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));

    }
    
    [Test]
    //Este test controla que el método Atacar Elfo funcione correctamente.
    //La vida del elfo atacado debe coincidir con su vida anterior menos el ataque del mago atacante.
    public void TestAtacarElfo() 
    {
        Mago mago1 = new Mago("Mago1");
        Elfo elfo1 = new Elfo("Elfo1");

        int VidaActualEsperadaElfo1 = elfo1.VidaActual - mago1.GetAtaque();
        
        mago1.AtacarElfo(elfo1);
        
        Assert.That(VidaActualEsperadaElfo1, Is.EqualTo(elfo1.VidaActual));
    }

    [Test]
    //Este test controla que el método Atacar Mago funcione correctamente.
    //La vida del mago atacado debe coincidir con su vida anterior menos el ataque del mago atacante.
    public void TestAtacarMago() 
    {
        Mago mago1 = new Mago("Mago1");
        Mago mago2 = new Mago("Mago2");

        int vidaActualEsperadaMago2 = mago2.VidaActual - mago1.GetAtaque();
        
        mago1.AtacarMago(mago2);
        
        Assert.That(vidaActualEsperadaMago2, Is.EqualTo(mago2.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano funcione correctamente.
    //La vida del enano atacado debe coincidir con su vida anterior menos el ataque del mago atacante.
    public void TestAtacarEnano() 
    {
        Mago mago1 = new Mago("Mago1");
        Enano enano1 = new Enano("Enano1");

        int vidaActualEsperadaEnano1 = enano1.VidaActual - mago1.GetAtaque();
        
        mago1.AtacarEnano(enano1);
        
        Assert.That(vidaActualEsperadaEnano1, Is.EqualTo(enano1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Elfo no deje atacar cuando la vida del elfo atacado es
    //menor al ataque del mago atacante.
    //La vida del elfo atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarElfoFallido() 
    {
        Mago mago1 = new Mago("Mago1");
        Elfo elfo1 = new Elfo("Elfo1");

        int VidaActualEsperadaElfo1 = elfo1.VidaActual - 2*mago1.GetAtaque(); 
        
        mago1.AtacarElfo(elfo1);
        mago1.AtacarElfo(elfo1);
        mago1.AtacarElfo(elfo1);//En este intento de ataque el elfo atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(VidaActualEsperadaElfo1, Is.EqualTo(elfo1.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Mago no deje atacar cuando la vida del mago atacado es
    //menor al ataque del mago atacante.
    //La vida del mago atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarMagoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Mago mago2 = new Mago("Mago2");

        int vidaActualEsperadaMago2 = mago2.VidaActual - 4*mago1.GetAtaque();
        
        mago1.AtacarMago(mago2);
        mago1.AtacarMago(mago2);
        mago1.AtacarMago(mago2);
        mago1.AtacarMago(mago2);
        mago1.AtacarMago(mago2);//En este intento de ataque el mago atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaMago2, Is.EqualTo(mago2.VidaActual));
    }
    
    [Test]
    //Este test controla que el método Atacar Enano no deje atacar cuando la vida del enano atacado es
    //menor al ataque del mago atacante.
    //La vida del enano atacado debe coincidir con su vida anterior previo al intento de ataque.
    public void TestAtacarEnanoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Enano enano1 = new Enano("Enano1");

        int vidaActualEsperadaEnano1 = enano1.VidaActual - 3*mago1.GetAtaque();
        
        mago1.AtacarEnano(enano1);
        mago1.AtacarEnano(enano1);
        mago1.AtacarEnano(enano1);
        mago1.AtacarEnano(enano1);//En este intento de ataque el enano atacado ya tiene menos vida que el
        //ataque que puede recibir.
        
        Assert.That(vidaActualEsperadaEnano1, Is.EqualTo(enano1.VidaActual));
    }

    [Test]
    //Este test controla que el método Agregar Hechizo funcione correctamente.
    //El ataque del mago luego de llamar al método debe haber sumado el ataque del hechizo agregado.
    public void TestAgregarHechizo()
    {
        Mago mago1 = new Mago("Mago1");
        Hechizo hechizo1 = new Hechizo("Hechizo1", 10);

        int ataqueEsperado = mago1.GetAtaque() + hechizo1.GetAtaque();
        
        mago1.AgregarHechizo(hechizo1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
    }

    [Test]
    //Este test controla que el método Quitar Hechizo funcione correctamente.
    //El ataque del mago luego de llamar al método debe haber restado el ataque del hechizo agregado.
    public void TestQuitarHechizo()
    {
        Mago mago1 = new Mago("Mago1");
        Hechizo hechizo1 = new Hechizo("Hechizo1", 10);
        mago1.AgregarHechizo(hechizo1);

        int ataqueEsperado = mago1.GetAtaque() - hechizo1.GetAtaque();
        
        mago1.QuitarHechizo(hechizo1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
    }
    
    [Test]
    //Este test controla que el método Agregar Hechizo no deje agregar más de una vez el hechizo,
    //de manera que tampoco se sume más de una vez el ataque del hechizo al ataque del mago.
    public void TestAgregarHechizoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Hechizo hechizo1 = new Hechizo("Hechizo1", 10);

        int ataqueEsperado = mago1.GetAtaque() + hechizo1.GetAtaque();

        mago1.AgregarHechizo(hechizo1);
        mago1.AgregarHechizo(hechizo1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
    }

    [Test]
    //Este test controla que el método Quitar Hechizo no deje quitar un hechizo que nunca agregó.
    //Esto implica que tampoco se resta el ataque de ese hechizo al ataque del mago.
    public void TestQuitarHechizoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Hechizo hechizo1 = new Hechizo("Hechizo", 10);

        int ataqueEsperado = mago1.GetAtaque();

        mago1.QuitarHechizo(hechizo1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
    }
    
    [Test]
    //Este test controla que el método Agregar Elemento funcione correctamente.
    //La vida y el ataque del mago luego de llamar al método deben haber sumado el ataque y la defensa
    //del elemento agregado.
    public void TestAgregarElemento()
    {
        Mago mago1 = new Mago("Mago1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = mago1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = mago1.VidaActual + elemento1.GetDefensa();

        mago1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento funcione correctamente.
    //La vida y el ataque del mago luego de llamar al método deben haber restado el ataque y la defensa
    //del elemento agregado.
    public void TestQuitarElemento()
    {
        Mago mago1 = new Mago("Mago1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);
        mago1.AgregarElemento(elemento1);

        int ataqueEsperado = mago1.GetAtaque() - elemento1.GetAtaque();
        int vidaActualEsperada = mago1.VidaActual - elemento1.GetDefensa();
        
        mago1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.VidaActual));
    }

    [Test]
    //Este test controla que el método Agregar Elemento no deje agregar más de una vez el elemento,
    //de manera que tampoco se sumen más de una vez el ataque y la defensa del elemento a
    //la vida y ataque del mago.
    public void TestAgregarElementoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = mago1.GetAtaque() + elemento1.GetAtaque();
        int vidaActualEsperada = mago1.VidaActual + elemento1.GetDefensa();

        mago1.AgregarElemento(elemento1);
        mago1.AgregarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.VidaActual));
    }

    [Test]
    //Este test controla que el método Quitar Elemento no deje quitar un elemento que nunca agregó.
    //Esto implica que tampoco se restan el ataque y la defensa de ese elemento al ataque y vida del mago.
    public void TestQuitarElementoFallido()
    {
        Mago mago1 = new Mago("Mago1");
        Elemento elemento1 = new Elemento("Elemento1", 10, 40);

        int ataqueEsperado = mago1.GetAtaque();
        int vidaActualEsperada = mago1.VidaActual;

        mago1.QuitarElemento(elemento1);
        
        Assert.That(ataqueEsperado, Is.EqualTo(mago1.GetAtaque()));
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.VidaActual));
    }

    [Test]
    //Este test controla que el método Curar funcione correctamente.
    //Si la vida actual del mago es menor a su vida base, puede restaurarla a la vida base.
    public void TestCurar()
    {
        Enano enano1 = new Enano("Enano1");
        Mago mago1 = new Mago("Mago1");
        enano1.AtacarMago(mago1);

        int vidaActualEsperadaMago1 = mago1.VidaActual + enano1.GetAtaque();
        
        mago1.Curar();
        
        Assert.That(vidaActualEsperadaMago1, Is.EqualTo(mago1.GetVidaBase()));
    }

    [Test]
    //Este test controla que el método Curar no deje curar cuando el mago tiene más vida o igual vida
    //que su vida base.
    public void TestCurarFallido()
    {
        Mago mago1 = new Mago("Mago1");

        int vidaActualEsperada = mago1.VidaActual;
        
        mago1.Curar();
        
        Assert.That(vidaActualEsperada, Is.EqualTo(mago1.GetVidaBase()));
    }
}