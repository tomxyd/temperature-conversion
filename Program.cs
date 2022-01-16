using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        var converter = new TemperatureConverter();
        converter.Init();
    }
}