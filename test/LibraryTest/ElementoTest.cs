using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    [TestOf(typeof(Elemento))]
    public class ElementoTests
    {
        private Elemento espada;
        private Elemento tacones;
        private Elemento hongoMagico;
        private Elemento gorro;
        private Elemento capa;

        [SetUp]
        public void SetUp()
        {
            espada = new Elemento("Espada", 30, 0);
            tacones = new Elemento("Tacones", 0, 5);
            hongoMagico = new Elemento("Hongo mágico", 20, 0);
            gorro = new Elemento("Gorro", 0, 5);
            capa = new Elemento("Capa", 0, 10);
        }

        [Test]
        public void TestElementoProperties()
        {
            var nombre = espada.GetNombre();
            var dano = espada.GetDaño();
            var vidaMaxima = espada.GetVidaMaxima();
            Assert.AreEqual("Espada", nombre);
            Assert.AreEqual(30, dano);
            Assert.AreEqual(0, vidaMaxima);
        }
    }
}