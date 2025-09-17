using System;

namespace ParsingEnumsAssignment

{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ask user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read input from the user
            string userInput = Console.ReadLine();

            try
            {
                // Parse the input string into the enum DaysOfTheWeek
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                // Print the successfully parsed enum value
                Console.WriteLine("You entered: " + currentDay);
            }
            catch
            {
                // If parsing fails, show this message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine(); 
        }
    }
}
