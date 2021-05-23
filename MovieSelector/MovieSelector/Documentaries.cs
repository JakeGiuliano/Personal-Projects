using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Documentaries
    {
        public static List<string> DocumentariesMovieName { get; private set; } = new List<string>()
        {
           ("Won't You Be My Neighbor?"),
           ("The Salt of the Earth"),
           ("The Cove"),
           ("The Fog of War: Eleven Lessons from the Life of Robert S. McNamara"),
           ("Citizenfour"),
           ("Brother's Keeper"),
           ("The Decline of Western Civilization"),
           ("No End in Sight"),
           ("They Shall Not Grow Old"),
           ("I am Not Your Negro"),
           ("Woodstock"),
           ("Shoah"),
           ("A Plastic Ocean"),
        };

        public static List<int> DocumentariesMovieYear { get; private set; } = new List<int>()
        {
           (2018),
           (2014),
           (2009),
           (2003),
           (2014),
           (1992),
           (1981),
           (2007),
           (2018),
           (2016),
           (1970),
           (1985),
           (2016),
        };

        public static List<string> DocumentariesMovieDescription { get; private set; } = new List<string>()
        {
           ("An exploration of the life, lessons, and legacy of iconic children's television host, Fred Rogers."),
           ("Photographer Sebastião Salgado spent 40 years capturing the beautiful-if-often devastating wonders of the world; this documentary captures his life and work."),
           ("Activists, including renowned dolphin trainer Ric O'Barry, expose animal abuse at a cove near Taiji, Japan in this shocking documentary."),
           ("The Fog of War looks at the life of former U.S. Defense Secretary Robert S. McNamara and inspects his observations about modern warfare."),
           ("Citizenfour takes an up-close look at the whistleblower scandal surrounding Edward Snowden’s release of classified documents."),
           ("Brother's Keeper follows the death of one brother in an upstate New York family that is later pinned on his older brother."),
           ("The Decline of Western Civilization looks at the punk rock scene in Los Angeles in the late 1970s."),
           ("No End in Sight looks at the two years following the American invasion of Iraq in 2003."),
           ("Using state-of-the-art technology, They Shall Not Grow Old tells the story of World War I through the men who fought in it."),
           ("I Am Not Your Negro is an imagined version of a book James Baldwin never finished. It was lauded for its imagination combined with Baldwin’s voice recordings and notes on his unfinished work."),
           ("This portrait of the hippie counterculture of the late 1960s and early 1970s has reached cult classic status. It captured the epic three-day rock and roll concert that featured diverse performers including folk singing legend Joan Baez, British rock band The Who, and guitar god Jimi Hendrix."),
           ("Claude Lanzmann's epic documentary recounts the story of the Holocaust through interviews with witnesses - perpetrators as well as survivors."),
           ("Journalist Craig Leeson teams up with diver Tanya Streeter and an international team of scientists and researchers, and they travel to twenty locations around the world over the next four years to explore the fragile state of our oceans."),
        };
        public static string documentariesMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, DocumentariesMovieName.Count);
            return ($"Today's movie selection is: {DocumentariesMovieName[randInt]} \r\nIt was released in: {DocumentariesMovieYear[randInt]} \r\n\r\n{DocumentariesMovieDescription[randInt]}");
        }
    }
}