using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Student ID: 300921431
 Student Name: Mikang Kim 
 This is Main method of my driver class
     */

namespace COMP123_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet;
            Console.WriteLine();

            TerrestrialPlanet TerrestrialPlanet = new TerrestrialPlanet;
            Console.WriteLine();

            WaitForAnyKey();
        }


        private static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}

