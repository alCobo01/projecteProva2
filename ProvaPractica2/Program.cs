using System;
using UtilsLibrary;

namespace provaPractica2
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "Which number do you want to find? ",
                OverflowExceptionMessage = "Number too long, try again.",
                FormatExceptionMessage = "Incorrect format, try again.",
                GeneralExceptionMessage = "General exception, try again.";

            int[] numbersArray = [10, 4, 6, 4, 8, -13, 2, 3];

            int userInput = 0;
            bool isValid = false;

            //Main program
            do
            {
                Console.Write(FirstMessage);
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                } 
                catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

            } while (!isValid);

            SecondSort.Order(numbersArray, 0, 7);
            Console.WriteLine(SearchClass.BinarySearch(numbersArray, 0, 7, userInput));

            //Apartat B
            Console.Write("Array sorted in ascendent: ");
            for (int i = 0; i < numbersArray.Length; i++) { 
                Console.Write($"{numbersArray[i]} ");
            }
        }
    }
}