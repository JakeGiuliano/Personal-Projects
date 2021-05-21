using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Action
    {
        public static List<string> ActionMovieName { get; private set; } = new List<string>()
        {
           ("First Blood"),
           ("Kill Bill: Volume 1"),
           ("The Bourne Ultimatum"),
           ("Mission: Impossible"),
           ("Mission: Impossible II"),
           ("Mission: Impossible III"),
           ("Mission: Impossible Ghost Protocol"),
           ("Mission: Impossible Rogue Nation"),
           ("Mission: Impossible Fallout"),
           ("Enter the Dragon"),
           ("IP Man"),
           ("Bullit"),
           ("Heat"),
           ("Die Hard"),
           ("Catch Me If You Can"),
           ("Bad Boys"),
           ("Big Trouble in Little China"),
           ("Con Air"),
           ("The General"),
           ("Point Break"),
        };

        public static List<int> ActionMovieYear { get; private set; } = new List<int>()
        {
           (1982),
           (2003),
           (2006),
           (1996),
           (2000),
           (2006),
           (2011),
           (2015),
           (2018),
           (1973),
           (2008),
           (1968),
           (1995),
           (1988),
           (2002),
           (1995),
           (1986),
           (1997),
           (1926),
           (1991),
        };

        public static List<string> ActionMovieDescription { get; private set; } = new List<string>()
        {
           ("Vietnam veteran and drifter John J. Rambo wanders into a small Washington town in search of an old friend, but is met with intolerance and brutality by the local sheriff, Will Teasle. When Teasle and his deputies restrain and shave Rambo, he flashes back to his time as a prisoner of war and unleashes his fury on the officers. He narrowly escapes the manhunt, but it will take his former commander to save the hunters from the hunted."),
           ("After awakening from a four-year coma, a former assassin wreaks vengeance on the team of assassins who betrayed her."),
           ("When Jason Bourne exposes and attempts to shut down Operation Blackbriar in The Bourne Ultimatum, Outcome’s supervisors pull the plug on the program, killing all of the operatives and researchers involved."),
           ("Ethan Hunt is framed for the murder of his IMF team during a botched mission in Prague and accused of selling government secrets to an arms dealer known only as Max. On the run, Ethan seeks to uncover the real traitor and clear his name."),
           ("Ethan Hunt is back in action and works with professional thief Nyah Nordoff-Hall. The duo go undercover to stop rogue IMF agent Sean Ambrose from stealing a deadly virus, starting a pandemic, and selling the antidote to the highest bidder."),
           ("Ethan Hunt assembles a team to face the elusive arms and information broker Owen Davian who intends to sell a mysterious dangerous object known as The Rabbit's Foot."),
           ("Ethan and the entire IMF are blamed for the bombing of the Kremlin while investigating an individual known only as Cobalt. He and three other agents are left to stop him from starting a global nuclear war."),
           ("Ethan Hunt comes under threat from the Syndicate. Faced with the IMF's disbandment, Hunt assembles his team for their mission to prove the Syndicate's existence and bring the organization down by any means necessary."),
           ("When an IMF mission to recover plutonium ends badly, the world is faced with the threat of the Apostles, a terrorist organization formed by former members of the Syndicate. As Ethan Hunt takes it upon himself to fulfill the original mission, the CIA begins to question his loyalty and his motives."),
           ("Bruce Lee plays a martial-arts expert determined to help capture the narcotics dealer whose gang was responsible for the death of his sister."),
           ("Ip Man and his son encounter racial discrimination after traveling to the United States to seek a better life."),
           ("When a pair of mob hitmen enter the scene, Bullitt follows their trail through a maze of complications and double-crosses."),
           ("Master criminal Neil McCauley is trying to control the rogue actions of one of his men, while also planning one last big heist before retiring."),
           ("John McClane just wants to reconnect with his estranged wife. Instead, he has to fight a bunch of terrorists."),
           ("At the age of 17, Frank Abagnale, Jr. became the most successful bank robber in the history of the U.S. FBI Agent Carl Hanratty makes it his prime mission to capture Frank and bring him to justice, but Frank is always one step ahead of him."),
           ("Two hip detectives protect a witness to a murder while investigating a case of stolen heroin from the evidence storage room from their police precinct."),
           ("A rough-and-tumble trucker helps rescue his friend's fiancée from an ancient sorcerer in a supernatural battle beneath Chinatown."),
           ("Newly paroled ex-con and former U.S. Ranger Cameron Poe finds himself trapped in a prisoner transport plane when the passengers seize control."),
           ("When Union spies steal an engineer's beloved locomotive, he pursues it single-handedly and straight through enemy lines."),
           ("An F.B.I. Agent goes undercover to catch a gang of surfers who may be bank robbers."),
        };
        public static string actionMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {ActionMovieName[randInt]} \r\nIt was released in: {ActionMovieYear[randInt]} \r\n\r\n{ActionMovieDescription[randInt]}");
        }
    }
}
