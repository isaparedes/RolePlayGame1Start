using System;
using Library;

public class Program
{
    public static void Main()
    {
        // Crear personajes
        Mago vanesa = new Mago("Vanesa");
        Elfo victoria = new Elfo("Victoria");
        Enano isabela = new Enano("Isabela");
        Elfo ulises = new Elfo("Ulises");
        
        // Mostrar vida base y ataque inicial de los personajes
        Console.WriteLine($"Vida base de Ulises: {ulises.GetVidaBase()}");
        Console.WriteLine($"Ataque de Victoria: {victoria.GetAtaque()}");

        // Ataques
        vanesa.AtacarElfo(victoria);
        victoria.AtacarEnano(isabela);
        isabela.AtacarElfo(ulises);
        ulises.AtacarMago(vanesa);
        victoria.AtacarElfo(ulises);
        // Curaciones
        victoria.Curar();
        isabela.Curar();
        ulises.Curar();
        vanesa.Curar();

        // Crear elementos
        Elemento espada = new Elemento("Espada", 30, 0);
        Elemento tacones = new Elemento("Tacones", 0, 5); 
        Elemento hongoMagico = new Elemento("Hongo mágico", 20, 0);
        Elemento gorro = new Elemento("Gorro", 0, 5); 
        Elemento capa = new Elemento("Capa", 0, 10); 
        
        // Asignar elementos y mostrar efectos en la vida máxima
        Console.WriteLine("\nAsignar elementos:");
        vanesa.AgregarElemento(capa); 
        victoria.AgregarElemento(hongoMagico);
        victoria.AgregarElemento(gorro); 
        isabela.AgregarElemento(espada);
        isabela.AgregarElemento(tacones); 
        ulises.AgregarElemento(tacones); 
        ulises.AgregarElemento(hongoMagico);

        // Intentar agregar un elemento ya existente
        Console.WriteLine("\nIntentar agregar elemento existente:");
        vanesa.AgregarElemento(capa); 

        // Quitar elementos y mostrar efectos en la vida máxima
        Console.WriteLine("\nQuitar elementos:");
        victoria.QuitarElemento(hongoMagico); 
        victoria.QuitarElemento(hongoMagico); 

        // Crear hechizo
        Hechizo bolaDeFuego = new Hechizo("Bola de fuego", 50);
        
        // Asignar hechizo
        Console.WriteLine("\nAsignar hechizo:");
        vanesa.AgregarHechizo(bolaDeFuego);

        // Intentar agregar un hechizo ya existente
        Console.WriteLine("\nIntentar agregar hechizo existente:");
        vanesa.AgregarHechizo(bolaDeFuego); 

        // Quitar hechizo
        Console.WriteLine("\nQuitar hechizo:");
        vanesa.QuitarHechizo(bolaDeFuego);

        // Intentar quitar un hechizo ya inexistente
        Console.WriteLine("\nIntentar quitar hechizo inexistente:");
        vanesa.QuitarHechizo(bolaDeFuego); 
    }
}
