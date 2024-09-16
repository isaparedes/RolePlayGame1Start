namespace Library;

public class Hechizo
{
    private string nombre;
    private int ataque;
    public string GetNombre()
    {
        return this.nombre;
    }
    public int GetAtaque()
    {
        return this.ataque;
    }

    public Hechizo(string nombre, int ataque)
    {
        this.nombre = nombre;
        this.ataque = ataque;
    }
}