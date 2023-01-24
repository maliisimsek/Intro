using System;

namespace doWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {


            
            string[] products = new string[] { "Monster Abra A5 v19.2", "Monster Abra A7 v14.2",
                "Monster Abra A7 v14.3", "Monster Abra A5 v19.3" };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }

            Console.WriteLine("********");

            
            foreach (var product in products)
            {
                Console.WriteLine(product);
            } 

            

        }
    }
}
