using ParametersAssignment;
using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an Employee object with string type
            Employee<string> employeeStrings = new Employee<string>();
            // Assign a list of strings
            employeeStrings.Things = new List<string>() { "Laptop", "Notebook", "Pen" };

            // Create an Employee object with int type
            Employee<int> employeeNumbers = new Employee<int>();
            // Assign a list of integers
            employeeNumbers.Things = new List<int>() { 1, 2, 3, 4, 5 };

            // Loop through all string things and print them
            Console.WriteLine("Employee with string Things:");
            foreach (string item in employeeStrings.Things)
            {
                Console.WriteLine(item);
            }

            // Loop through all int things and print them
            Console.WriteLine("Employee with int Things:");
            foreach (int number in employeeNumbers.Things)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine(); 
        }
    }
}
