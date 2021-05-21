using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSelector
{
    class SciFi
    {
        public static List<string> SciFiMovieName { get; private set; } = new List<string>()
        {
           ("Star Wars: Episode I - The Phantom Menace"),
           ("Star Wars: Episode II - Attack of the Clones"),
           ("Star Wars: Episode III - Revenge of the Sith"),
           ("Star Wars: Episode IV - A New Hope"),
           ("Star Wars: Episode V - The Empire Strikes Back"),
           ("Star Wars: Episode VI - Return of the Jedi"),
           ("Star Wars: The Force Awakens"),
           ("Star Wars: The Last Jedi"),
           ("Star Wars: The Rise of Skywalker"),
           ("Rogue One: A Star Wars Story"),
           ("Solo: A Star Wars Story"),
           ("Lord of the Rings: The Fellowship of the Ring"),
           ("Lord of the Rings: The Two Towers"),
           ("Lord of the Rings: The Return of the King"),
           ("The Hobbit: An Unexpected Journey"),
           ("The Hobbit: The Desolation of Smaug"),
           ("The Hobbit: The Battle of the Five Armies"),
           ("Back to the Future"),
           ("Back to the Future Part II"),
           ("Back to the Future Part III"),
        };

        public static List<int> DocumentariesMovieYear { get; private set; } = new List<int>()
        {
           (1999),
           (2002),
           (2005),
           (1977),
           (1980),
           (1983),
           (2015),
           (2017),
           (2019),
           (2016),
           (2018),
           (2001),
           (2002),
           (2003),
           (2012),
           (2013),
           (2014),
           (1985),
           (1989),
           (1990),
        };

        public static List<string> SciFiMovieDescription { get; private set; } = new List<string>()
        {
           ("An ancient evel return seeking revenge on the Jedi. A boy who is unusually strong with the Force has been found by Jedi Knight Qui-Gon Jinn."),
           ("Following the assassination attempt on Senator Amidala, Anakin and Obi-Won investigate a murderous plot that could send the galaxy into spiral."),
           ("The evil Darth Sidious is revealed and enacts his final plans to capture the galaxy under Imperial rule."),
           ("With the planet destroying power of the Death Star, the Empire plans to rule the galaxy. Meanwhile, a farm boy Luke Skywalker rises to face his destiny"),
           ("While the Death Star has been destroyed, the battle between the Empire and Rebellion still rages on."),
           ("Luke Skywalker goes on a mission to rescue his friend Han Solo from Jabba the Hutt, all while the Empire looks to cement its grip on the galaxy"),
           ("Thirty years after the death of the Empire a new threat emerges known as the First Order. Along with this new threat a new hope emerges in the form of a young scavenger, Rey."),
           ("Rey has now found Luke Skywalker hoping to be trained. Meanwhile, the First Order seeks to destroy whats left of the Resistance."),
           ("A powerful enemy emerges and Rey must face her Destiny in this thrilling final installment."),
           ("A group of Rebel heroes concocts a daring plan to steal the plans to the Death Star from the Empire."),
           ("Follow a young Han Solo in his tribulations growing up as a criminal scoundrel."),
           ("A dark and mysterious evil is looming about Middle Earth. Can the Men and the Elves form an alliance to stop it in time?"),
           ("Frodo and Sam continue thier journey to destroy the One Ring. The Men and the Elves take a stand against Saurons army."),
           ("In a final stand can the armies of Men and the Elves put an end to Sauron's darkness?"),
           ("Bilbo Baggins sets out on a journey with a sprightly group of dwarves to retake thier home from Smaug"),
           ("The dwarves, along with Bilbo and Gandalf, continue thier quest to reclaim thier homeland from Smaug. Along the way Bilbo finds a mysterious ring."),
           ("A final battle commences to keep the Lonely Mountain in dwarven hands."),
           ("17 year old Marty McFly is sent back to the year 1985 where he runs into trouble which changes his future. Can he fix the changes he made in time?"),
           ("In this sequal Marty McFly is sent to the far off year of 2015 where he sees his family in ruin. Can he avoid this dreadful future?"),
           ("In the final installment of this trilogy Doc Brown is stuck in 1885 in a precarious situation. Can Marty find a way to save Doc before time runs out?"),
        };
        public static string scifiMovie()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 19);
            return ($"Today's movie selection is: {SciFiMovieName[randInt]} \r\nIt was released in: {DocumentariesMovieYear[randInt]} \r\n\r\n{SciFiMovieDescription[randInt]}");
        }
    }
}
