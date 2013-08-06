/* A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number. 
Write a program that reads the information about a company and its manager and prints them on the console.
*/


using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company's address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company's phone number: ");
        long companyPhone = long.Parse(Console.ReadLine());

        Console.Write("Company fax number: ");
        long companyFax = long.Parse(Console.ReadLine());

        Console.Write("Company's website: ");
        string website = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Manager's age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Manager's phone number: ");
        long managerPhone = long.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Company Name: {0}", companyName);
        Console.WriteLine("Company Address: {0}", companyAddress);
        Console.WriteLine("Company Phone {0}", companyPhone);
        Console.WriteLine("Company Fax {0}", companyFax);
        Console.WriteLine("Company Website {0}", website);
        Console.WriteLine("Manager's first name {0}", firstName);
        Console.WriteLine("Manager's last name {0}", lastName);
        Console.WriteLine("Manager's age {0}", age);
        Console.WriteLine("Manager's Phone {0}", managerPhone);
           
    }
}