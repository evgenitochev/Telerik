//Write a program that reads the radius r of a circle and prints its perimeter and area.


using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius of the circle:");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * (radius * radius);
        double perimeter = 2 * (Math.PI * radius);

        Console.WriteLine("The area of the circle is {0:0.00} and it's perimeter is {1:0.00}", area, perimeter);
    }
}
