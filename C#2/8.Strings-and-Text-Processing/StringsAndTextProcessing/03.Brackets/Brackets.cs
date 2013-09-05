//Write a program to check if in a given expression the brackets are put correctly.


using System;

class Brackets
{
    static void Main()
    {
        string expr = ")((2+3)/2)(";
        CheckIsTheExpresionIsCorrect(expr);

    }
    static void CheckIsTheExpresionIsCorrect(string expr)
    {
        char[] exprCharArr = expr.ToCharArray();
        int bracket = 0;

        bool res = true;

        for (int i = 0; i < exprCharArr.Length; i++)
        {

            if (exprCharArr[i] == '(')
            {
                bracket++;
            }
            else if (exprCharArr[i] == ')')
            {
                bracket--;
            }
            if (bracket < 0)
            {
                break;
            }
        }
        if (bracket == 0)
        {
            Console.WriteLine("The expresion is correct!");
        }
        else
        {
            Console.WriteLine("The expresion is NOT correct!");
        }
    }
}