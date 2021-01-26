using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    /*
Author:   Jeffrey Wohlfield
Date  01-26-2021

This program will prompt for several strings and validate them using Regex(Regular Expressions).

Build Specifications:
    Write a method that will validate names. Names can only have alphabets,
        they should start with a capital letter, and they have a maximum length of 30.
    Write a method that will validate emails. An email should be in the
        following format: {combination of alphanumeric characters, with a length between 5
        and 30, and there are no special characters}@{combination of alphanumeric
        characters, with a length between 5 and 10, and there are no special
        characters}.{domain can be a combination of alphanumeric characters with a length
        of two or three}
    Write a method that will validate phone numbers. A phone number should
        be in the following format: {area code of 3 digits} - {3 digits} - {4 digits}
    Write a method that will validate date based on the following format:
        (dd/mm/yyyy)

*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            ValidateName(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter an email address: ");
            ValidateEmail(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter a valid telephone number: ");
            ValidatePhoneNumber(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter a valid date (dd/mm/yyyy): ");
            ValidateDate(Console.ReadLine());
            Console.WriteLine();
        }

        public static void ValidateName (string name)
        {
            if (name.Length <= 30)
            {
                if (Regex.IsMatch(name, "([A-Z])[a-z]+"))
                {
                    Console.WriteLine("The name is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, that name is invlaid!");
                }
            }
            else
            {
                Console.WriteLine("You entered too many characters");
            }
        }

        public static void ValidateEmail (string email)
 
        {
            if(Regex.IsMatch(email, @"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                Console.WriteLine("That email address is valid!");
            }
            else
            {
                Console.WriteLine("Invalid email address!");
            }
        }

        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
            {
                Console.WriteLine("That phone number is valid!");
            }
            else
            {
                Console.WriteLine("Invalid phone number!");
            }
        }

        public static void ValidateDate(string inputDate)
        {
            if (Regex.IsMatch(inputDate, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                Console.WriteLine("That date format is valid!");
            }
            else
            {
                Console.WriteLine("Invalid date format!");
            }
        }
    }
}
