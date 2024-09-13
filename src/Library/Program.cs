namespace Library;

    class Program
    {
        static void Main(string[] args)
        {
            //Crear armas y armaduras 
            Arma espada = new Arma("Espada de Plata", 50);
            Armadura armadura = new Armadura("Armadura de Cota de Malla", 100);
            
            //Crear personajes
            Personaje mago = new Mago("Gandalf");
            Personaje elfo = new Elfo("Legolas");
            Personaje enano = new Enano("Gimli");
            
            // Mostrar información inicial
            Console.WriteLine("Información inicial:");
            mago.MostrarInfo();
            elfo.MostrarInfo();
            enano.MostrarInfo();

            // Equipar elementos
            mago.EquiparArma(espada);
            elfo.EquiparArmadura(armadura);
            enano.EquiparArma(espada);

            // Mostrar información después de equipar
            Console.WriteLine("\nInformación después de equipar elementos:");
            mago.MostrarInfo();
            elfo.MostrarInfo();
            enano.MostrarInfo();

            // Simular combate
            Console.WriteLine("\nInicio del combate:");
            Combate combate = new Combate();
            combate.Atacar(mago, elfo);
            combate.Atacar(elfo, mago);

            // Curación
            Console.WriteLine("\nCuración:");
            Curacion curacion = new Curacion();
            curacion.Curar(mago, 50);
            curacion.Curar(elfo, 50);

            // Mostrar información final de los personajes
            Console.WriteLine("\nInformación final:");
            mago.MostrarInfo();
            elfo.MostrarInfo();
            enano.MostrarInfo();

            // Desequipar armas y armaduras
            Console.WriteLine("\nDespués de desequipar los elementos:");
            mago.QuitarArma();
            mago.QuitarArmadura();
            elfo.QuitarArmadura();
            enano.QuitarArma();

            // Mostrar información final después de desequipar
            Console.WriteLine("\nInformación después de desequipar:");
            mago.MostrarInfo();
            elfo.MostrarInfo();
            enano.MostrarInfo();
        }
    }