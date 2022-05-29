using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> videoGames = new List<string>() {"Animal Crossing", "Halo", "Elden Ring"};

            var games = videoGames.OrderBy(x => x.Length);

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
