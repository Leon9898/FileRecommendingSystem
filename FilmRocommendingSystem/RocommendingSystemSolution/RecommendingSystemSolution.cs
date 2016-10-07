using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocommendingSystemSolution;
using Newtonsoft.Json;

namespace FilmRocommendingSystem
{
    public class RecommendingSystemSolution 
    {
        public List<NewAccount> registeredAccountsList = new List<NewAccount>();

        public List<NewFilm> myFilmsList = new List<NewFilm>();

        public List<string> usersFilmsCollection = new List<string>();

        public List<int> myFilmsRatingList = new List<int>();

        public List<DateTime> filmsLastWatchTime = new List<DateTime>();


        




        public string settingNewAccount(string Email, string FirstName, string LastName, int Identificator) // Tested
        {
            registeredAccountsList.Add(new NewAccount(Email, FirstName, LastName, Identificator));
            string serializedAccount = (JsonConvert.SerializeObject(registeredAccountsList));
            return serializedAccount;
            
        }

        public string settingNewFilm(string FilmName, string Director, string Ganre)   
        {
            myFilmsList.Add(new NewFilm(FilmName, Director, Ganre));
            string serializedMyFilms = (JsonConvert.SerializeObject(myFilmsList));

            usersFilmsCollection.Add(serializedMyFilms);
            string serializedUsersFilmsCollection = (JsonConvert.SerializeObject(usersFilmsCollection));   //Tested

            return serializedUsersFilmsCollection;
        }

        public NewAccount[] SameAudience()        // not tested
        {    
            List<NewAccount> sameAudienceList = new List<NewAccount>;
            string serializedMyFilms = (JsonConvert.SerializeObject(myFilmsList));
            for(int i = 0; i < usersFilmsCollection.Count; i++)
            {
                if(usersFilmsCollection[i] == serializedMyFilms) sameAudienceList.Add(registeredAccountsList[i]);
            }

            NewAccount[] sameAudienceArray = new NewAccount[sameAudienceList.Count];
            for(int i = 0; i < sameAudienceList.Count; i++)
            {
                sameAudienceArray[i] = sameAudienceList[i];
            }

            return sameAudienceArray;

        }

        public void settingMyFilmsRating(int[] rating)
        {
            
            for (int i = 0; i < myFilmsList.Count; i++) myFilmsRatingList.Add(rating[i]);
            
        }



        

        public double myFilmsAverageRating()   // Tested
        {
            double averageRating = 0.0;
            
           foreach(int x in myFilmsRatingList)
            {
                averageRating += x;
            }
           return (averageRating / myFilmsRatingList.Count);
        }



        public double MyAverageExactlyGenreFilmsRating(string filmGanre) // Tested
        {
            double averageGanreRating = 0.0;
            double count = 0.0;
            for (int i = 0; i < myFilmsList.Count; i++)
            {

                if (myFilmsList[i].Ganre == filmGanre)
                {
                    averageGanreRating += myFilmsRatingList[i];
                    count++;
                }
            }
            return (averageGanreRating / count);
        }

        public void settingFilmsDate(DateTime filmDate)
        {
            for (int i = 0; i < myFilmsList.Count; i++) filmsLastWatchTime.Add(filmDate);
        }

        public NewFilm[] exactTimeFilmesWatched(DateTime sinceDate, DateTime tillDate) // not tested
        {
            List<NewFilm> exactTimeFilmsList = new List<NewFilm>();
            
            for (int i = 0; i < filmsLastWatchTime.Count; i++)
            {
                if ((filmsLastWatchTime[i].CompareTo(sinceDate) >= 0) && (filmsLastWatchTime[i].CompareTo(tillDate) <= 0))
                {
                    exactTimeFilmsList.Add(myFilmsList[i]);

                }
                
                
                   
                
            }

            NewFilm[] exactTimeFilmsArray = new NewFilm[exactTimeFilmsList.Count];
            for (int i = 0; i < exactTimeFilmsList.Count; i++)
            {
                exactTimeFilmsArray[i] = exactTimeFilmsList[i];
            }

            return exactTimeFilmsArray;
            
        }


        




    }
}
