namespace Assement_SW_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Conversion Program!");
            double temperature;
            do
            {
                Console.Write("Enter Valid the temperature value: ");

            } while (!(double.TryParse(Console.ReadLine(), out temperature)));

            string? originalUnit;
            do
            {
                Console.Write("Enter valid the unit of the temperature (C/F/K): ");
                originalUnit = Console.ReadLine()?.ToUpper() ?? string.Empty;


            } while ((string.IsNullOrEmpty(originalUnit) || string.IsNullOrWhiteSpace(originalUnit)) || ((originalUnit != "C") && (originalUnit != "F") && (originalUnit != "K")));


            double celsius, fahrenheit, kelvin;


            if (originalUnit == "C")
            {
                celsius = temperature;
                fahrenheit = (celsius * 9 / 5) + 32;
                kelvin = celsius + 273.15;
            }
            else if (originalUnit == "F")
            {
                fahrenheit = temperature;
                celsius = (fahrenheit - 32) * 5 / 9;
                kelvin = celsius + 273.15;
            }
            else
            {
                kelvin = temperature;
                celsius = kelvin - 273.15;
                fahrenheit = (celsius * 9 / 5) + 32;
            }
            Console.WriteLine("\nConverted Temperatures:");
            Console.WriteLine($"Celsius: {celsius:F2}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
            Console.WriteLine($"Kelvin: {kelvin:F2}K");
        }
    }
}
