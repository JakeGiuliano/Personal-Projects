using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Musicals
    {
        public static List<string> MusicalsMovieName { get; private set; } = new List<string>()
        {
           ("The Sound of Music"),
           ("La La Land"),
           ("Les Miserables"),
           ("Grease"),
           ("Mama Mia!"),
           ("Annie"),
           ("My Fair Lady"),
           ("Mary Poppins"),
           ("Into the Woods"),
           ("Willy Wonka & The Chocolate Factory"),
           ("Hairspray"),
           ("Sweeney Todd: The Demon Barber of the Fleet Street"),
           ("The Greatest Showman"),
           ("Bohemian Rhapsody"),
           ("Rocketman"),
           ("Enchanted"),
           ("Beauty and the Beast"),
           ("The Phantom of the Opera"),
           ("A Star is Born"),
           ("Charlie and the Chocolate Factory"),
        };

        public static List<int> MusicalsMovieYear { get; private set; } = new List<int>()
        {
           (1965),
           (2016),
           (2012),
           (1978),
           (2008),
           (1982),
           (1964),
           (1964),
           (2014),
           (1971),
           (2007),
           (2007),
           (2017),
           (2018),
           (2019),
           (2007),
           (2017),
           (2004),
           (2018),
           (2005),
        };

        public static List<string> MusicalsMovieDescription { get; private set; } = new List<string>()
        {
           ("A woman leaves an Austrian convent to become a governess to the children of a Naval officer widower."),
           ("While navigating their careers in Los Angeles, a pianist and an actress fall in love while attempting to reconcile their aspirations for the future."),
           ("In 19th-century France, Jean Valjean, who for decades has been hunted by the ruthless policeman Javert after breaking parole, agrees to care for a factory worker's daughter. The decision changes their lives forever."),
           ("Good girl Sandy Olsson and greaser Danny Zuko fell in love over the summer. When they unexpectedly discover they're now in the same high school, will they be able to rekindle their romance?"),
           ("The story of a bride-to-be trying to find her real father told using hit songs by the popular 1970s group ABBA."),
           ("A spunky young orphan is taken in by a rich eccentric, much to the chagrin of the cantankerous woman who runs the orphanage."),
           ("Snobbish phonetics Professor Henry Higgins agrees to a wager that he can make flower girl Eliza Doolittle presentable in high society."),
           ("In turn of the century London, a magical nanny employs music and adventure to help two neglected children become closer to their father."),
           ("A witch tasks a childless baker and his wife with procuring magical items from classic fairy tales to reverse the curse put on their family tree."),
           ("A poor but hopeful boy seeks one of the five coveted golden tickets that will send him on a tour of Willy Wonka's mysterious chocolate factory."),
           ("Pleasantly plump teenager Tracy Turnblad teaches 1962 Baltimore a thing or two about integration after landing a spot on a local TV dance show."),
           ("The infamous story of Benjamin Barker, aka Sweeney Todd, who sets up a barber shop in London which is the basis for a sinister partnership with his fellow tenant, Mrs. Lovett."),
           ("Celebrates the birth of show business and tells of a visionary who rose from nothing to create a spectacle that became a worldwide sensation."),
           ("The story of the legendary British rock band Queen and lead singer Freddie Mercury, leading up to their famous performance at Live Aid."),
           ("A musical fantasy about the fantastical human story of Elton John's breakthrough years."),
           ("A young maiden in a land called Andalasia, who is prepared to be wed, is sent away to New York City by an evil Queen, where she falls in love with a lawyer."),
           ("A selfish Prince is cursed to become a monster for the rest of his life, unless he learns to fall in love with a beautiful young woman he keeps prisoner."),
           ("A young soprano becomes the obsession of a disfigured and murderous musical genius who lives beneath the Paris Opéra House."),
           ("A musician helps a young singer find fame as age and alcoholism send his own career into a downward spiral."),
           ("A young boy wins a tour through the most magnificent chocolate factory in the world, led by the world's most unusual candy maker."),
        };
        public static string musicalsMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, MusicalsMovieName.Count);
            return ($"Today's movie selection is: {MusicalsMovieName[randInt]} \r\nIt was released in: {MusicalsMovieYear[randInt]} \r\n\r\n{MusicalsMovieDescription[randInt]}");
        }
    }
}