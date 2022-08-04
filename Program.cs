using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace RTSLabsHomeCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RTLSLab HomeCodingExercise August 3rd 2022");
            Console.WriteLine("by Abeer Singhal");
            Console.WriteLine("requested by Greta Schrader");
            Console.WriteLine();


            Console.WriteLine("Question#1: aboveBelow");
            Console.WriteLine("Please type the unsortedlist and comparevalue after the input prompt, for example. input: [1,5,2,1,10],6");
            Console.WriteLine();
            Console.Write("input:");

            //read the console input
            string consoleInputCommand = Console.ReadLine().TrimEnd();

            ///  Method: aboveBelow(List<int>,comparevalue)
            ///  Example usage:
            ///  input: [1, 5, 2, 1, 10], 6
            ///  output: { "above": 1, "below": 4 }           
            try
            {
                ///extract the arguments for the method from the input 
                List<int> inputList = consoleInputCommand.TrimEnd().Split("],")[0].Replace("[", "").Split(',').ToList().Select(elmnt => Convert.ToInt32(elmnt)).ToList();
                int comparevalue = Convert.ToInt32(consoleInputCommand.TrimEnd().Split("],")[1].ToString().Trim());

                ///This is for debugging purposes
                ///List<int> inputList = new List<int>() { 1, 2, 3, 4 };
                ///int comparevalue = 6;
                Hashtable hashTable = HelperMethods.aboveBelow(inputList, comparevalue);

                const string singlequote = "\"";
                Console.WriteLine("output: {0}{1}above{2}: {3}, {4}below{5}: {6} {7}", "{", singlequote, singlequote,hashTable["above"].ToString(), singlequote, singlequote,hashTable["below"].ToString(),"}");
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("The method failed, possibly due to the input not being formatted correctly, please check your input and try again");
                Console.WriteLine("error:" + ex.Message);
                Console.ReadLine();
            }


            Console.WriteLine("Question#2: stringRotation");
            Console.WriteLine("At the input prompt, type the string followed by a comma and then the rotation amount. ex input: MyString,2");
            Console.WriteLine();
            Console.Write("input:");

            //read the console input
            consoleInputCommand = Console.ReadLine().TrimEnd();

            ///  Method: stringRotation(inputstring,rotationAmount)
            ///  Example usage:
            ///  input: MyString,2
            ///  output: ngMyStri

            try
            {
                ///extract the arguments for the method from the input 
                string inputString = consoleInputCommand.TrimEnd().Split(",")[0].ToString();
                int rotationAmount = Convert.ToInt32(consoleInputCommand.TrimEnd().Split(",")[1].ToString().Trim());

                ///This is for debugging purposes
                //string inputstring = "MyString";
                string returnString = HelperMethods.stringRotation(inputString, rotationAmount);

                Console.WriteLine("output: {0}", returnString);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("The method failed, possibly due to the input not being formatted correctly, please check your input and try again");
                Console.WriteLine("error:" + ex.Message);
                Console.ReadLine();
            }

            Console.WriteLine("Press Enter Key to close Console.");
            Console.ReadLine();
        }
    }
}
