using System;

class Program
{
    static void Main()
    {
        int shift = 64;

        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;

        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;

        int roswNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(first);

        int next =  first + second;

        string result = ((char) (second + shift)).ToString() + ((char) (next + shift)).ToString();
        Console.WriteLine(result);
        first = second;
        second = next;

        for (int i = 3; i <= roswNumber; i++)
        {
            next = first + second;
            first = second;
            second = next;
            next = first + second;
            first = second;
            second = next;
            Console.Write((char) (first + shift));
            Console.Write(new string(' ', i - 2));
            Console.WriteLine((char) (second + shift));
            
           

        }

    }
}

