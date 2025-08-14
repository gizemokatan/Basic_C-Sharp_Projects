using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inform the user about the program
            Console.WriteLine("WHILE and DO WHILE statements");

            // WHILE STATEMENT
            
            Console.WriteLine("\n--- WHILE Example ---");
            int number = 1;
            while (number <= 5) 
            {
                Console.WriteLine("Number is: " + number); 
                number++; 
            }

            // DO WHILE STATEMENT
            
            Console.WriteLine("\n--- DO WHILE Example ---");
            int count = 6; 
            do
            {
                Console.WriteLine("Count is: " + count); 
                count++; 
            }
            while (count <= 10); 

            // End of program message
            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadLine(); 
        }
    }
}
