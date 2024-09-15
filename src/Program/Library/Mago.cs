using System.Collections;

namespace Library
{
    public class Mago
    {
        private string nombre;
        private int vidaActual = 800;
        private int vidaBase = 800;
        private int ataque = 200;
        private ArrayList listaElementos = new ArrayList();
        private ArrayList listaHechizos = new ArrayList(); //Esto refiere al libro de hechizos

        public Mago(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int VidaActual
        {
            get { return vidaActual; }
            set { vidaActual = value; }
        }

        public int GetVidaBase()
        {
            return this.vidaBase;
        }

        public int GetAtaque()
        {
            return this.ataque;
        }

        // Nuevo método para aumentar la vida máxima
        public void AumentarVidaMaxima(int incremento)
        {
            if (incremento > 0)
            {
                vidaBase += incremento;
                vidaActual = vidaBase; // Restablecer la vida actual al nuevo máximo
                Console.WriteLine($"{nombre} ha incrementado su vida máxima en {incremento} puntos. La vida máxima ahora es {vidaBase} puntos.");
            }
        }

        public void AgregarHechizo(Hechizo hechizo)
        {
            Console.WriteLine("\nADQUIRIR HECHIZO:");
            if (hechizo != null && !this.listaHechizos.Contains(hechizo))
            {
                this.listaHechizos.Add(hechizo);
                this.ataque += hechizo.GetDano();
                Console.WriteLine($"{this.nombre} ha adquirido el hechizo ¨{hechizo.GetNombre()}¨.");
                Console.WriteLine($"Su ataque ha sumado {hechizo.GetDano()} puntos. Ahora es de {this.ataque} puntos.");
            }
            else
            {
                Console.WriteLine($"No fue posible adquirir. {this.nombre} ya posee el hechizo ¨{hechizo.GetNombre()}¨.");
            }
        }

        public void QuitarHechizo(Hechizo hechizo)
        {
            Console.WriteLine("\nDESECHAR HECHIZO:");
            if (hechizo != null && this.listaHechizos.Contains(hechizo))
            {
                this.listaHechizos.Remove(hechizo);
                this.ataque -= hechizo.GetDano();
                Console.WriteLine($"{this.nombre} se ha desecho del hechizo ¨{hechizo.GetNombre()}¨.");
                Console.WriteLine($"Su ataque ha restado {hechizo.GetDano()} puntos. Ahora es de {this.ataque} puntos.");
            }
            else
            {
                Console.WriteLine($"No fue posible desechar. {this.nombre} no posee el hechizo ¨{hechizo.GetNombre()}¨.");
            }
        }

        // Modificado para manejar bono de vida
        public void AgregarElemento(Elemento elemento)
        {
            Console.WriteLine("\nADQUIRIR ELEMENTO:");
            if (elemento != null && !this.listaElementos.Contains(elemento))
            {
                this.listaElementos.Add(elemento);
                this.ataque += elemento.GetDaño();
                Console.WriteLine($"{this.nombre} ha adquirido el elemento ¨{elemento.GetNombre()}¨.");
                Console.WriteLine($"Su ataque ha sumado {elemento.GetDaño()} puntos. Ahora es de {this.ataque} puntos.");

                if (elemento.GetVidaMaxima() > 0)
                {
                    AumentarVidaMaxima(elemento.GetVidaMaxima());
                }
            }
            else
            {
                Console.WriteLine($"No fue posible adquirir. {this.nombre} ya posee el elemento ¨{elemento.GetNombre()}¨.");
            }
        }

        // Modificado para quitar bono de vida
        public void QuitarElemento(Elemento elemento)
        {
            Console.WriteLine("\nDESECHAR ELEMENTO:");
            if (elemento != null && this.listaElementos.Contains(elemento))
            {
                this.listaElementos.Remove(elemento);
                this.ataque -= elemento.GetDaño();
                Console.WriteLine($"{this.nombre} se ha desecho del elemento ¨{elemento.GetNombre()}¨.");
                Console.WriteLine($"Su ataque ha restado {elemento.GetDaño()} puntos. Ahora es de {this.ataque} puntos.");

                if (elemento.GetVidaMaxima() > 0)
                {
                    int reduccionVida = elemento.GetVidaMaxima();
                    vidaBase -= reduccionVida;
                    if (vidaActual > vidaBase)
                    {
                        vidaActual = vidaBase;
                    }
                    Console.WriteLine($"La vida máxima ha sido reducida en {reduccionVida} puntos. La vida máxima ahora es {vidaBase}.");
                }
            }
            else
            {
                Console.WriteLine($"No fue posible desechar. {this.nombre} no posee el elemento ¨{elemento.GetNombre()}¨.");
            }
        }

        public void AtacarMago(Mago mago)
        {
            Console.WriteLine("\nATAQUE:");
            if (mago != null && mago.VidaActual >= this.ataque)
            {
                mago.VidaActual -= this.ataque;
                Console.WriteLine($"{this.nombre} ha atacado a {mago.GetNombre()}.");
                Console.WriteLine($"La vida de {mago.GetNombre()} ha restado {this.ataque} puntos.");
                Console.WriteLine($"La vida actual de {mago.GetNombre()} es de {mago.VidaActual} puntos.");
            }
            else
            {
                Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {mago.GetNombre()}.");
                Console.WriteLine($"{mago.GetNombre()} no tiene suficientes puntos de vida.");
            }
        }
        public void AtacarElfo(Elfo elfo)
        {
            Console.WriteLine("\nATAQUE:");
            if (elfo != null && elfo.VidaActual >= this.ataque)
            {
                elfo.VidaActual -= this.ataque;
                Console.WriteLine($"{this.nombre} ha atacado a {elfo.GetNombre()}.");
                Console.WriteLine($"La vida de {elfo.GetNombre()} ha restado {this.ataque} puntos.");
                Console.WriteLine($"La vida actual de {elfo.GetNombre()} es de {elfo.VidaActual} puntos.");
            }
            else
            {
                Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {elfo.GetNombre()}.");
                Console.WriteLine($"{elfo.GetNombre()} no tiene suficientes puntos de vida.");
            }
        }

        public void AtacarEnano(Enano enano)
        {
            Console.WriteLine("\nATAQUE:");
            if (enano != null && enano.VidaActual >= this.ataque)
            {
                enano.VidaActual -= this.ataque;
                Console.WriteLine($"{this.nombre} ha atacado a {enano.GetNombre()}.");
                Console.WriteLine($"La vida de {enano.GetNombre()} ha restado {this.ataque} puntos.");
                Console.WriteLine($"La vida actual de {enano.GetNombre()} es de {enano.VidaActual} puntos.");
            }
            else
            {
                Console.WriteLine($"No se ha podido concretar el ataque de {this.nombre} a {enano.GetNombre()}.");
                Console.WriteLine($"{enano.GetNombre()} no tiene suficientes puntos de vida.");
            }
        }
        public void Curar()
        {
            Console.WriteLine("\nCURACIÓN:");
            if (this.vidaActual < this.vidaBase)
            {
                this.vidaActual = this.vidaBase;
                Console.WriteLine($"{this.nombre} se ha curado. Su vida actual es de {this.vidaActual} puntos.");
            }
            else
            {
                Console.WriteLine($"No fue posible curarse. {this.nombre} ya tiene todos los puntos de vida.");
            }
        }
    }
}