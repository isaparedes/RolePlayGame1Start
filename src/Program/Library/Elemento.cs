namespace Library
{
    public class Elemento
    {
        private string nombre;
        private int daño;
        private int vidaMaxima;

        public Elemento(string nombre, int daño, int vidaMaxima)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.vidaMaxima = vidaMaxima;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetDaño()
        {
            return daño;
        }

        public int GetVidaMaxima()
        {
            return vidaMaxima;
        }
    }
}