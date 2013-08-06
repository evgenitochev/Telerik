// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.


using System;


class IntegerExchange
{
    static void Main()
    {
      
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("Original Value: \n a= 5 \n b = 10 \n \n  New Value: \n a = {0} \n b = {1}", a, b);

    }
}


