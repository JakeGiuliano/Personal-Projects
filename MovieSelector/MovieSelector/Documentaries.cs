using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Documentaries
    {
        public static List<string> DocumentariesMovieName { get; private set; } = new List<string>()
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

        public static List<int> DocumentariesMovieYear { get; private set; } = new List<int>()
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

        public static List<string> DocumentariesMovieDescription { get; private set; } = new List<string>()
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
        public static string documentariesMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {DocumentariesMovieName[randInt]} \r\nIt was released in: {DocumentariesMovieYear[randInt]} \r\n\r\n{DocumentariesMovieDescription[randInt]}");
        }
    }
}