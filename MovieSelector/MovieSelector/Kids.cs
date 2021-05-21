using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Kids
    {
        public static List<string> KidsMovieName { get; private set; } = new List<string>()
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

        public static List<int> KidsMovieYear { get; private set; } = new List<int>()
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

        public static List<string> KidsMovieDescription { get; private set; } = new List<string>()
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
        public static string kidsMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {KidsMovieName[randInt]} \r\nIt was released in: {KidsMovieYear[randInt]} \r\n\r\n{KidsMovieDescription[randInt]}");
        }
    }
}
