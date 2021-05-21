using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Horror
    {
        public static List<string> HorrorMovieName { get; private set; } = new List<string>()
        {
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
        };

        public static List<int> HorrorMovieYear { get; private set; } = new List<int>()
        {
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
           (1),
        };

        public static List<string> HorrorMovieDescription { get; private set; } = new List<string>()
        {
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
           (""),
        };
        public static string horrorMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {HorrorMovieName[randInt]} \r\nIt was released in: {HorrorMovieYear[randInt]} \r\n\r\n{HorrorMovieDescription[randInt]}");
        }
    }
}
