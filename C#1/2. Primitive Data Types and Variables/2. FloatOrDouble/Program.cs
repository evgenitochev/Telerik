﻿// 2.Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;


class FloatOrDouble
{
    static void Main()
    {
        /* FLOAT:real numbers that have up to 7 digits
           DOUBLE:real numbers that have up to 15 - 16 digits
        */

        double num1 = 34.567839023d;
        float num2 = 12.345f;
        double num3 = 8923.1234857f;
        float num4 = 3456.091f;

        Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);
    }
}