using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmRocommendingSystem;
using RocommendingSystemSolution;
using Newtonsoft.Json;

namespace RecommendingSystemSolutionTests 
{
    [TestClass]
    public class RecommendingSystemSolutionTests : RecommendingSystemSolution
    {

        [TestMethod]

        public void settingNewAccount_EqualsAccs()
        {
            List<NewAccount> registeredAccountsList1 = new List<NewAccount>();
            registeredAccountsList1.Add(new NewAccount("sdcsdc", "sdcsdc", "sdcsdcsdcsdcsdc", 5));
            string serializedAccountExpected = (JsonConvert.SerializeObject(registeredAccountsList1));

            string serializedAccountActual = settingNewAccount("sdcsdc", "sdcsdc", "sdcsdcsdcsdcsdc", 5);

            Assert.AreEqual(serializedAccountExpected, serializedAccountActual);

        }

        [TestMethod]

        public void settingNewFilm_EqualsFilms()
        {
            List<NewFilm> myFilmsList = new List<NewFilm>();
            List<string> usersFilmsCollection = new List<string>();

            myFilmsList.Add(new NewFilm("sdcsdc", "sdcsdcswww", "qqqqqq"));
            string serializedMyFilms = (JsonConvert.SerializeObject(myFilmsList));

            usersFilmsCollection.Add(serializedMyFilms);
            string serializedUsersFilmsCollectionExpected = (JsonConvert.SerializeObject(usersFilmsCollection));

            string serializedUsersFilmsCollectionActual = settingNewFilm("sdcsdc", "sdcsdcswww", "qqqqqq");

            Assert.AreEqual(serializedUsersFilmsCollectionExpected, serializedUsersFilmsCollectionActual);
        }

        [TestMethod]

        public void exactTimeFilmesWatched_FilmDateBetweenSinceAndTill()
        {
            
            
            
        }


        [TestMethod]

        public void SameAudience_RigthUsers()  
        {

         }


        [TestMethod]
       
        public void myFilmsAverageRating_ReturnsRightValue() 
        {
            List<int> myFilmsRatingList = new List<int> { 2, 4, 5, 8, 6, 5 };
            double averageRatingExpected = 5.0;

            double averageRating = 0.0;

            foreach (int x in myFilmsRatingList)
            {
                averageRating += x;
            }
            double averageRatingActual = (averageRating / myFilmsRatingList.Count);
            




            Assert.AreEqual(averageRatingExpected, averageRatingActual);


        }


        [TestMethod]

        public void MyAverageExactlyGenreFilmsRating_ReturnsRightValue()
        {
            List<int> myFilmsRatingList = new List<int> { 2, 4};
            List<NewFilm> myFilmsList = new List<NewFilm> { new NewFilm("sdcsdcs", "sdcsdcaaa", "sdcaarveeeeererrww"), new NewFilm("sdcsssdcdcs", "sdcswwwdcaaa", "sdcaarveeeeererrww") };
            double expectedRating = 3.0;


            double averageGanreRating = 0.0;
            double count = 0.0;
            for (int i = 0; i < myFilmsList.Count; i++)
            {

                if (myFilmsList[i].Ganre == "sdcaarveeeeererrww")
                {
                    averageGanreRating += myFilmsRatingList[i];
                    count++;
                }
            }
            double actualRating = (averageGanreRating / count);


            Assert.AreEqual(expectedRating, actualRating);
        }

        

        

        
    }
}
