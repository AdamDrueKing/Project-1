using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 formatting. Setting up asking user questions to get information for subsequent sections.

            Console.WriteLine("User, please enter your first name.");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("User, please enter your last name.");
            string userLastName = Console.ReadLine();

            Console.WriteLine("User, please enter your age as a whole number.");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("User, please enter your birth month as the corresponding digit. ex; January=1; May=5; October=10");
            int userBirthMonth = int.Parse(Console.ReadLine());

            //Trying to get a "Help" response to be accepted, regardless of case. THANKS, PETE!!!
           
            Console.WriteLine("User, what is your favorite ROYGBIV color? If you don't know what ROYGBIV is, please type \"Help\"");
            string userFavoriteColor = Console.ReadLine();
            string helpLower = userFavoriteColor.ToLower();

            if (helpLower == "help")
            {
                Console.WriteLine("Royal");
                Console.WriteLine("Orange");
                Console.WriteLine("Yellow");
                Console.WriteLine("Green");
                Console.WriteLine("Blue");
                Console.WriteLine("Indigo");
                Console.WriteLine("Violet");
            }

            else
            {
                Console.WriteLine("Proceed to the next question.");
            }

            Console.WriteLine("User, please enter how many siblings you have as a digit.");
            int userSiblings = int.Parse(Console.ReadLine());

        }
    }
}
