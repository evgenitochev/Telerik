//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;


class PintWithinCircle
{
    static void Main()
    {
        decimal pointX = 3.4m;
        decimal pointY = 1.4m;

        decimal resultX = pointX * pointX;
        decimal resultY = pointY * pointY;

        decimal endResult = resultX + resultY;
        decimal radius = 5;

        bool isWithinCircle = endResult < radius * radius;
        Console.WriteLine(isWithinCircle);
    }
}

