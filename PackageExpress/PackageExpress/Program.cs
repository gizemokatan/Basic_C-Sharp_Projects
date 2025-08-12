using System; 

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for package weight
        Console.Write("Please enter the package weight: ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // If the weight is greater than 50, end the program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; 
        }

        // Ask for package width
        Console.Write("Please enter the package width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask for package height
        Console.Write("Please enter the package height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask for package length
        Console.Write("Please enter the package length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // If the total weight is greater than 50, end the program
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; 
        }

        // Computation
        decimal quote = (width * height * length * weight) / 100;

        // Quote output
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote);

        // Thank you message
        Console.WriteLine("Thank you!");
    }
}
