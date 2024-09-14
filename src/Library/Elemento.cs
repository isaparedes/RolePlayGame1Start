namespace Library;

public class Elemento
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

    public Elemento(string nombre, int dano)
    {
        this.nombre = nombre;
        this.dano = dano;
    }
}