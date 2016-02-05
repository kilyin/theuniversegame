//-----------------------------------------------------------------------------
// Author: Konstantin Ilin
//-----------------------------------------------------------------------------

namespace UniverseGame.Engine
{
    public class Floor : Surface
    {
        bool canPass = true;

        public override bool CanPass
        {
            get
            {
                return canPass;
            }
            protected set
            {
                canPass = value;
            }
        }

        public override SurfaceOrientation Orientation
        {
            get
            {
                return SurfaceOrientation.Horizontal;
            }
            protected set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
