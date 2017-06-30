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

            Console.WriteLine("User, please enter your birth month as the corresponding digit. ex; january=1; may=5; october=10");
            int userBirthMonth = int.Parse(Console.ReadLine());

            //trying to get a "help" response to be accepted, regardless of case. thanks, pete!!!

            Console.WriteLine("User, what is your favorite ROYGBIV color? If you don't know what ROYGBIV is, please type \"help\"");
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
                Console.WriteLine("Thanks for your answer! Proceed to the next question.");
            }

            Console.WriteLine("User, please enter how many siblings you have as a digit.");
            int userSiblings = int.Parse(Console.ReadLine());



            //Part 2 Formatting. Taking user information from Part 1 to complete the following:

            if (userAge % 2 == 0) 

            {
                string userRetiresIn = "30 years";
            }
            else
            {
                string userRetiresIn = "31 years";
            }

            //siblings functions
            if (userSiblings == 0)
            {
                string userVacationHome = "Geneva-On-The-Lake";
            }

            else if (userSiblings == 1)
            {
                string userVacationHome = "Nantucket";
            }

            else if (userSiblings == 2)
            {
                string userVacationHome = "Outer Banks";
            }

            else if (userSiblings == 3)
            {
                string userVacationHome = "Costa Rica";
            }

            else if (userSiblings > 3)
            {
                string userVacationHome = "Orlando";
            }

            else
            {
                string userVacationHome = "Skid Row";
            }


            if (userFavoriteColor == "Royal")
            {
                string userTransportation = "Ford Focus";
            }

            else if (userFavoriteColor == "Orange")
            {
                string userTransportation = "Chevy Cavalier";
            }

            else if (userFavoriteColor == "Yellow")
            {
                string userTransportation = "Buick Century";
            }

            else if (userFavoriteColor == "Green")
            {
                string userTransportation = "Chevy Trax";
            }

            else if (userFavoriteColor == "Blue")
            {
                string userTransportation = "Land Rover Discovery";
            }

            else if (userFavoriteColor == "Indigo")
            {
                string userTransportation = "VW Tiguan";
            }

            else
            {
                string userTransportation = "Kia Sportage";
            }



        

        }
    }
}
