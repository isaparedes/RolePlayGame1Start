using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    [TestOf(typeof(Hechizo))]
    public class HechizoTests
    {
        private Hechizo bolaDeFuego;

        [SetUp]
        public void SetUp()
        {
            bolaDeFuego = new Hechizo("Bola de fuego", 50);
        }

        [Test]
        public void TestHechizoProperties()
        {
            var nombre = bolaDeFuego.GetNombre();
            var dano = bolaDeFuego.GetDano();
            Assert.AreEqual("Bola de fuego", nombre);
            Assert.AreEqual(50, dano);
        }
    }
}