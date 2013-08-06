using System;
using System.Threading;
using System.Globalization;


class Program
{
static void Main()
{
Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
   
decimal num1 = decimal.Parse(Console.ReadLine());
decimal num2 = decimal.Parse(Console.ReadLine());
decimal num3 = decimal.Parse(Console.ReadLine());
decimal num4 = decimal.Parse(Console.ReadLine());
decimal num5 = decimal.Parse(Console.ReadLine());


decimal amount = decimal.Parse(Console.ReadLine());
decimal price = decimal.Parse(Console.ReadLine());

decimal money1 = 0.05m;
decimal money2 = 0.10m;
decimal money3 = 0.20m;
decimal money4 = 0.50m;
decimal money5 = 1.00m;

decimal a = amount;
decimal p = price;

decimal number1 = num1 * money1;
decimal number2 = num2 * money2;
decimal number3 = num3 * money3;
decimal number4 = num4 * money4;
decimal number5 = num5 * money5;

        

decimal sumCoffeMach = (number1 + number2 + number3 + number4 + number5);



     
if ((a > p) && (a-p) < sumCoffeMach)
{
    decimal result = (a - p);
    decimal endResult = sumCoffeMach - result;
    Console.Write("Yes ");
    Console.WriteLine(endResult);
}
 
else if (p > a)
{
    decimal result1 = (p - a);
    Console.Write("More ");
    Console.WriteLine(result1);
}
else if ( (a-p) > sumCoffeMach)
{
    decimal result2 = (a - (sumCoffeMach + p));
    Console.Write("No ");
    Console.WriteLine(result2);
}
 
       
    

}
}