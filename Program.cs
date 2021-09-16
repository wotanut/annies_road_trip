using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // print some cool text stuff

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Welcome Annie!");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("How many miles are you planning on travelling?");

            // find out how many miles annie is doing

            int miles = Convert.ToInt32(Console.ReadLine());

            // get the percentage of how many miles will be on the highway

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("And what percentage of the " + miles + " miles are you planning to do on the highway");

            int highway = Convert.ToInt32(Console.ReadLine());

            int city = 100 - highway;

            int city_fuel = city * 45;
            int highway_fuel = highway * 78;
            int total_fuel = city_fuel + highway_fuel;
            double refuels = Math.Round(total_fuel / 61.29);

            // fuel tank in gallons = 61.29


            // clears the console to make it look slightly neater
            Console.Clear();

            // prints it all out
            Console.WriteLine("You will need to refuel " + refuels + " times and will use " + total_fuel + " gallons");

        }
    }
}