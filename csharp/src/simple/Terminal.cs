using System;
using Language.Interfaces;

namespace Simple
{
    class Terminal: IExample
    {
        public static void Run()
        {

            //Print To Console Line
            Console.WriteLine("Hello All Worlds!");

            //Console Write
            Console.WriteLine("Hello World!");
            Console.WriteLine("Yello");
            Console.WriteLine("Planetoid!");

            //Pause Console Message
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            //Variable Declaration And Read From Console
            Console.WriteLine("Please enter your name...");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            //String Interpolation And Variable Binding
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
        }
    }
}