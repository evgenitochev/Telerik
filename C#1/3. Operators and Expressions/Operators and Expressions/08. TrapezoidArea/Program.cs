//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;

class TrapezoidArea
{
    static void Main()
    {
        string sideA = Console.ReadLine();
        double a = double.Parse(sideA);
        string sideB = Console.ReadLine();
        double b = double.Parse(sideB);
        string heightH = Console.ReadLine();
        double h = double.Parse(heightH);

        double trapezoidArea = ((a + b) / 2) * h;

        Console.WriteLine("Trapezoid area is: " + trapezoidArea);
    }
}