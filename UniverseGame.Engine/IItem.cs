using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseGame.Engine
{
    public interface IItem : ISize, ISmashable, IPassable
    {
        string Title { get; set; }
    }
}
