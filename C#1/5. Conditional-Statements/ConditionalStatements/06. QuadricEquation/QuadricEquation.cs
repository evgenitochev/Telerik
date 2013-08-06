/*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/

using System;

class QuadricEquation
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("The equation is a linear equation!");
            double x = -c / b;
            Console.WriteLine("The equation root is {0:0.00}",x);
        } 
        else
        {
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The equation roots are:\nX1: {0:0.00}\nX2: {1:0.00}", x1, x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equaltion has only one root: {0:0.00}", x);

            }
            else if (d < 0)
            {
                Console.WriteLine("This equations doesn't have real roots!");
            }
        }
    }
}