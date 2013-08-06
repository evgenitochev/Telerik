/*Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
 */


using System;
using System.Numerics;

class NumberArray
{
    static void NumberSum(BigInteger[] firstNum, BigInteger[] secondNum)
    {
        Array.Reverse(firstNum);
        Array.Reverse(secondNum);

        int neededLength = 0;

        if (firstNum.Length > secondNum.Length)
        {
            neededLength = firstNum.Length + 1;
        }
        else
        {
            neededLength = secondNum.Length + 1;
        }

        BigInteger[] newNumber = new BigInteger[neededLength];
       
        for (int i = 0; i < newNumber.Length; i++)
        {
            if (i < firstNum.Length)
            {
                newNumber[i] = newNumber[i] + firstNum[i];
               
                if (newNumber[i] >= 10)
                {
                    newNumber[i] = newNumber[i] - 10;
                    newNumber[i + 1] = newNumber[i + 1] + 1;
                }
            }

            if (i < secondNum.Length)
            {
                newNumber[i] = newNumber[i] + secondNum[i];
                if (newNumber[i] >= 10)
                {
                    newNumber[i] = newNumber[i] - 10;
                    newNumber[i + 1] = newNumber[i + 1] + 1;
                }
            }
        }

        Array.Reverse(newNumber); 
       
        for (int i = 0; i < newNumber.Length; i++)
        {
            Console.Write(newNumber[i]);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        BigInteger[] firstNum = { 1, 4, 9 };
        BigInteger[] secondNum = { 1, 3, 0, 9, 5 };
        NumberSum(firstNum, secondNum);
    }
}