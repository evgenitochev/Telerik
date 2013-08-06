//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class WithinCircleOutRectangle
{
    static void Main()
    {
        string pX = Console.ReadLine();
        string pY = Console.ReadLine();
        double pointX = double.Parse(pX);
        double pointY = double.Parse(pY);
        double radius = 3;
        double centerX = 1;
        double centerY = 1;

        if ((((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius * radius)) &&
            ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1)))
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and in rectangle", 
                pointX, pointY);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K((1,1),3) or out of rectangle",
                pointX, pointY);
        }
    }
}