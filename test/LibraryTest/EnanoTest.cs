using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    [TestOf(typeof(Enano))]
    public class EnanoTests
    {
        private Enano isabela;
        private Elfo ulises;
        private Elemento espada;
        private Elemento tacones;

        [SetUp]
        public void SetUp()
        {
            isabela = new Enano("Isabela");
            ulises = new Elfo("Ulises");
            espada = new Elemento("Espada", 30, 0);
            tacones = new Elemento("Tacones", 0, 5);
        }

        [Test]
        public void TestEnanoInitialProperties()
        {
            var nombre = isabela.GetNombre();
            var vidaBase = isabela.GetVidaBase();
            var ataque = isabela.GetAtaque();
            Assert.AreEqual("Isabela", nombre);
            Assert.AreEqual(800, vidaBase);
            Assert.AreEqual(200, ataque);
        }

        [Test]
        public void TestEnanoEquipAndUseElement()
        {
            isabela.AgregarElemento(espada);
            isabela.AgregarElemento(tacones);
            Assert.AreEqual(230, isabela.GetAtaque());
            isabela.AtacarElfo(ulises);
            Assert.AreEqual(800 - isabela.GetAtaque(), ulises.VidaActual); 
        }

        [Test]
        public void TestEnanoCurar()
        {
            isabela.VidaActual = 500; 
            isabela.Curar();
            Assert.AreEqual(800, isabela.VidaActual); 
        }
    }
}