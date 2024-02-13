/*
 * Author: Logan King
 * Course: Comp003A
 * Purpous: To show that we now how to use loop statements
 */


using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Transactions;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("For-Loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("******************************************");

            
            Console.WriteLine("\n Please enter a positive whole number");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i < limit; i++) 
            {
                Console.WriteLine(output);   
                output += "#";
            }

            Console.WriteLine("******************************************");
            Console.WriteLine("ForEach section");
            Console.WriteLine("Output all of the freinds in a array");
            Console.WriteLine("******************************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach(var friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("******************************************");
            Console.WriteLine("Do-While section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("******************************************");

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            }  while (counter <= 50);

            Console.WriteLine("******************************************");
            Console.WriteLine("while section");
            Console.WriteLine("output 1-20");
            Console.WriteLine("If the Number is divisable by 2, output Foo");
            Console.WriteLine("If the Number is divisable by 5, output Bar");
            Console.WriteLine("If the Number is divisable by 2 & 5, output FooBar");
            Console.WriteLine("******************************************");

            int counter2 = 1;
            while (counter2 <= 20) 
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
            }
        }
    }
}
