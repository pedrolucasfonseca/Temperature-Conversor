using System;

enum Scale
{
    Kelvin,
    Celsius,
    Fahrenheit
}

class Temperature
{
    private double value;
    private Scale scale;

    public Temperature(double value, Scale scale)
    {
        this.value = value;
        this.scale = scale;
    }

    public double ToKelvin()
    {
        switch (scale)
        {
            case Scale.Celsius:
                return value + 273.15;
            case Scale.Fahrenheit:
                return (value - 32) * 9/5  + 273.15;
            default:
                return 0;
        }
    }
    public double ToCelsius()
    {
        switch(scale)
        {
            case Scale.Kelvin:
                return value - 273.15;
            case Scale.Fahrenheit:
                return (value - 32) * 5/9;
            default:
                return 0;
        }
    }
    public double ToFahrenheit()
    {
        switch(scale)
        {
            case Scale.Kelvin:
                return (value - 273.15) * 9/5 + 32;
            case Scale.Celsius:
                return (value * 9/5) + 32;
            default:
                return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Conversor");
        Console.WriteLine("1 - Celsius to Kelvin");
        Console.WriteLine("2 - Fahrenheit to Kelvin");
        Console.WriteLine("3 - Kelvin to Celsius");
        Console.WriteLine("4 - Fahrenheit to Celsius");
        Console.WriteLine("5 - Kelvin to Fahrenheit");
        Console.WriteLine("6 - Celsius to Fahrenheit");
        Console.WriteLine("7 - Quit");
        Console.Write("Option: ");
        string option = Console.ReadLine() ?? "7";

        double kelvin, celsius, fahrenheit;

        switch(option)
        {
            case "1":
                do 
                {
                    Console.Write("Type the temperature in Celsius: ");
                    celsius = double.Parse(Console.ReadLine() ?? "0");

                    if (celsius < -273.15)
                        Console.WriteLine("Celsius cannot be below -273.15. Try again.");
                    else 
                    {
                        Temperature t = new Temperature(celsius, Scale.Celsius);
                        Console.WriteLine($"Result: {t.ToKelvin():F2}°K");
                    }
                } while (celsius < -273.15);
                break;
            case "2":
                do 
                {
                    Console.Write("Type the temperature in : ");
                    fahrenheit = double.Parse(Console.ReadLine() ?? "0");

                    if (fahrenheit < -458.67)
                        Console.WriteLine("Fahrenheit cannot be below -458.67, Try again");
                    else 
                    {
                        Temperature t = new Temperature(fahrenheit, Scale.Fahrenheit);
                        Console.WriteLine($"Result: {t.ToKelvin():F2}°K");
                    }
                } while (fahrenheit < -458.67);
                break;
            case "3":
                do 
                {
                    Console.Write("Type the temperature in Kelvin: ");
                    kelvin = double.Parse(Console.ReadLine() ?? "0");

                    if (kelvin < 0)
                        Console.WriteLine("Kelvin cannot be below 0. Try again.");
                    else
                    {
                        Temperature t = new Temperature(kelvin, Scale.Kelvin);
                        Console.WriteLine($"Result: {t.ToCelsius():F2}°C");
                    }
                } while(kelvin < 0);
                break;
            case "4":
                do
                {
                    Console.Write("Type the temperature in Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine() ?? "0");

                    if (fahrenheit < -458.67)
                        Console.WriteLine("Fahrenheit cannot be below -458.67. Try Again");
                    else
                    {
                        Temperature t = new Temperature(fahrenheit, Scale.Fahrenheit);
                        Console.WriteLine($"Result: {t.ToCelsius():F2}°C");
                    }
                } while (fahrenheit < -458.67);
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
                        Temperature t = new Temperature(kelvin, Scale.Kelvin);
                        Console.WriteLine($"Result: {t.ToFahrenheit():F2}°F");
                    }
                } while (kelvin < 0);
                break;
            case "6":
                do
                {
                    Console.Write("Type the temperature in Celsius: ");
                    celsius = double.Parse(Console.ReadLine() ?? "0");

                    if (celsius < -273.15)
                        Console.WriteLine("Celsius cannot be below -273.15. Try Again");
                    else
                    {
                        Temperature t = new Temperature(celsius, Scale.Celsius);
                        Console.WriteLine($"Result: {t.ToFahrenheit():F2}°F");
                    }
                } while (celsius < -273.15);
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