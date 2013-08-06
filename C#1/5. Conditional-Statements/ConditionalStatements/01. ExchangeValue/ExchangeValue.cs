/*Write an if statement that examines two integer variables and exchanges 
  their values if the first one is greater than the second one.
 */

using System;

class ExchangeValue
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1>num2)
        {
            int temp=0;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine("{0},{1} " , num1,num2);
    }
}
