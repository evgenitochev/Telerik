using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstRow = (n / 2) - 1;

        Console.Write(new string ('.', firstRow )) ;
        Console.Write("##");
        Console.WriteLine(new string ('.', firstRow )) ;


        int middleDots = 2;
        int mDots = n - 2;


        for (int row = (n / 2) - 2; row >= 0; row--)
        {
            int dots = row;
            Console.Write(new string('.', dots));
            Console.Write("#");
            Console.Write(new string('.', middleDots));
            Console.Write("#");
            Console.WriteLine(new string('.', dots));
            middleDots += 2;
        }

        int endDots = 0;


        for (int i = n - 2; i >= n / 2; i = i - 2)
        {

            int miDots = i;
            Console.Write(new string('.', endDots));
            Console.Write("#");
            Console.Write(new string('.', miDots));
            Console.Write("#");
            Console.WriteLine(new string('.', endDots));

            endDots++;
        }

        Console.WriteLine(new string('-', n));

        int slashDots = 0;

        for (int slash = n / 2; slash > 0; slash--)
        {
            int charSlash = slash;
            Console.Write(new string('.', slashDots));
            Console.Write(new string('\\', charSlash));
            Console.Write(new string('/', charSlash));
            Console.WriteLine(new string('.', slashDots));
            slashDots++;

        }

        Console.WriteLine();
        

    }
}
 
