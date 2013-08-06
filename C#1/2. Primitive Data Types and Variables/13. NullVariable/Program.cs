/*Create a program that assigns null values to an integer and to double variables. 
   Try to print them on the console, try to add some values or the null literal to them and see the result.
 */


using System;

class NullValues
{
    static void Main()
    {
        int? b = null;
        int? c = 12;
        double? d = null;
        double? e = 3.14;
        Console.WriteLine(b);                          //null
        Console.WriteLine(b.GetValueOrDefault());      //0
        Console.WriteLine(c);                           
        Console.WriteLine(d);                          //null
        Console.WriteLine(d.GetValueOrDefault());      //0
        Console.WriteLine(e.HasValue);                 //True
        Console.WriteLine(e.GetValueOrDefault());      
    }
}