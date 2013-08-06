//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


using System;

class ThirdDigit
{
    static void Main()
    {
        int number = 1532;
        bool thirdDigitIs7 = (number / 100) % 10 == 7;
        Console.WriteLine(thirdDigitIs7);
    }
}

