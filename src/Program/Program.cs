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
        
        //Crear elementos
        Elemento espada = new Elemento("Espada", 30, 20);
        Elemento tacones = new Elemento("Tacones", 0, 0);
        Elemento hongoMagico = new Elemento("Hongo mágico", 20, 0);
        Elemento gorro = new Elemento("Gorro", 0, 40);
        Elemento capa = new Elemento("Capa", 0, 30);

        //Asignar elementos
        vanesa.AgregarElemento(capa);
        victoria.AgregarElemento(hongoMagico);
        victoria.AgregarElemento(gorro);
        isabela.AgregarElemento(espada);
        isabela.AgregarElemento(tacones);
        ulises.AgregarElemento(tacones);
        ulises.AgregarElemento(hongoMagico);
        
        //Crear hechizo
        Hechizo bolaDeFuego = new Hechizo("Bola de fuego", 50);

        //Asignar hechizo 
        vanesa.AgregarHechizo(bolaDeFuego);

        //Ataque
        vanesa.AtacarElfo(victoria);
        victoria.AtacarEnano(isabela);
        isabela.AtacarElfo(ulises);
        ulises.AtacarMago(vanesa);

        //Curación
        victoria.Curar();
        isabela.Curar();
        ulises.Curar();
        vanesa.Curar();

        //Quitar elemento
        victoria.QuitarElemento(hongoMagico);

        //Quitar hechizo 
        vanesa.QuitarHechizo(bolaDeFuego);
    }
}