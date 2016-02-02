
namespace UniverseGame.Repository.UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using UniverseGame.Engine;
    using UniverseGame.Repository;

    [TestClass]
    public class ItemRepositoryTests
    {
        [TestMethod]
        public void ItemRepository__ConvertToJson()
        {
            var item = new Item()
            {
                Title = "Test Item"
            };

            var itemRepository = new ItemRepository();

            var stringItem = itemRepository.ConvertToJson(new[] { item });

            Assert.IsFalse(string.IsNullOrWhiteSpace(stringItem));
        }

        [TestMethod]
        public void ItemRepository_Store()
        {
            var item1 = new Item()
            {
                Title = "Test Item 1"
            };
            var item2 = new Item()
            {
                Title = "Test Item 2"
            };

            var itemRepository = new ItemRepository();

            itemRepository.Store(new[] { item1, item2 });
        }

        [TestMethod]
        public void ItemRepository_Restore()
        {
            var itemRepository = new ItemRepository();

            var items = itemRepository.Restore();

            Assert.IsNotNull(items);
            Assert.IsTrue(items.Count > 0);
        }
    }
}
