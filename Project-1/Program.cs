﻿using System;
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



            //Part 2 Formatting. Nothing to print in this part. Taking user information from Part 1 to complete the following:
            //Variables:  userAge
            //string userRetiresIn = int.Parse(Console.ReadLine()); 
            //    //userSiblings
            //    string userVacationHome = 
            //    //userFavoriteColor
            //    string userTransportation = 
            //    //userBirthMonth
            //    string userFundsInBank = 
             
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


            //if (userBirthMonth >= 1 && userBirthMonth <= 4)
            //{
            //    string userFundsInBank = "$10,000";
            //}

            //else if (userBirthMonth >= 5 && userBirthMonth <= 8 )
            //{
            //    string userFundsInBank = "$1,000,000,000";
            //}

            //else if (userBirthMonth >= 9 && userBirthMonth <= 12 )
            //{
            //    string userFundsInBank = "$1,000,000";
            //}

            //else
            //{
            //    string userFundsInBank = "$0.00";
            //}

            //string userBirthMonth = 1;
            //switch (userBirthMonth >= 1 && userBirthMonth <= 4)
            //{
            //    case 1:
            //        Console.WriteLine("You'll retire with $10,000 in the bank.");
            //        break;
            //    case 2:
            //        Console.WriteLine("You'll retire with $1,000,000,000 in the bank.");
            //        break;

            //}

            // Part 3. Fortune Telling

            Console.WriteLine("Thank you for your answers. Your fortune is being tabulated...");



            Console.WriteLine(userFirstName + userLastName + "You will retire in" + userAge + "with" + userBirthMonth + "and a vacation home in" + userSiblings + "and a" + userFavoriteColor + "car.");


            // Having trouble figuring out how to definte the below variables in line with user data.

            //Console.WriteLine("You will retire in" + userAge + "with" + userBirthMonth + "and a vacation home in" + userSiblings + "and a" + userFavoriteColor + "car.");


            //Console.WriteLine("You will retire in" + userRetiresIn + "with" + userFundsInBank + "and a vacation home in" + userVacationHome + "and a" + userTransportation + "car.")*/;

            //Console.WriteLine(Console.ReadLine(userRetiresIn);
            //Console.WriteLine("With" + userFundsInBank);
            //Console.WriteLine("A vacation home in" + userVacationHome);
            //Console.WriteLine("And a" + userTransportation);




        }
    }
}
