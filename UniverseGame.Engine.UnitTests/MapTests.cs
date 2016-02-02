
namespace UniverseGame.Engine.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using UniverseGame.Engine;

    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void Map_Create()
        {
            var map = new Map();

            Assert.IsNotNull(map);
            Assert.IsTrue(map.SizeX > 0);
            Assert.IsTrue(map.SizeY > 0);
            Assert.IsTrue(map.SizeZ > 0);
        }
    }
}
