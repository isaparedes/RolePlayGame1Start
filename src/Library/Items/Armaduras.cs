namespace Library;

    public class Armadura
    {
        public string Nombre { get; set; }
        public int ValorVida { get; set; }

        public Armadura(string nombre, int valorVida)
        {
            Nombre = nombre;
            ValorVida = valorVida;
        }
    }