using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // String array
        string[] fruits = { "Apple", "Banana", "Orange" };

        Console.WriteLine("Enter index (0-2) for fruits:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        if (stringIndex >= 0 && stringIndex < fruits.Length)
        {
            Console.WriteLine("You picked: " + fruits[stringIndex]);
        }
        else
        {
            Console.WriteLine("Index not valid for fruits!");
        }

        // Integer array
        int[] numbers = { 10, 20, 30 };

        Console.WriteLine("Enter index (0-2) for numbers:");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        if (intIndex >= 0 && intIndex < numbers.Length)
        {
            Console.WriteLine("You picked: " + numbers[intIndex]);
        }
        else
        {
            Console.WriteLine("Index not valid for numbers!");
        }

        // List of strings
        List<string> animals = new List<string>();
        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Elephant");

        Console.WriteLine("Enter index (0-2) for animals:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        if (listIndex >= 0 && listIndex < animals.Count)
        {
            Console.WriteLine("You picked: " + animals[listIndex]);
        }
        else
        {
            Console.WriteLine("Index not valid for animals!");
        }

        Console.WriteLine();
    }
}
