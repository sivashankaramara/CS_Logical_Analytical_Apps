using System;

namespace ReverseWordsInStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a statement");
            string inputLine = Console.ReadLine();
            string[] strArray = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            String[] output = new string[strArray.Length];
            Int32 forward = 0;
            for (Int32 i = strArray.Length - 1; i >= 0; i--)
            {
                output[forward++] = strArray[i];
            }
            Console.WriteLine($"Statement in reverse is: {string.Join(" ", output)}");
            Console.ReadKey();
        }
    }
}
