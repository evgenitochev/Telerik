//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DevideBy7And3

{
    static void Main()
    {
        string textInput = Console.ReadLine();
        int number = int.Parse(textInput);
        Console.WriteLine(number );
        bool devideBy5 = number % 5==0;
        bool devideBy7 = number % 7==0;
        bool devide= devideBy5 && devideBy7;
        Console.WriteLine(devide);

    }
}

