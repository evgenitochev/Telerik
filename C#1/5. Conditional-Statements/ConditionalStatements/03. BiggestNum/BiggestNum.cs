//Write a program that finds the biggest of three integers using nested if statements.

using System;
class BiggestNum
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("The biggest number is {0}", num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("The biggest number is {0}", num2);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", num3);

        }


    }
}