/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
 */


using System;

class MaxInt
{
    static int GetMax (int firstNumber, int secondNumber)
    {
      
        int maxNum = firstNumber;
        if (firstNumber < secondNumber)
        {
            maxNum = secondNumber;
        }

        return maxNum;
    }

    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int tempMax = GetMax(firstNum, secondNum);

        Console.WriteLine(GetMax(tempMax, thirdNum)); 
    }
}
