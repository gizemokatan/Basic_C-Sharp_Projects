using System;
using System.Collections.Generic; // Needed for List<T>


class Program
{
    static void Main(string[] args)
    {

     // ----------- ASSIGNMENT PART 1 ------------------

        // Create one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye" };

        // Ask the user to type some text
        Console.WriteLine("Please type something:");
        string userInput = Console.ReadLine();

        // First loop: add user input to the end of each string in the array
        for (int i = 0; i < words.Length; i++)
        {
            // Append user input to the current element
            words[i] = words[i] + " " + userInput;
        }

        // Second loop: print each string in the array
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }


     // ----------- ASSIGNMENT PART 2 ------------------

        //while (true) // infinite loop
        //{
        //    Console.WriteLine("Type 'q' to quit the loop, or type anything else to continue:");
        //    string input = Console.ReadLine();

        //    if (input == "q")
        //    {
        //        // break stops the loop, fixing the infinite loop problem
        //        break;
        //    }

        //    Console.WriteLine("You typed: " + input);
        //}


     // ----------- ASSIGNMENT PART 3 ------------------

        // Example with < operator
        Console.WriteLine("Loop using < operator:");
        for (int i = 0; i < 13; i++) 
        {
            Console.WriteLine("i is: " + i);
        }

        // Example with <= operator
        Console.WriteLine("Loop using <= operator:");
        for (int j = 0; j <= 13; j++) 
        {
            Console.WriteLine("j is: " + j);
        }


     //// ----------- ASSIGNMENT PART 4 ------------------

     //   // Create a list of unique strings
     //   List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry", "Orange", "Grape" };

     //   // Ask the user to type some text to search for
     //   Console.WriteLine("Enter a fruit to search for:");
     //   string userSearch = Console.ReadLine();

     //   // Variable to check if we found the item
     //   bool found = false;

     //   // Loop through the list
     //   for (int i = 0; i < fruits.Count; i++)
     //   {
     //       if (fruits[i] == userSearch) // check if user input matches list item
     //       {
     //           Console.WriteLine(userSearch + " is at index " + i);
     //           found = true;
     //           break; 
     //       }
     //   }

     //   // If not found, tell the user
     //   if (found == false)
     //   {
     //       Console.WriteLine(userSearch + " is not on the list");
     //   }


     // ----------- ASSIGNMENT PART 5 ------------------

        // Create a list of strings (with duplicates)
        List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry","Orange", "Apple", "Orange", "Banana" };

        // Ask the user to type some text to search for
        Console.WriteLine("Enter a fruit to search for:");
        string userSearch = Console.ReadLine();

        // Variable to check if we found at least one match
        bool found = false;

        // Loop through the list
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == userSearch) // check if item matches
            {
                Console.WriteLine(userSearch + " found at index " + i);
                found = true;
            }
        }

        // If no match was found
        if (found == false)
        {
            Console.WriteLine(userSearch + " is not on the list");
        }


        // ----------- ASSIGNMENT PART 6 ------------------

        // Create a list of strings with duplicates
        List<string> letters = new List<string>() { "A", "B", "C", "D", "C", "C", "D" };

        // Create another list to keep track of items we have already seen
        List<string> seenItems = new List<string>();

        // Loop through each item in the list using foreach
        foreach (string letter in letters)
        {
            // Check if this letter has already been seen
            if (seenItems.Contains(letter))
            {
                // If yes, then it's a duplicate
                Console.WriteLine(letter + " - this item is a duplicate");
            }
            else
            {
                // If not, it's unique
                Console.WriteLine(letter + " - this item is unique");

                // Add the letter to seenItems so we remember it for later
                seenItems.Add(letter);
            }
        }


        Console.WriteLine("Program finished. Press any key to close.");
        Console.ReadLine();
    }
}
