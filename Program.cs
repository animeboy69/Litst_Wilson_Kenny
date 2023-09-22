using System;
using System.Collections.Generic;

namespace Litst_Wilson_Kenny
{
    internal class Program
    {
        /// <summary>
        ///  Main method, Creates a string list called games 
        /// </summary>
        /// <param name="args"><string lists /param>
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "MineCaft",
                "Halo 3",
                "Boderlands 2",
                "Fifa 23",
                "Apex",



            };
            /// Creates a string called otherGames
            string[] otherGames = new string[]
            {
                "Halo 2",
                "Farcry 6",
            };

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($" \nGames in list:{games.Count}");


            games.AddRange(otherGames);
            /// Creates a Game list and counts the games.
           Console.WriteLine($"\nGames in list: {games.Count}");
            
            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!!");
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if (myInt < games.Count)
            {

                games.RemoveAt(myInt);

            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();
            /// Snorted games in the list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            /// String called New list
            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}