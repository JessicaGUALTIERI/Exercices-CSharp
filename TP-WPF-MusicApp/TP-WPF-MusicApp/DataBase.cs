using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WPF_MusicApp
{
    internal class DataBase
    {
        public static List<Music> Musics { get; set; }

        public static void Initialize()
        {
            Musics = new List<Music> {
                new Music("Edith WHISKERS", "Home", "Folk", 3, 1802),
                new Music("Kesha", "Tik Tok", "Pop", 3, 190000),
                new Music("Britney SPEARS", "Gimme More", "Pop", 4, 200000),
                new Music("Orelsan", "Notes pour trop tard", "Rap", 7, 1802000)
            };
        }
    }
}
