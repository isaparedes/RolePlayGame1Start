namespace Library;

public class Arma
{
    public string Nombre { get; set; }
    public int ValorAtaque { get; set; }

    public Arma(string nombre, int valorAtaque)
    {
        Nombre = nombre;   
        ValorAtaque = valorAtaque;
    }
}
