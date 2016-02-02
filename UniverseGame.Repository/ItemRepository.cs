
namespace UniverseGame.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    using UniverseGame.Engine;

    public class ItemRepository : IRepository<IItem>
    {
        public string ConvertToJson(IList<IItem> item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public void Store(IList<IItem> items)
        {
            var itemsJson = ConvertToJson(items);
            throw new NotImplementedException();
        }
        
        public IList<IItem> Restore()
        {
            var itemsJson = TextFileReader.Read("data\\Items.json");
            IList<IItem> result = JsonConvert.DeserializeObject<Item[]>(itemsJson);

            return result.ToList();
        }
    }
}
