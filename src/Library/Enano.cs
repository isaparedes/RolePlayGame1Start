using System.Collections;
namespace Library;

public class Enano
{
    private string nombre;
    private int vidaActual = 600;
    private int vidaBase = 600;
    private int ataque = 300;
    private ArrayList listaElementos = new ArrayList();
    public Enano(string nombre)
    {
        this.nombre = nombre;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public int VidaActual
    {
        get { return vidaActual; }
        set { vidaActual = value; }
    }
    public int GetVidaBase()
    {
        return this.vidaBase;
    }
    public int GetAtaque()
    {
        return ataque;
    }
    public void AgregarElemento(Elemento elemento)
    {
        Console.WriteLine("\nADQUIRIR ELEMENTO:");
        if (elemento != null && !this.listaElementos.Contains(elemento))
        {
            this.listaElementos.Add(elemento);
            this.ataque += elemento.GetAtaque();
            this.vidaActual += elemento.GetDefensa();
            Console.WriteLine($"{this.nombre} ha adquirido el elemento ¨{elemento.GetNombre()}¨.");
            Console.WriteLine($"Su vida actual ha sumado {elemento.GetDefensa()} puntos. Ahora es de {this.vidaActual} puntos.");
            Console.WriteLine($"Su ataque ha sumado {elemento.GetAtaque()} puntos. Ahora es de {this.ataque} puntos.");
        }
        else
        {
            Console.WriteLine($"No fue posible adquirir. {this.nombre} ya posee el elemento ¨{elemento.GetNombre()}¨.");
        }
    }
    
    public void QuitarElemento(Elemento elemento)
    {
        Console.WriteLine("\nDESECHAR ELEMENTO:");
        if (elemento != null && this.listaElementos.Contains(elemento))
        {
            this.listaElementos.Remove(elemento);
            this.ataque -= elemento.GetAtaque();
            this.vidaActual -= elemento.GetDefensa();
            Console.WriteLine($"{this.nombre} se ha desecho del elemento ¨{elemento.GetNombre()}¨.");
            Console.WriteLine($"Su vida actual ha restado {elemento.GetDefensa()} puntos. Ahora es de {this.vidaActual} puntos.");
            Console.WriteLine($"Su ataque ha restado {elemento.GetAtaque()} puntos. Ahora es de {this.ataque} puntos.");
        }
        else
        {
            Console.WriteLine($"No fue posible desechar. {this.nombre} no posee el elemento ¨{elemento.GetNombre()}¨.");
        }
    }
    
    public void AtacarEnano(Enano enano)
    {
        if (enano != null && enano.VidaActual >= this.ataque)
        {
            Console.WriteLine("\nATAQUE:");
            enano.VidaActual -= this.ataque;
            Console.WriteLine($"{this.nombre} ha atacado a {enano.GetNombre()}.");
            Console.WriteLine($"La vida de {enano.GetNombre()} ha restado {this.ataque} puntos.");
            Console.WriteLine($"La vida actual de {enano.GetNombre()} es de {enano.VidaActual} puntos.");
        }
        else
        {
            Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {enano.GetNombre()}.");
            Console.WriteLine($"{enano.GetNombre()} no tiene suficientes puntos de vida.");
        }
    }
    
    public void AtacarMago(Mago mago)
    {
        Console.WriteLine("\nATAQUE:");
        if (mago != null && mago.VidaActual >= this.ataque)
        {
            mago.VidaActual -= this.ataque;
            Console.WriteLine($"{this.nombre} ha atacado a {mago.GetNombre()}.");
            Console.WriteLine($"La vida de {mago.GetNombre()} ha restado {this.ataque} puntos.");
            Console.WriteLine($"La vida actual de {mago.GetNombre()} es de {mago.VidaActual} puntos.");
        }
        else
        { 
            Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {mago.GetNombre()}.");
            Console.WriteLine($"{mago.GetNombre()} no tiene suficientes puntos de vida.");
        }
    }

    public void AtacarElfo(Elfo elfo)
    {
        Console.WriteLine("\nATAQUE:");
        if (elfo != null && elfo.VidaActual >= this.ataque)
        {
            elfo.VidaActual -= this.ataque;
            Console.WriteLine($"{this.nombre} ha atacado a {elfo.GetNombre()}.");
            Console.WriteLine($"La vida de {elfo.GetNombre()} ha restado {this.ataque} puntos.");
            Console.WriteLine($"La vida actual de {elfo.GetNombre()} es de {elfo.VidaActual} puntos.");
        }
        else
        {
            Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {elfo.GetNombre()}.");
            Console.WriteLine($"{elfo.GetNombre()} no tiene suficientes puntos de vida.");
        }
    }
    
    public void Curar()
    {
        Console.WriteLine("\nCURACIÓN:");
        if (this.vidaActual < this.vidaBase)
        {
            this.vidaActual = this.vidaBase;
            Console.WriteLine($"{this.nombre} se ha curado. Su vida actual es de {this.vidaActual} puntos.");
        }
        else
        {
            Console.WriteLine($"No fue posible curarse. {this.nombre} ya tiene todos los puntos de vida.");
        }
    }
}