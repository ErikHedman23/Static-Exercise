namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter 1 for F to C\nEnter 2 for C to F");
                var userSelection = int.TryParse(Console.ReadLine(), out int userOutput);
                if (userSelection == false)
                {
                    Console.WriteLine("Invalid Entry. Try again...");
                    continue;
                }
                switch (userOutput)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter a number value to display the conversion from Fahrenheit to Celsius:");

                double temp;
                var tempInput = double.TryParse(Console.ReadLine(), out temp);
                if (tempInput == false)
                {
                    Console.WriteLine("Invalid Entry. Try again...");
                    continue;
                }
                temp = TempConverter.FahrenheitToCelsius(temp);
                Console.WriteLine($"The temp outside is {temp} C\n");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enter a numbr value to display the conversion from Celsius to Fahrenheit:");
                tempInput = double.TryParse(Console.ReadLine(), out temp);
                if (tempInput == false)
                {
                    Console.WriteLine("Invalid Entry. Try again...");
                    continue;
                }
                temp = TempConverter.CelsiusToFahrenheit(temp);
                Console.WriteLine($"The temp outside is {temp} F ");
                        break;
                }
                
            
            }
        }
    }
}
