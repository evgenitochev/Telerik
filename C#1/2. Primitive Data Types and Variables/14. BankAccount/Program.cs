/* A bank account has a holder name (first name, middle name and last name), 
 available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account.
 Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/


using System;

class DeclareTheVariablesBankAcc
{
    static void Main()
    {
        Console.WriteLine("First name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Middle name: ");
        string middleName = Console.ReadLine();
        Console.WriteLine("Last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your first name is: {0} \n Your middle name is: {1} \n Your last name is: {2}", firstName, middleName, lastName);
        string theNameOfTheBank = "DSK";
        Console.WriteLine("Your bank is {0}", theNameOfTheBank);
        decimal balanceOfMoney = 123;
        Console.WriteLine("Bank balance: {0}lv", balanceOfMoney);
        string iBan = "BGN07F58737003452307671";
        Console.WriteLine("IBAN : {0}", iBan);
        string bicCode = "BIC63472";
        Console.WriteLine("BIC CODE : {0}", bicCode);
        ulong creditCard1 = 9876543219876543;
        Console.WriteLine("Credit Card 1 : {0}", creditCard1);
        ulong creditCard2 = 1234567890123456;
        Console.WriteLine("Credit Card 2: {0}", creditCard2);

    }
}