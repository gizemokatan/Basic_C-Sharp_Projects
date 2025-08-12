using System;

namespace DailyReportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program starts with heading
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report.\n");

            // Asking for student's name
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine(); 

            // Asking for course name
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine(); 

            // Asking for current page number
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine()); 

            // Asking if student needs help (true/false)
            Console.Write("Do you need help with anything? Please answer “true” or “false”: ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine()); 

            // Asking for any positive experiences
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine(); 

            // Asking for other feedback
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string otherFeedback = Console.ReadLine(); 

            // Asking how many hours studied
            Console.Write("How many hours did you study today? ");
            double studyHours = Convert.ToDouble(Console.ReadLine()); 

            // Ending message
            Console.WriteLine("\nThank you for your answers. An Instructor will respond shortly. Have a great day!");

            Console.ReadKey();
        }
    }
}
