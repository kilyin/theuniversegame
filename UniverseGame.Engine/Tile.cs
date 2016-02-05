//-----------------------------------------------------------------------------
// Author: Konstantin Ilin
//-----------------------------------------------------------------------------

namespace UniverseGame.Engine
{
    public class Tile : IPassable
    {
        public Surface Surface { get; set; }

        public bool CanPass
        {
            get { return Surface != null ? Surface.CanPass : false; }
        }
    }
}
