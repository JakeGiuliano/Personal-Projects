using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Comedy
    {
        public static List<string> ComedyMovieName { get; private set; } = new List<string>()
        {
           ("Scary Movie"),
           ("Scary Movie 2"),
           ("Mrs. Doubtfire"),
           ("Big"),
           ("The Nutty Professor"),
           ("Caddyshack"),
           ("Ghostbusters"),
           ("Ace Ventura: Pet Detective"),
           ("Ace Ventura: When Nature Calls"),
           ("The Mask"),
           ("Zoolander"),
           ("Happy Gilmore"),
           ("Bill and Ted's Excellent Adventure"),
           ("Crazy Rich Asians"),
           ("Up In Smoke"),
           ("American Pie"),
           ("Legally Blonde"),
           ("Beetlejuice"),
           ("Stripes"),
           ("A League Of Their Own"),
        };

        public static List<int> ComedyMovieYear { get; private set; } = new List<int>()
        {
           (2000),
           (2001),
           (1993),
           (1988),
           (1996),
           (1980),
           (1984),
           (1994),
           (1995),
           (1994),
           (2001),
           (1996),
           (1989),
           (2018),
           (1978),
           (1999),
           (2001),
           (1988),
           (1981),
           (1992),
        };

        public static List<string> ComedyMovieDescription { get; private set; } = new List<string>()
        {
           ("A year after disposing of the body of a man they accidentally killed, a group of dumb teenagers are stalked by a bumbling serial killer."),
           ("Four teens are tricked by Professor Oldman (Tim Curry) into visiting a haunted house for a school project."),
           ("After a bitter divorce, an actor disguises himself as a female housekeeper to spend time with his children held in custody by his former wife."),
           ("After wishing to be made big, a teenage boy wakes the next morning to find himself mysteriously in the body of an adult."),
           ("Grossly overweight yet good-hearted professor Sherman Klump takes a special chemical that turns him into the slim but obnoxious Buddy Love."),
           ("An exclusive golf course has to deal with a brash new member and a destructive dancing gopher."),
           ("Three former parapsychology professors set up shop as a unique ghost removal service."),
           ("A goofy detective specializing in animals goes in search of the missing mascot of the Miami Dolphins."),
           ("Ace Ventura, Pet Detective, returns from a spiritual quest to investigate the disappearance of a rare white bat, the sacred animal of a tribe in Africa."),
           ("Bank clerk Stanley Ipkiss is transformed into a manic superhero when he wears a mysterious mask."),
           ("At the end of his career, a clueless fashion model is brainwashed to kill the Prime Minister of Malaysia."),
           ("A rejected hockey player puts his skills to the golf course to save his grandmother's house."),
           ("Two seemingly dumb teens set off on a quest to prepare the ultimate historical presentation with the help of a time machine."),
           ("This contemporary romantic comedy, based on a global bestseller, follows native New Yorker Rachel Chu to Singapore to meet her boyfriend's family."),
           ("Two stoners unknowingly smuggle a van - made entirely of marijuana - from Mexico to L.A., with incompetent Sgt. Stedenko on their trail."),
           ("Four teenage boys enter a pact to lose their virginity by prom night."),
           ("Elle Woods, a fashionable sorority queen, is dumped by her boyfriend. She decides to follow him to law school. While she is there, she figures out that there is more to her than just looks."),
           ("The spirits of a deceased couple are harassed by an unbearable family that has moved into their home, and hire a malicious spirit to drive them out."),
           ("Two friends who are dissatisfied with their jobs decide to join the army for a bit of fun."),
           ("Two sisters join the first female professional baseball league and struggle to help it succeed amidst their own growing rivalry."),
        };
        public static string comedyMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, ComedyMovieName.Count);
            return ($"Today's movie selection is: {ComedyMovieName[randInt]} \r\nIt was released in: {ComedyMovieYear[randInt]} \r\n\r\n{ComedyMovieDescription[randInt]}");
        }
    }
}
