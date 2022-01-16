using System;

class TemperatureConverter
{
    public void Init()
    {
        Console.WriteLine("Enter which conversion process you would like to do");
        Console.WriteLine("\t1- C to F");
        Console.WriteLine("\t2- F to C");
        Console.WriteLine("\tx- Exit");

        string? userChoice;
        userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                ConvertCToF();
                break;
            case "2":
                ConvertFToC();
                break;
            case "x":
                Exit();
                break;
            default:
                Exit();
                break;
        }

    }

    void ConvertCToF()
    {
        int degree = AskForInput();
        int value;
        value = (degree * 9 / 5) + 32;
        Console.WriteLine($"\n {degree}C is {value}F ");

    }

    void ConvertFToC()
    {
        int degree = AskForInput();
        int value;
        value = (degree - 32) * 5 / 9;
        Console.WriteLine($"\n {degree}F is {value}C ");
    }

    int AskForInput()
    {
        Console.WriteLine("Input the value you want to convert to");
        int value;
        value = Convert.ToInt32(Console.ReadLine());
        return value;

    }

    void Exit()
    {
        Console.Clear();
    }
}