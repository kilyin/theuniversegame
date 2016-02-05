//-----------------------------------------------------------------------------
// Author: Konstantin Ilin
//-----------------------------------------------------------------------------

namespace UniverseGame.Engine
{
    public class Wall : Surface
    {
        private bool canPass = false;
        public override bool CanPass
        {
            get { return canPass; }
            protected set { canPass = value; }
        }

        public override SurfaceOrientation Orientation
        {
            get
            {
                return SurfaceOrientation.Vertical;
            }
            protected set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
