using System.Collections;
namespace Library;

public class Enano
{
    private string nombre;
    public string GetNombre()
    {
        return this.nombre;
    }
    public int vidaActual = 600;
    private int vidaBase = 600;
    private int ataque = 300;
    private ArrayList listaElementos = new ArrayList();
    public Enano(string nombre)
    {
        this.nombre = nombre;
    }
    
    public int GetAtaque()
    {
        return this.ataque;
    }

    public void AgregarElemento(Elemento elemento)
    {
        if (elemento != null && !this.listaElementos.Contains(elemento))
        {
            this.listaElementos.Add(elemento);
            this.ataque += elemento.GetDano();
            Console.WriteLine($"\n{this.nombre} ha adquirido el elemento ¨{elemento.GetNombre()}¨.");
            Console.WriteLine($"Su ataque ha sumado {elemento.GetDano()} puntos. Ahora es de {this.ataque} puntos.");
        }
    }
    
    public void QuitarElemento(Elemento elemento)
    {
        if (elemento != null && this.listaElementos.Contains(elemento))
        {
            this.listaElementos.Remove(elemento);
            this.ataque -= elemento.GetDano();
            Console.WriteLine($"\n{this.nombre} se ha deshecho del elemento ¨{elemento.GetNombre()}¨.");
            Console.WriteLine($"Su ataque ha restado {elemento.GetDano()} puntos. Ahora es de {this.ataque} puntos.");
        }
    }
    
    public void AtacarEnano(Enano enano)
    {
        if (enano != null && enano.vidaActual >= this.ataque)
            enano.vidaActual -= this.ataque;
        Console.WriteLine($"\n{this.nombre} ha atacado a {enano.GetNombre()}.");
        Console.WriteLine($"La vida de {enano.GetNombre()} ha restado {this.ataque} puntos.");
        Console.WriteLine($"La vida actual de {enano.GetNombre()} es de {enano.vidaActual}.");
    }
    
    public void AtacarMago(Mago mago)
    {
        if (mago != null && mago.vidaActual >= this.ataque)  
            mago.vidaActual -= this.ataque;
        Console.WriteLine($"\n{this.nombre} ha atacado a {mago.GetNombre()}.");
        Console.WriteLine($"La vida de {mago.GetNombre()} ha restado {this.ataque} puntos.");
        Console.WriteLine($"La vida actual de {mago.GetNombre()} es de {mago.vidaActual}.");
    }

    public void AtacarElfo(Elfo elfo)
    {
        if (elfo != null && elfo.vidaActual >= this.ataque)
            elfo.vidaActual -= this.ataque;
        Console.WriteLine($"\n{this.nombre} ha atacado a {elfo.GetNombre()}.");
        Console.WriteLine($"La vida de {elfo.GetNombre()} ha restado {this.ataque} puntos.");
        Console.WriteLine($"La vida actual de {elfo.GetNombre()} es de {elfo.vidaActual}.");
    }
    
    public void Curar()
    {
        if (this.vidaActual < this.vidaBase)
            this.vidaActual = this.vidaBase;
        Console.WriteLine($"\n{this.nombre} se ha curado. Su vida actual es de {this.vidaActual}.");
    }
}