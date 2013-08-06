/* Write a program that reads two positive integer numbers and 
   prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive).
   Example: p(17,25) = 2.
 */

using System;

class TwoNumbers
{
    static void Main()
    {
        Console.Write("First number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Second number:");
        int num2 = int.Parse(Console.ReadLine());

        int p = 0;
        for (int i = num1; i <= num2; i++)
        {
            if (i % 5 == 0)
            {
                p = p + 1;
            }
        } 
        
        Console.WriteLine();
        Console.WriteLine("{0} numbers between {1} and {2} the reminder of the division by 5 is 0",p,num1,num2);
       
            
    }
           
}