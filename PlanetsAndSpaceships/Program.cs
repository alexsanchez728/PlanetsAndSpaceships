using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //1. `Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            //2.Create another `List` that contains that last two planet of our solar system.
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            //3.Combine the two lists by using `AddRange()`.
            planetList.AddRange(lastPlanets);
            //4.Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            //5.Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            //6.Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            List<string> rockyPlanets = new List<string>() {  };
            rockyPlanets.AddRange(planetList.GetRange(0, 4));
            //7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");

            foreach (var planet in planetList)
            {
                Console.Write("A planet: ");
                Console.WriteLine(planet);
            }

            foreach (var rockBall in rockyPlanets)
            {
                Console.Write("A rock planet: ");
                Console.WriteLine(rockBall);
            }


            //1.Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.

            var planetsAndProbes = new List<Dictionary<string, string>>
            {
                { new Dictionary<string, string> { { "Mercury", "Messenger" } } },
                { new Dictionary<string, string> { { "Mars", "Viking, Opportunity, Curiosity" } } },
                { new Dictionary<string, string> { { "Jupiter", "Galileo Orbiter, Pioneer 1" } } },
                { new Dictionary<string, string> { { "Saturn", "Voyager 1" } } },
                { new Dictionary<string, string> { { "Venus", "Mariner, Venera" } } },
                { new Dictionary<string, string> { { "Uranus", "Voyager 12" } } }
            };
                
            //2.Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries.Write to the console, for each planet, which satellites have visited which planet.
            foreach (var planet in planetList)
            {
                foreach (var probe in planetsAndProbes)
                {
                    foreach (var item in probe)
                    {

                        if (planet == item.Key)
                        {
                            Console.WriteLine($"{planet}: {item.Value}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
