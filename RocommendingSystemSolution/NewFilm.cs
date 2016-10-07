using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocommendingSystemSolution
{
    public class NewFilm
    {
        public NewFilm(string filmName, string director, string ganre)
        {
            FilmName = filmName;
            Director = director;
            Ganre = ganre;

        }
        public string FilmName { get; private set; }
        public string Director { get; private set; }
        public string Ganre { get; private set; }

    }
}
