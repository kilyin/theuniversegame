
namespace UniverseGame.Engine
{
    using System;
    using System.Collections.Generic;

    public class Item : IItem
    {
        public uint Size { get; set; }

        public bool CanPass { get; set; }

        public string Title { get; set; }
    }
}
