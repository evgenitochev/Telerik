/*  We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators
    that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)
*/

using System;

class SetValue
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        string strP = Console.ReadLine();
        int p = int.Parse(strP);

        string strV = Console.ReadLine();
        int v = int.Parse(strV);

        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << p;
            result = number | mask;
            Console.WriteLine(result);
        }
    }
}

