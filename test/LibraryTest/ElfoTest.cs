using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    [TestOf(typeof(Elfo))]
    public class ElfoTests
    {
        private Elfo victoria;
        private Enano isabela;
        private Elemento hongoMagico;
        private Elemento gorro;

        [SetUp]
        public void SetUp()
        {
            victoria = new Elfo("Victoria");
            isabela = new Enano("Isabela");
            hongoMagico = new Elemento("Hongo mágico", 20, 0);
            gorro = new Elemento("Gorro", 0, 5);
        }

        [Test]
        public void TestElfoInitialProperties()
        {
            var nombre = victoria.GetNombre();
            var vidaBase = victoria.GetVidaBase();
            var ataque = victoria.GetAtaque();
            Assert.AreEqual("Victoria", nombre);
            Assert.AreEqual(800, vidaBase);
            Assert.AreEqual(200, ataque);
        }

        [Test]
        public void TestElfoEquipAndUseElement()
        {
            victoria.AgregarElemento(hongoMagico);
            victoria.AgregarElemento(gorro);
            Assert.AreEqual(205, victoria.GetAtaque()); 
            victoria.AtacarEnano(isabela);
            Assert.AreEqual(800 - victoria.GetAtaque(), isabela.VidaActual); 
        }

        [Test]
        public void TestElfoCurar()
        {
            victoria.VidaActual = 500; 
            victoria.Curar();
            Assert.AreEqual(800, victoria.VidaActual);
        }
    }
}