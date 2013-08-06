//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;


class ThirdBit
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int p = 3;
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("Third bit is " + bit);
    }
}