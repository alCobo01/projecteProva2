using System;
using UtilsLibrary;

namespace provaPractica2
{
    public class Program
    {
        public static void Main()
        {
            const string WriteNumbersMessage = "Write the number {0} of 20: ",
                SortedArrayMessage = "The array sorted descendant is: ",
                FindNumberMessage = "Which number do you want to find? ",
                FoundNumberMessage = "The number {0} is in the array!",
                NotFoundNumberMessage = "The number {0} is not in the array!",
                OverflowExceptionMessage = "Number too long, try again.",
                FormatExceptionMessage = "Incorrect format, try again.",
                GeneralExceptionMessage = "General exception, try again.";

            int[] numsUser = new int[20];
            int numToFind = 0;

            //Input of numbers
            for (int i = 0; i < numsUser.Length; i++)
            {
                bool isValid = false;
                do
                {
                    Console.Write(WriteNumbersMessage, i + 1);
                    try
                    {
                        numsUser[i] = Convert.ToInt32(Console.ReadLine());
                        isValid = true;
                    }
                    catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                    catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                    catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

                } while (!isValid);
            }

            //Sort and print the array
            Utils.BubbleSort(numsUser);
            Console.Write(SortedArrayMessage);
            for (int i = 0; i < numsUser.Length; i++) {
                Console.Write($"{numsUser[i]} ");
            }

            //Find number
            Console.WriteLine();
            bool isNumValid = false;
            do
            {
                Console.Write(FindNumberMessage);
                try
                {
                    numToFind = Convert.ToInt32(Console.ReadLine());
                    isNumValid = true;
                }
                catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

            } while (!isNumValid);

            if (Utils.FindNumber(numsUser, numToFind)) { Console.WriteLine(FoundNumberMessage, numToFind); } else { Console.WriteLine(FoundNumberMessage); }

        }
    }
}
