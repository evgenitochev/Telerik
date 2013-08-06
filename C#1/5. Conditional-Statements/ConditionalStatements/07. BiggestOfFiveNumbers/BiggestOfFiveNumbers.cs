//Write a program that finds the greatest of given 5 variables.

using System;
class BiggestOfFiveNumbers
{
    static void Main()
    {
        
        double num1 = double.Parse(Console.ReadLine());
        double num2= double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine()); 
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        double BiggestNum = num1;

        if (BiggestNum < num2)
        {
            BiggestNum = num2;
        }
        if (BiggestNum < num3)
        {
            BiggestNum = num3;
        }
        if (BiggestNum < num4)
        {
            BiggestNum = num4;
        }
        if (BiggestNum < num5)
        {
            BiggestNum = num5;
        }
        Console.WriteLine("The greatest number is: {0}", BiggestNum);
    }
}