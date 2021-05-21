using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Musicals
    {
        public static List<string> MusicalsMovieName { get; private set; } = new List<string>()
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

        public static List<int> MusicalsMovieYear { get; private set; } = new List<int>()
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

        public static List<string> MusicalsMovieDescription { get; private set; } = new List<string>()
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
        public static string musicalsMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {MusicalsMovieName[randInt]} \r\nIt was released in: {MusicalsMovieYear[randInt]} \r\n\r\n{MusicalsMovieDescription[randInt]}");
        }
    }
}