using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Input for Person 1
            Console.WriteLine("\nPerson 1");

            // Ask hourly rate for Person 1
            Console.Write("Hourly Rate? ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine()); 

            // Ask hours worked per week for Person 1
            Console.Write("Hours worked per week? ");
            decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            // Input for Person 2
            Console.WriteLine("\nPerson 2");

            // Ask hourly rate for Person 2
            Console.Write("Hourly Rate? ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine()); 

            // Ask hours worked per week for Person 2
            Console.Write("Hours worked per week? ");
            decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine()); 

            // Calculate annual salaries
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52; 
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52; 

            // Display annual salaries
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1); 

            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare who earns more
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("\nPerson 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMore);

            Console.ReadLine();
        }
    }
}
