using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n/2 + 1 ; row++)
        {
            int dots = row;
            int stars = n - 2 * dots;
            Console.Write(new string ('.' , dots));
            Console.Write(new string ('*', stars));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }

        for (int row = n / 2 - 1  ; row >= 0 ; row--)
        {
            int dots = row;
            int stars = n - 2 * dots;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }

    }
}
