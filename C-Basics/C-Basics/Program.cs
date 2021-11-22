using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// XML template
namespace C_Basics
{
    class Program
    {
        //https://cheatography.com/laurence/cheat-sheets/c/
        //https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf

        // constants as fields - immutable
        const string permanent = "HereToStay";
        const int daysYearNonLeap = 365;
        // Main entry point necessary to run application
        /* Muti -
         * line
         * Comments */
        static void Main(string[] args)
        {
            ///<summary>
            ///This will give me a summary as I hover over methods - XML documentation comments
            ///</summary>
            static void testMethod()
            {
                Console.WriteLine("Testing summaries");
            }
            testMethod();

            //CONSOLE METHODS

            //Prints with cursor on same line
            Console.Write("same line");
            // Write to console
            Console.WriteLine("Goodbye, Pluto!");
            // Keep console open to await user entry and returns ASCII input value from user
            // Console.Read();
            // Keep console open to await user entry and returns value from user
            // Console.ReadLine();
            // Reads input of string and returns Key Info
            // Console.ReadKey();


            //VARIABLES & DATATYPES

            //Value type = int, bool, etc. [primitives] (stored directly in RAM)
            //Reference type = string, class, arrays, etc. (stored memory location w/ heap storage)


            //PRIMITIVE DATA TYPES

            // Whole numbers in range of -128 to 127
            sbyte smallNum = 115;
            // Whole numbers in range of -32767 to 32767
            short shortNum = 32000;
            // Max for int is 2,147,483,647
            int basicNumber = 5;
            // Max 9,223,372,036,854,775,807
            long largerNum = 5156545156611;

            // up to 7 digits of precision
            float decimalNum1 = 99.99f;
            // 15 digit precision
            double decimalNum2 = 6.361615655645;
            // 28 digit precision
            decimal decimalNum3 = 26.12345678910112123151618m;

            // boolean
            bool toggle = false;
            // character - needs single quote
            char moneySign = '$';

            //NON-PRIMITIVE
            string word = "animals";

            //CONCATINATION - STRING FORMATTING
            Console.WriteLine("Here are some " + word + " and " + smallNum + " apples.");
            // Use index
            Console.WriteLine("The amount of money I have is {0}{1}", decimalNum1, moneySign);
            // String interpolation
            Console.WriteLine($"What is {shortNum} + {smallNum}");
            //Verbatim - captures invisible \n
            Console.WriteLine(@"I have
                                multi
                                    lines");


            // Declaring multiple variables at once
            string car, pet, beer;

            car = "Ford Escape";
            pet = "dog";
            beer = "Hudy Delight";

            //STRING MANIPULATION/METHODS
            string pattern = "THE|*dUDE*|LEBoWsKI";
            string lowerCase = pattern.ToLower(); //the|*dude*|lebowski
            // \ backslash escape character
            string reformat = lowerCase.Replace("|", " ").Replace("*", "\""); //the "dude" lebowski
            string subString = pattern.Substring(5, 4); //dUDE

            string spaces = "  HEllo thERe my fine friend  ";
            string trimmed = spaces.Trim(); //HEllo thERe
            int indexLocation = spaces.IndexOf("fine"); //3
            bool isEmpty = String.IsNullOrWhiteSpace(spaces); //false
            string myFormatted = String.Format("Hola, my {0}", subString);
            Console.WriteLine(myFormatted);



            //IMPLICIT & EXPLICIT CONVERSION & PARSING
            //explicit
            double aDouble = 33.64;
            int anInteger = (int)aDouble; //33 - Does not round

            //implicit (small to big conversion)
            int bigNum = 123456789;
            long largerDTNum = bigNum; //123456789

            //parsing - type conversion
            string numString = anInteger.ToString(); // "33"
            int backToNum = Int32.Parse(numString); // 33


          





        }
    }
}

