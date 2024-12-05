using System;
using UtilsLibrary;

namespace provaPractica2
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "Write the day: ",
                SecondMessage = "Write the month: ",
                ThirdMessage = "Write the year: ",
                FinalValidMessage = "The {0} is valid! {1} is a correct number.",
                FinalNotValidMessage = "The {0} is not valid! {1} is an incorrect number.",
                OverflowExceptionMessage = "Number too long, try again.",
                FormatExceptionMessage = "Incorrect format, try again.",
                GeneralExceptionMessage = "General exception, try again.";

            int day = 0, month = 0, year = 0;
            bool isValid = false;

            //Day input
            do
            {
                Console.Write(FirstMessage);
                try
                {
                    day = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

            } while (!isValid);
            isValid = false;

            //Month input
            do
            {
                Console.Write(SecondMessage);
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

            } while (!isValid);
            isValid = false;

            //Year input
            do
            {
                Console.Write(ThirdMessage);
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
                catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
                catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

            } while (!isValid);
            isValid = false;

            if (MyUtils.IsInRange(day, 1, 31)) { Console.WriteLine(FinalValidMessage, "day", day); } else { Console.WriteLine(FinalNotValidMessage, "day", day); }
            if (MyUtils.IsInRange(month, 1, 31)) { Console.WriteLine(FinalValidMessage, "month", month); } else { Console.WriteLine(FinalNotValidMessage, "month", month); }
            if (MyUtils.IsInRange(year, 1, 31)) { Console.WriteLine(FinalValidMessage, "year", year); } else { Console.WriteLine(FinalNotValidMessage, "year", year); }

        }
    }
}
