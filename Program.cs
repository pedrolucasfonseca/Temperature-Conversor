using System;
using System.Reflection;
using System.Runtime.InteropServices;

class TemperatureConversor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Conversor");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");
        Console.Write("Option: ");
        string ? option = Console.ReadLine();

        double celsius, fahrenheit;

        switch(option)
        {
            case "1":
                Console.Write("Type the temperature in Celsius: ");
                 celsius = double.Parse(Console.ReadLine() ?? "0");
                fahrenheit = (celsius * 1.8) + 32;
                Console.WriteLine($"Result: {fahrenheit:F2}°F");
                break;
            case "2":
                Console.Write("Type the temperature in Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine() ?? "0");
                celsius = (fahrenheit - 32) * 5/9;
                Console.WriteLine($"Result: {celsius:F2}°C");
                break;
            default:
                Console.WriteLine("Please submit a valid option.");
                break;
        }
    }
}