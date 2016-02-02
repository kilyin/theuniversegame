
namespace UniverseGame.Engine
{
    using System;
    using System.Collections.Generic;

    public interface IContainer
    {
        IList<IItem> Items { get; set; }

        uint StorageSize { get; set; }
    }
}
