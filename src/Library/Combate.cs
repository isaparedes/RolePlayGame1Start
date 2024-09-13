namespace Library;

public class Combate
{
    //ataca primero el nombre del primer personaje y el que defiende o recibe el ataque es el segundo
    public void Atacar(Personaje atacante, Personaje defensor) 
    {
        int danio = atacante.AtaqueTotal;
        Console.WriteLine($"{atacante.Nombre} ataca a {defensor.Nombre} con {danio} de daño.");
        defensor.RecibirDanio(danio);
    }
}
