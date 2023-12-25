using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var music = new Music();
            music.Name = "Ripple";
            music.Artist = "Grateful Dead"
            music.ReleaseDate = new DateTime(11, 1, 1970);
        }
    }
}
