namespace Library;

public class Elemento
{
    private string nombre;
    private int ataque;
    private int defensa;
    public string GetNombre()
    {
        return this.nombre;
    }
    public int GetAtaque()
    {
        return this.ataque;
    }

    public int GetDefensa()
    {
        return this.defensa;
    }

    public Elemento(string nombre, int ataque, int defensa)
    {
        this.nombre = nombre;
        this.ataque = ataque;
        this.defensa = defensa;
    }
}