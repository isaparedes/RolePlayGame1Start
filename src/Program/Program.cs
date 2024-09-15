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
        
        //GetVidaBase
        Console.WriteLine(ulises.GetVidaBase());
        
        //GetAtaque
        victoria.GetAtaque();
        Console.WriteLine(victoria.GetAtaque());
        
        //Ataque
        vanesa.AtacarElfo(victoria);
        vanesa.AtacarElfo(victoria);
        victoria.AtacarEnano(isabela);
        isabela.AtacarElfo(ulises);
        ulises.AtacarMago(vanesa);
        
        //Ataque fallido
        isabela.AtacarElfo(victoria);
        
        //Curación
        victoria.Curar();
        isabela.Curar();
        ulises.Curar();
        vanesa.Curar();
        
        //Curación fallida
        isabela.Curar();
        
        //Crear elementos
        Elemento espada = new Elemento("Espada", 30);
        Elemento tacones = new Elemento("Tacones", 0);
        Elemento hongoMagico = new Elemento("Hongo mágico", 20);
        Elemento gorro = new Elemento("Gorro", 0);
        Elemento capa = new Elemento("Capa", 0);
        
        //Asignar elemento
        vanesa.AgregarElemento(capa); 
        victoria.AgregarElemento(hongoMagico);
        victoria.AgregarElemento(gorro);
        isabela.AgregarElemento(espada);
        isabela.AgregarElemento(tacones);
        ulises.AgregarElemento(tacones);
        ulises.AgregarElemento(hongoMagico);
        
        //Asignar elemento fallido
        vanesa.AgregarElemento(capa);
        
        //Quitar elemento
        victoria.QuitarElemento(hongoMagico);
        
        //Quitar elemento fallido
        victoria.QuitarElemento(hongoMagico);
        
        //Crear hechizo
        Hechizo bolaDeFuego = new Hechizo("Bola de fuego", 50);
        
        //Asignar hechizo 
        vanesa.AgregarHechizo(bolaDeFuego);
        
        //Asignar hechizo fallido
        vanesa.AgregarHechizo(bolaDeFuego);
        
        //Quitar hechizo 
        vanesa.QuitarHechizo(bolaDeFuego);
        
        //Quitar hechizo fallido
        vanesa.QuitarHechizo(bolaDeFuego);
    }
}