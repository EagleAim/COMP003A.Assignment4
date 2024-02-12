/*
 * Author: Logan King
 * Course: Comp003A
 * Purpous: To show that we now how to use loop statements
 */


using System.Reflection.Metadata;

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

        }
    }
}
