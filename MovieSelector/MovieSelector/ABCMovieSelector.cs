using System;
using System.Collections.Generic;



namespace MovieSelector
{
    class ABCMovieSelector
    {
        static void Main(string[] args)
        {

            Console.Write("Please choose one of the following movie genres: \r\nSciFi, Horror, Comedy, Action, Kids, Documentaries, Musical \r\nIf you want a random genre please input Random: ");
            string userInputGenre = Console.ReadLine();
            Console.WriteLine();

            List<string> MovieGenresReturn = new List<string>();
            MovieGenresReturn.Add(SciFi.scifiMovie());
            MovieGenresReturn.Add(Horror.horrorMovie());
            MovieGenresReturn.Add(Comedy.comedyMovie());
            MovieGenresReturn.Add(Action.actionMovie());
            MovieGenresReturn.Add(Kids.kidsMovie());
            MovieGenresReturn.Add(Documentaries.documentariesMovie());
            MovieGenresReturn.Add(Musicals.musicalsMovie());

            List<string> MovieGenres = new List<string>();
            MovieGenres.Add("SciFi");
            MovieGenres.Add("Horror");
            MovieGenres.Add("Comedy");
            MovieGenres.Add("Action");
            MovieGenres.Add("Kids");
            MovieGenres.Add("Documentaries");
            MovieGenres.Add("Musical");

            Random random = new Random();
            int randomInt = random.Next(0, 6);

            Dictionary<string, string> RandomMovieSelectorDictionary = new Dictionary<string, string>();
            RandomMovieSelectorDictionary["scifi"] = SciFi.scifiMovie();
            RandomMovieSelectorDictionary["horror"] = Horror.horrorMovie();
            RandomMovieSelectorDictionary["comedy"] = Comedy.comedyMovie();
            RandomMovieSelectorDictionary["action"] = Action.actionMovie();
            RandomMovieSelectorDictionary["kids"] = Kids.kidsMovie();
            RandomMovieSelectorDictionary["documentaries"] = Documentaries.documentariesMovie();
            RandomMovieSelectorDictionary["musical"] = Musicals.musicalsMovie();
            RandomMovieSelectorDictionary["random"] = ($"The random genre is: {MovieGenres[randomInt]} \r\n{MovieGenresReturn[randomInt]}");

            Console.WriteLine(RandomMovieSelectorDictionary[userInputGenre.ToLower()]);


            Console.ReadLine();
        }
    }
}
