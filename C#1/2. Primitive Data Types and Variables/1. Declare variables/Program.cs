// 1. Declare five variables choosing for each of them the most appropriate type: 52130, -115, 4825932, 97, -10000.

using System;


class DeclareVariables
{
    static void Main()
    {
        byte num1 = 97; // number is lower than 127
        sbyte num2 = -115; //number is between -128 and +128
        short num3 = -10000; //number is between -32768 and +32767
        ushort num4 = 52130; //number is between 0 and 65535
        int num5 = 4825932; // number is between -2147483648 and +2147483647

        Console.WriteLine(" {0} {1} {2} {3} {4}", num1, num2, num3, num4, num5);
    }
}