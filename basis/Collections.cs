
using System;
using System.Collections.Generic;

namespace Basis
{
   class CollectionsSample 
   {
        public void Run()
        {
            List();
        }

        private void List()
        {
            // foreach
            var names = new List<string> {"name", "Ana", "Felipe"};
            foreach(var name in names)
            {
                //Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // add, remove
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // index
            Console.WriteLine($"name is {names[0]}");

            // count
            Console.WriteLine($"name is {names.Count}");

            // find index
            var index = names.IndexOf("Felipe");
            if ( index != -1 )
                Console.WriteLine($"name {names[index]} is at index{index}");

            var notFound = names.IndexOf("not");
                Console.WriteLine($"name not , returuns is {notFound}");

            // sort
            Console.WriteLine("sort list");
            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }
    }
}
