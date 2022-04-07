using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Food> bikes = new List<Food>();
            // Food pasta = new Food("pastas", 100, true, true);
            // Food rice = new Food("rice", 300, false, false);
            // Food yams = new Food("pastas", 500, false, true);
            // //Use the Add function in a similar fashion to push
            // bikes.Add(pasta);
            // bikes.Add(rice);
            // bikes.Add(yams);
            Buffet buffer = new Buffet();
            // buffer.Serve(); // will return a food
            Ninja Serge = new Ninja();
            Console.WriteLine(Serge.Eat(buffer.Serve()));
            Console.WriteLine(Serge.Eat(buffer.Serve()));
            Console.WriteLine(Serge.Eat(buffer.Serve()));
            Console.WriteLine(Serge.Eat(buffer.Serve()));
            Console.WriteLine(Serge.Eat(buffer.Serve()));
        }
    }
}
