/*You are given an array of strings. Write a method that sorts the array by the length of its elements
 * (the number of characters composing them).
 */

using System;
using System.Linq;

class StringLenSort
{
    static void Main()
    {
        string[] unsortedStrings = { "a", "aaaaa", "aaaawasdawd", "a", "12355asdf", "wdasdwe" };
        
        foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}
