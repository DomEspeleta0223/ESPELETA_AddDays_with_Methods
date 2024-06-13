using System;

namespace AddDays_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());
            string Message = Day(dayNumber);

            Console.WriteLine(Message);
            
            Console.Write("Input number to add to the day (Any Positive Number This Time): ");
            int dayToAdd = Convert.ToInt16(Console.ReadLine());

            int finalDay = dayNumber + dayToAdd;
            Message = Day(finalDay);

            Console.WriteLine(Message);
        }

        public static string Day(int num1)
        {
            int remainder = num1 % 7;
            string message = "";
            if (num1 == 1 || remainder == 1)
            {
                message = "The day is MONDAY";
            }
            else if (num1 == 2 || remainder == 2)
            {
                message = "The day is TUESDAY";
            }
            else if (num1 == 3 || remainder == 3)
            {
                message = "The day is WEDNESDAY";
            }
            else if (num1 == 4 || remainder == 4)
            {
                message = "The day is THURSDAY";
            }
            else if (num1 == 5 || remainder == 5)
            {
                message = "The day is FRIDAY";
            }
            else if (num1 == 6 || remainder == 6)
            {
                message = "The day is SATURDAY";
            }
            else if (num1 == 7 || remainder == 0)
            {
                message = "The day is   SUNDAY";
            }
            else
            {
                message = "Invalid INPUT!";
            }

            return message;
        }
    }
}
