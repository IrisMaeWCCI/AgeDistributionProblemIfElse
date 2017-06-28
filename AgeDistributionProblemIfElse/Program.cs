using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistributionProblemIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0)
            {
                Console.WriteLine("Still in mama's arms");
            }
            else if (age >= 3)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (age >= 66)
            {
                Console.WriteLine("The Golden Years");
            }
            else if (0 =< age)
            {
                Console.WriteLine("This program is for humans!");
            }
            else (age=<101)
            {
                Console.WriteLine("This program is for humans!");

            }
        }
    }
}
