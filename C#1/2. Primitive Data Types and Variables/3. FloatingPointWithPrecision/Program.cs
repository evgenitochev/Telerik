/* Write a program that safely compares floating-point numbers with precision of 0.000001.
   Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
*/

using System;

class FloatingPointWithPrecision
{
    static void Main()
    {
        {
            float num1 = 5.03f;
            float num2 = 5.04f;
            Boolean compare = (num1 == num2);
            Console.WriteLine(compare);
            float num3 = 5.00000001f;
            float num4 = 5.00000003f;
            Console.WriteLine(num3 == num4);
        }
    }
}