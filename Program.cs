using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Saturn");
            planetList.Add("Juipter");


            List<string> lastTwo = new List<string>(){
                "Neptune", "Uranus"
            };

            planetList.AddRange(lastTwo);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            planetList.Remove("Pluto");

       
            List<string> rockeyPlanets = planetList.GetRange(0, 4);
            
            foreach(string p in rockeyPlanets){
                Console.WriteLine(p);
            }
        }
    }
}
