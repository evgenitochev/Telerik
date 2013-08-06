//Sort 3 real values in descending order using nested if statements.

using System;

class SortValues
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", num1, num3, num2);
                }
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", num3, num1, num2);
            }
        }
        else if (num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine("{0}\n{1}\n{2}", num2, num1, num3);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", num2, num3, num1);
            }
        }
        else
        {
            Console.WriteLine("{0}\n{1}\n{2}", num3, num2, num1);
        }
        Console.WriteLine();
    }
}