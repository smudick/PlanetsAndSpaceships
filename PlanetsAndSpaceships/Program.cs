using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetList2 = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(planetList2);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");
            Console.WriteLine("Planets\n--------------");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine("\nRocky Planets\n-------------");
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            var spacecraft = new Dictionary<string, List<string>>
            {
                {"Viking", new List<string> {"Mars", "Venus" } },
                {"Curiosity", new List<string> {"Saturn", "Neptune", "Uranus" } },
                {"Opportunity", new List<string> {"Jupiter", "Mars" } },
                {"Venera", new List<string> {"Mercury", "Venus" } },
                {"Mariner", new List<string> {"Mars", "Venus" } },
                {"Explorer", new List<string> {"Jupiter", "Neptune" } },
                {"Tesla Roadster", new List<string> {"Earth" } },
            };

            Console.WriteLine("\nIterating Over Planets\n----------------------");
            foreach (var planet in planetList)
            {
                var satellites = new List<string>();
                foreach (var (satellite, visitedPlanet) in spacecraft)
                {
                    if (visitedPlanet.Contains(planet))
                    {
                        satellites.Add(satellite);
                    }
                }
                var satelliteStrings = string.Join(", ", satellites);
                Console.WriteLine($"{planet}: {satelliteStrings}");

            }
        }
    }
}
