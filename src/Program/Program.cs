using Library;
public class Program
{
    public static void Main()
    {
        //Crear personajes
        Mago vanesa = new Mago("Vanesa");
        Elfo victoria = new Elfo("Victoria");
        Enano isabela = new Enano("Isabela");
        Elfo ulises = new Elfo("Ulises");
        
        //Atacar
        vanesa.AtacarElfo(victoria);
        victoria.AtacarEnano(isabela);
        victoria.AtacarElfo(ulises);
        
        //Curarse
        victoria.Curar();
        isabela.Curar();
        ulises.Curar();
        
        //Crear elementos
        Elemento espada = new Elemento("Espada", 30);
        Elemento tacones = new Elemento("Tacones", 0);
        Elemento hongoMagico = new Elemento("Hongo mágico", 20);
        Elemento gorro = new Elemento("Gorro", 0);
        Elemento capa = new Elemento("Capa", 0);
        
        //Asignar elementos a personajes
        vanesa.AgregarElemento(capa);
        victoria.AgregarElemento(hongoMagico);
        victoria.AgregarElemento(gorro);
        isabela.AgregarElemento(espada);
        isabela.AgregarElemento(tacones);
        ulises.AgregarElemento(tacones);
        ulises.AgregarElemento(hongoMagico);
        
        //Crear hechizo
        Hechizo bolaDeFuego = new Hechizo("Bola de fuego", 50);
        vanesa.AgregarHechizo(bolaDeFuego);
    }
}