//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractValue
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        string strP = Console.ReadLine();
        int p = int.Parse(strP);

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("Bit on position {0} is: {1}", p, bit);
    }
}
