using System;
using System.Diagnostics;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "boderlands 3",
                "Fifa 22",
                "Minecraft",
            };

            string[] otherGames = new string[];
            {
                "Tiny Tina's Wonderlands",
                "Farcay 3",

            };

            foreach (string game in games)
            {
                Console.WriteLine(game.Count);


            }

            Console.WriteLine($"Games in list: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"Games in list: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nhi hello i am Master Chief!");
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
                Console.WriteLine("Game not found!");
            }

            Console.WriteLine("All games in the lists");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            games.Sort();

            Console.WriteLine("Sorted games list");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            foreach (string game in games)
            {
                Console.WriteLine("\nNew List");
                foreach (string game in newList)
                {
                    Console.WriteLine(game);
                }

            }



        }
    }
}