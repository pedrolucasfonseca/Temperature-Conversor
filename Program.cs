using System;

class TemperatureConversor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Conversor");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");
        Console.WriteLine("3 - Kelvin to Celsius");
        Console.WriteLine("4 - Celsius to Kelvin");
        Console.WriteLine("5 - Kelvin to Fahrenheit");
        Console.WriteLine("6 - Fahrenheit to Kelvin");
        Console.WriteLine("7 - Quit");
        Console.Write("Option: ");
        string  option = Console.ReadLine() ?? "7";

        double celsius, fahrenheit, kelvin;

        switch(option)
        {
            case "1":
                do {
                        Console.Write("Type the temperature in Celsius: ");
                        celsius = double.Parse(Console.ReadLine() ?? "0");

                        if (celsius < -273.15)
                            Console.WriteLine("Celsius cannot be below -273.15. Try again.");
                        else 
                        {
                            fahrenheit = (celsius * 1.8) + 32;
                            Console.WriteLine($"Result: {fahrenheit:F2}°F");
                        }

                    } while (celsius < -273.15);
                break;
            case "2":
                do {
                        Console.Write("Type the temperature in Fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine() ?? "0");

                        if (fahrenheit < -458.67)
                            Console.WriteLine("Fahrenheit cannot be below -458.67, Try again");
                        else 
                        {
                            celsius = (fahrenheit - 32) * 5/9;
                            Console.WriteLine($"Result: {celsius:F2}°C");
                        }

                    } while (fahrenheit < -458.67);
                break;
            case "3":
                do {
                        Console.Write("Type the temperature in Kelvin: ");
                        kelvin = double.Parse(Console.ReadLine() ?? "0");

                        if (kelvin < 0)
                            Console.WriteLine("Kelvin cannot be below 0. Try again.");
                        else
                        {
                        celsius = kelvin - 273.15;
                        Console.WriteLine($"Result: {celsius:F2}°C");
                        }

                    } while(kelvin < 0);
                break;
            case "4":
                do
                {
                    Console.Write("Type the temperature in Celsius: ");
                    celsius = double.Parse(Console.ReadLine() ?? "0");

                    if (celsius < -273.15)
                        Console.WriteLine("Celsius cannot be below -273.15. Try Again");
                    else
                    {
                        kelvin = celsius + 273.15;
                        Console.WriteLine($"Result: {kelvin:F2}°K");
                    }

                } while (celsius < -273.15);
                break;
            case "5":
                do
                {
                    Console.Write("Type the temperature in Kelvin: ");
                    kelvin = double.Parse(Console.ReadLine() ?? "0");

                    if (kelvin < 0)
                        Console.WriteLine("Kelvin cannot be below 0. Try again.");
                    else
                    {
                        fahrenheit = (kelvin - 273.15) * 9/5 + 32;
                        Console.WriteLine($"Result: {fahrenheit:F2}°F");
                    }

                } while (kelvin < 0);
                break;
            case "6":
                do
                {
                    Console.Write("Type the temperature in fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine() ?? "0");

                    if (fahrenheit < -458.67)
                        Console.WriteLine("Fahrenheit cannot be below -458.67. Try Again");
                    else
                    {
                        kelvin = (fahrenheit - 32) * 5/9 + 273.15;
                        Console.WriteLine($"Result: {kelvin:F2}°K");
                    }
                } while (fahrenheit < -458.67);
                break;
            case "7":
                Console.WriteLine("Bye!");
                break;
            default:
                Console.WriteLine("Please submit a valid option.");
                break;
        }
    }
}