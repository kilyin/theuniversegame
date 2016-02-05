//-----------------------------------------------------------------------------
// Author: Konstantin Ilin
//-----------------------------------------------------------------------------

namespace UniverseGame.Engine
{
    public enum SurfaceOrientation { Horizontal = 0, Vertical = 1 }

    public abstract class Surface : IPassable
    {
        public abstract bool CanPass { get; protected set; }

        public abstract SurfaceOrientation Orientation { get; protected set; }
    }
}
