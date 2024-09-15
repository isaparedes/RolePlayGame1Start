namespace Library;

public class Hechizo
{
    private string nombre;

    public string GetNombre()
    {
        return this.nombre;
    }
    private int dano;
    public int GetDano()
    {
        return this.dano;
    }

    public Hechizo(string nombre, int dano)
    {
        this.nombre = nombre;
        this.dano = dano;
    }
}