
using System.IO;
namespace UniverseGame.Repository
{
    public static class TextFileReader
    {
        public static string Read(string filename)
        {
            var stream = new StreamReader(filename);
            return stream.ReadToEnd();
        }
    }
}
