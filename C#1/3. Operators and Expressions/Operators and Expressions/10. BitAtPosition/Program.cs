/* Write a boolean expression that returns if the bit at position p (counting from 0)
   in a given integer number v has value of 1. Example: v=5; p=1  false.
*/

using System;

class BitAtPosition
{
    static void Main()
    {
        string numberV = Console.ReadLine();
        int number = int.Parse(numberV);

        string numberP = Console.ReadLine();
        int p = int.Parse(numberP);

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
