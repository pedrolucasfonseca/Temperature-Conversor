# Temperature Conversor

A console application built in C# that converts temperatures between Kelvin, Celsius and Fahrenheit, applying Object-Oriented Programming concepts.

## Features

- Kelvin conversor
- Celsius conversor
- Fahrenheit conversor
- Temperature cannot be below its physical limit (ex: Kelvin cannot be below 0)
- Results displayed with 2 decimal places

## How to Run?

1. Clone the repository
2. Open the project in Visual Studio
3. Press `F5` or click Run

## Technologies

- C# / .NET
- Console Application

## Object-Oriented Programming

- **Encapsulation**: `value` and `scale` are private attributes, accessible only within the `Temperature` class.
- **Abstraction**: the `Temperature` class hides conversion logic behind simple methods like `ToKelvin()`, `ToCelsius()` and `ToFahrenheit()`.

## About

Console application developed in C# that converts temperatures between Celsius, Fahrenheit and Kelvin. Refactored to use Object-Oriented Programming while learning C# and OOP fundamentals.