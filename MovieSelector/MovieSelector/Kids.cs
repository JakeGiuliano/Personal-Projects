using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class Kids
    {
        public static List<string> KidsMovieName { get; private set; } = new List<string>()
        {
           ("Animal Crackers"),
           ("Son of Bigfoot"),
           ("Shrek"),
           ("The Lion King"),
           ("The Lion King 1 1/2"),
           ("Toy Story"),
           ("Toy Story 2"),
           ("Toy Story 3"),
           ("Toy Story 4"),
           ("Frozen"),
           ("Frozen II"),
           ("Finding Nemo"),
           ("Finding Dory"),
           ("Ratatouille"),
           ("The Wizard of Oz"),
           ("Inside Out"),
           ("Despicable Me"),
           ("Despicable Me 2"),
           ("Despicable Me 3"),
           ("Coco"),
        };

        public static List<int> KidsMovieYear { get; private set; } = new List<int>()
        {
           (2017),
           (2017),
           (2001),
           (1994),
           (2004),
           (1995),
           (1999),
           (2010),
           (2019),
           (2013),
           (2019),
           (2003),
           (2016),
           (2007),
           (1939),
           (2015),
           (2010),
           (2013),
           (2017),
           (2017),
        };

        public static List<string> KidsMovieDescription { get; private set; } = new List<string>()
        {
           ("A family must use a magical box of Animal Crackers to save a run-down circus from being taken over by their evil uncle Horatio P. Huntington."),
           ("A young teenage boy sets out to find his missing father, only to discover that he's actually the mythical creature known as Bigfoot."),
           ("A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back."),
           ("Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself."),
           ("Timon the meerkat and Pumbaa the warthog retell the story of The Lion King (1994) from their own perspective."),
           ("A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room."),
           ("When Woody is stolen by a toy collector, Buzz and his friends set out on a rescue mission to save Woody before he becomes a museum toy property with his roundup gang Jessie, Prospector, and Bullseye."),
           ("The toys are mistakenly delivered to a day-care center instead of the attic right before Andy leaves for college, and it's up to Woody to convince the other toys that they weren't abandoned and to return home."),
           ("When a new toy called Forky joins Woody and the gang, a road trip alongside old and new friends reveals how big the world can be for a toy."),
           ("When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition."),
           ("Anna, Elsa, Kristoff, Olaf and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom."),
           ("After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home."),
           ("Friendly but forgetful blue tang Dory begins a search for her long-lost parents, and everyone learns a few things about the real meaning of family along the way."),
           ("A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant."),
           ("Dorothy Gale is swept away from a farm in Kansas to a magical land of Oz in a tornado and embarks on a quest with her new friends to see the Wizard who can help her return home to Kansas and help her friends as well."),
           ("After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school."),
           ("When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better."),
           ("When Gru, the world's most super-bad turned super-dad has been recruited by a team of officials to stop lethal muscle and a host of Gru's own, He has to fight back with new gadgetry, cars, and more minion madness."),
           ("Gru meets his long-lost, charming, cheerful, and more successful twin brother Dru, who wants to team up with him for one last criminal heist."),
           ("Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer."),
        };
        public static string kidsMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, KidsMovieName.Count);
            return ($"Today's movie selection is: {KidsMovieName[randInt]} \r\nIt was released in: {KidsMovieYear[randInt]} \r\n\r\n{KidsMovieDescription[randInt]}");
        }
    }
}
