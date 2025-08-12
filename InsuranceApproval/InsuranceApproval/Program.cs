using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Car Insurance Qualification Program");

        // Ask for applicant's age and convert the input to integer
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the applicant has ever had a DUI (true/false)
        Console.Write("Have you ever had a DUI? (true or false): ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask how many speeding tickets the applicant has and convert the input to integer
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Apply qualification rules using a boolean expression:
        // - Must be over 15
        // - Must NOT have a DUI
        // - Must have 3 or fewer speeding tickets
        bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

        // Output result: true if qualified, false if not
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}

