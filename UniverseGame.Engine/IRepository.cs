
namespace UniverseGame.Engine
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        void Store(IList<T> entities);

        IList<T> Restore();
    }
}
