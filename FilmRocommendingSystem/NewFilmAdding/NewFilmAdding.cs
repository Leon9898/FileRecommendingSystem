using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FilmRocommendingSystem
{
    public class NewFilmAdding
    {
        public NewFilmAdding(string filmName, string director, string ganre)
        {
            FilmName = filmName;
            Director = director;
            Ganre = ganre;

        }
        public string FilmName { get; private set; }
        public string Director { get; private set; }
        public string Ganre { get; private set; }

        public List<NewFilmAdding> myFilmList = new List<NewFilmAdding>();
        public List<string> userFilmsCollection = new List<string>();
        public void setList()
        {

            myFilmList.Add(new NewFilmAdding(FilmName, Director, Ganre));
            string serializedFims = (JsonConvert.SerializeObject(myFilmList));
            userFilmsCollection.Add(serializedFims);

        }
    }
}
