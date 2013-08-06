/* Declare two string variables and assign them with “Hello” and “World”. 
   Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
   Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
  
*/


using System;

class DeclareStringAndObject
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object greeting = word1 + " " + word2;
        string castGreeting = (string)greeting;
        Console.WriteLine("string word1 is: {0}\n string word2 is: {1}\n object greeting is: {2} \n string castGreeting is: {3}", word1, word2, greeting, castGreeting);
    }
}