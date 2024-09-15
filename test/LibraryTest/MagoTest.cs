using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    [TestOf(typeof(Mago))]
    public class MagoTests
    {
        private Mago vanesa;
        private Elemento capa;
        private Hechizo bolaDeFuego;
        private Elfo victoria;

        [SetUp]
        public void SetUp()
        {
            capa = new Elemento("Capa", 0, 10);
            bolaDeFuego = new Hechizo("Bola de fuego", 50);
            vanesa = new Mago("Vanesa");
            victoria = new Elfo("Victoria");
        }

        [Test]
        public void TestMagoInitialProperties()
        {
            var nombre = vanesa.GetNombre();
            var vidaBase = vanesa.GetVidaBase();
            var ataque = vanesa.GetAtaque();
            Assert.AreEqual("Vanesa", nombre);
            Assert.AreEqual(800, vidaBase);
            Assert.AreEqual(200, ataque);
        }

        [Test]
        public void TestMagoEquipAndUseElement()
        {
            vanesa.AgregarElemento(capa);
            Assert.AreEqual(200, vanesa.GetAtaque());
            vanesa.AtacarElfo(victoria);
            Assert.AreEqual(800 - vanesa.GetAtaque(), victoria.VidaActual); 
        }

        [Test]
        public void TestMagoAddAndRemoveHechizo()
        {
            vanesa.AgregarHechizo(bolaDeFuego);
            Assert.AreEqual(250, vanesa.GetAtaque()); 
            vanesa.QuitarHechizo(bolaDeFuego);
            Assert.AreEqual(200, vanesa.GetAtaque()); 
        }

        [Test]
        public void TestMagoCurar()
        {
            vanesa.VidaActual = 500; 
            vanesa.Curar();
            Assert.AreEqual(800, vanesa.VidaActual); 
        }
    }
}