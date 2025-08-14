using System;
using System.Text; // Needed for StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. Concatenate three strings ---
            string firstName = "John";    
            string middleName = "Michael"; 
            string lastName = "Smith";    

            // Concatenate the three strings into one full name
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the concatenated result
            Console.WriteLine("Full Name: " + fullName);

            // --- 2. Convert a string to uppercase ---
            string message = "hello world"; 
            string upperMessage = message.ToUpper();

            // Display the uppercase string
            Console.WriteLine("Uppercase Message: " + upperMessage);

            // --- 3. Create a StringBuilder and build a paragraph ---
            StringBuilder paragraph = new StringBuilder(); 

            // Append sentences one by one to build a paragraph
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here comes the second sentence. ");
            paragraph.Append("Finally, this is the third sentence that completes the paragraph.");

            // Display the paragraph
            Console.WriteLine("\nParagraph:\n" + paragraph.ToString());

            // End of program message
            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
