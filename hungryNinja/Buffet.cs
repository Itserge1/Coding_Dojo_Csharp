using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Buffet
    {
        // List<Food> Menu  = new List<Food>();
        // Definging a list | Creating an instances
        
        // The first part is declaring the list and the type of data it will hold, 
        // and the second part is acctualy creating the list(Instance).
        
        // Declaring a list just like a variable.
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            // ============ First way ============
            
            // Creating food instances
            Food pasta = new Food("pasta", 100, true, true);
            Food rice = new Food("rice", 300, false, false);
            Food yams = new Food("yams", 500, false, true);
            Food puding = new Food("puding", 700, true, true);
            Food seaFruits = new Food("sea fruits", 1000, true, false);

            // Creating a Menu list instances
            Menu = new List<Food>();
            
            // Adding food to the list created above
            Menu.Add(pasta);
            Menu.Add(rice);
            Menu.Add(yams);
            Menu.Add(puding);
            Menu.Add(seaFruits);

            // ============ Second way ============
            // Menu = new List<Food>();
            // {
            //     new Food("rice", 500, false, false),
            //     new Food("yams", 700, false, true),
            //     new Food("puding", 700, true, true),
            //     new Food("salade", 200, false, true),
            //     new Food("sea fruits", 1000, true, false),
            // };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}