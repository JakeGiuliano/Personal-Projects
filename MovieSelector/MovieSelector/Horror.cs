using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Horror
    {
        public static List<string> HorrorMovieName { get; private set; } = new List<string>()
        {
           ("Saw"),
           ("The Birds"),
           ("Dawn of the Dead"),
           ("A Nightmare on Elm Street"),
           ("The Babadook"),
           ("The Cabin in the Woods"),
           ("A Quiet Place"),
           ("Paranormal Activity"),
           ("Suspiria"),
           ("The Descent"),
           ("Rec"),
           ("The Blair Witch Project"),
           ("The Witch"),
           ("The Wicker Man"),
           ("Get Out"),
           ("Scream"),
           ("Alien"),
           ("Jaws"),
           ("The Exorcist"),
           ("The Texas Chain Saw Massacre"),
        };

        public static List<int> HorrorMovieYear { get; private set; } = new List<int>()
        {
           (2004),
           (1963),
           (1978),
           (1984),
           (2014),
           (2011),
           (2018),
           (2007),
           (1977),
           (2005),
           (2007),
           (1999),
           (2015),
           (1973),
           (2017),
           (1996),
           (1979),
           (1975),
           (1973),
           (1974),
        };

        public static List<string> HorrorMovieDescription { get; private set; } = new List<string>()
        {
           ("Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer."),
           ("A wealthy San Francisco socialite pursues a potential boyfriend to a small Northern California town that slowly takes a turn for the bizarre when birds of all kinds suddenly begin to attack people."),
           ("A nurse, a policeman, a young married couple, a salesman and other survivors of a worldwide plague that is producing aggressive, flesh-eating zombies, take refuge in a mega Midwestern shopping mall."),
           ("The monstrous spirit of a slain child murderer seeks revenge by invading the dreams of teenagers whose parents were responsible for his untimely death."),
           ("A single mother and her child fall into a deep well of paranoia when an eerie children's book titled Mister Babadook manifests in their home."),
           ("Five friends go for a break at a remote cabin, where they get more than they bargained for, discovering the truth behind the cabin in the woods."),
           ("In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing."),
           ("After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence."),
           ("A darkness swirls at the center of a world-renowned dance company, one that will engulf the artistic director, an ambitious young dancer, and a grieving psychotherapist. Some will succumb to the nightmare. Others will finally wake up."),
           ("A caving expedition goes horribly wrong, as the explorers become trapped and ultimately pursued by a strange breed of predators."),
           ("A television reporter and cameraman follow emergency workers into a dark apartment building and are quickly locked inside with something terrifying."),
           ("Three film students vanish after traveling into a Maryland forest to film a documentary on the local Blair Witch legend, leaving only their footage behind."),
           ("A family in 1630s New England is torn apart by the forces of witchcraft, black magic, and possession."),
           ("A puritan Police Sergeant arrives in a Scottish island village in search of a missing girl who the locals claim never existed."),
           ("A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point."),
           ("A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by using horror films as part of a deadly game."),
           ("After a space merchant vessel receives an unknown transmission as a distress call, one of the crew is attacked by a mysterious life form and they soon realize that its life cycle has merely begun."),
           ("When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down."),
           ("When a 12-year-old girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her."),
           ("Two siblings and three of their friends en route to visit their grandfather's grave in Texas fall victim to a family of cannibalistic psychopaths."),
        };
        public static string horrorMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, HorrorMovieName.Count);
            return ($"Today's movie selection is: {HorrorMovieName[randInt]} \r\nIt was released in: {HorrorMovieYear[randInt]} \r\n\r\n{HorrorMovieDescription[randInt]}");
        }
    }
}
