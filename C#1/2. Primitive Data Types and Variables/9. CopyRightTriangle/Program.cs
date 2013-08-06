/*Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
  Use Windows Character Map to find the Unicode code of the © symbol. 
*/



using System;

class TriangleCopyrightSymbols
{
    static void Main()
    {
        char symbol = '\u00A9';
        for (int i = 1; i <= 9; i++)
        {
             for (int j = 1; j <= i; j++)
              {
                  Console.Write("{0} ", symbol);
              }
                  Console.WriteLine();
        }

    }
}