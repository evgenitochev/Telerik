/* A marketing firm wants to keep record of its employees. 
   Each record would have the following characteristics – first name, family name, age, gender (m or f),
   ID number, unique employee number (27560000 to 27569999). 
   Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
*/




using System;

class RecordsEmployees
{
    static void Main()
    {
        Console.WriteLine("First name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Family name: ");
        string familyName = Console.ReadLine();
        Console.WriteLine("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Your Gender is (f or m): ");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter your ID number (from 27560000 to 27569999): ");
        int idNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("First name: {0} \n Famyli name: {1} \n Age: {2}", firstName, familyName, age);

        if (gender == 'm')
        {
            Console.WriteLine("Your gender is Male");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Your gender is Female");
        }
        else
        {
            Console.WriteLine("Wrong symbol");
        }

        if (idNumber < 27560000)
        {
            Console.WriteLine("Wrong ID number");
        }
        else if (idNumber > 27569999)
        {
            Console.WriteLine("Wrong ID number");
        }
        else
        {
            Console.WriteLine("ID number: {0}", idNumber);
        }

    }
}