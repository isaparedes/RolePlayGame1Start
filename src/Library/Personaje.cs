namespace Library;

    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int VidaBase { get; private set; }
        public int VidaActual { get; private set; }
        public int AtaqueBase { get; private set; }
        public int AtaqueTotal { get { return AtaqueBase + (ArmaEquipada?.ValorAtaque ?? 0); } }
        public Arma ArmaEquipada { get; private set; }
        public Armadura ArmaduraEquipada { get; private set; }
        public string Clase { get; protected set; }

        protected Personaje(string nombre, int vidaBase, int ataqueBase)
        {
            Nombre = nombre;
            VidaBase = vidaBase;
            VidaActual = vidaBase; 
            AtaqueBase = ataqueBase;
            Clase = GetType().Name;
        }

        public void MostrarInfo()
        {
            int vidaMaxima = VidaBase; 
            if (ArmaduraEquipada != null)
            {
                vidaMaxima += ArmaduraEquipada.ValorVida; 
            }

            Console.WriteLine($"{Nombre} ({Clase})");
            Console.WriteLine($"Vida Base: {VidaBase}");
            Console.WriteLine($"Vida Actual: {VidaActual}");
            Console.WriteLine($"Vida Máxima: {vidaMaxima}");
            Console.WriteLine($"Ataque Base: {AtaqueBase}");
            Console.WriteLine($"Ataque Total: {AtaqueTotal}");

            if (ArmaEquipada != null)
                Console.WriteLine($"Arma equipada: {ArmaEquipada.Nombre} (Ataque: {ArmaEquipada.ValorAtaque})");
            else
                Console.WriteLine("No tiene arma equipada.");

            if (ArmaduraEquipada != null)
                Console.WriteLine($"Armadura equipada: {ArmaduraEquipada.Nombre} (Vida Extra: {ArmaduraEquipada.ValorVida})");
            else
                Console.WriteLine("No tiene armadura equipada.");

            Console.WriteLine();
        }

        public void RecibirDanio(int danio)
        {
            int danioReal = danio;
            VidaActual -= Math.Max(danioReal, 0); 
            VidaActual = Math.Max(VidaActual, 0); 
            Console.WriteLine($"{Nombre} ha recibido {danioReal} de daño. Vida actual: {VidaActual}");
        }

        public void Curar(int cantidad)
        {
            int vidaMaxima = VidaBase;
            if (ArmaduraEquipada != null)
            {
                vidaMaxima += ArmaduraEquipada.ValorVida;
            }
            
            int cantidadCurada = Math.Min(cantidad, vidaMaxima - VidaActual);
            VidaActual += cantidadCurada;
            Console.WriteLine($"{Nombre} ha sido curado por {cantidadCurada} puntos de vida. Vida actual: {VidaActual}");
        }

        public void EquiparArma(Arma arma)
        {
            if (ArmaEquipada != null)
                Console.WriteLine($"{Nombre} ya tiene un arma equipada ({ArmaEquipada.Nombre}). Desequipando...");

            ArmaEquipada = arma;
            Console.WriteLine($"{Nombre} ha equipado {arma.Nombre}.");
        }

        public void QuitarArma()
        {
            if (ArmaEquipada != null)
            {
                Console.WriteLine($"{Nombre} ha desequipado {ArmaEquipada.Nombre}.");
                ArmaEquipada = null;
            }
        }

        public void EquiparArmadura(Armadura armadura)
        {
            if (ArmaduraEquipada != null)
                Console.WriteLine($"{Nombre} ya tiene una armadura equipada ({ArmaduraEquipada.Nombre}). Desequipando...");

            ArmaduraEquipada = armadura;
            VidaBase += armadura.ValorVida; 
            VidaActual = Math.Min(VidaActual + armadura.ValorVida, VidaBase);
            Console.WriteLine($"{Nombre} ha equipado {armadura.Nombre}.");
        }

        public void QuitarArmadura()
        {
            if (ArmaduraEquipada != null)
            {
                Console.WriteLine($"{Nombre} ha desequipado {ArmaduraEquipada.Nombre}.");
                VidaBase -= ArmaduraEquipada.ValorVida;
                ArmaduraEquipada = null;
                VidaActual = Math.Min(VidaActual, VidaBase);
            }
        }
    }