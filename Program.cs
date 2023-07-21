using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    

    class Program
    {
        static void Main()
        {

            using (LargeDataCollection collection = new LargeDataCollection(new List<object> { 1, "Hello", DateTime.Now }))
            {
                collection.Add(42);
                collection.Add("World");
                collection.Remove("Hello");


                Console.WriteLine(collection.Get(0));
                Console.WriteLine(collection.Get(1));
                Console.WriteLine(collection.Get(2));
                Console.WriteLine(collection.Get(3));
                Console.Read();
            }
        }
    }

}
