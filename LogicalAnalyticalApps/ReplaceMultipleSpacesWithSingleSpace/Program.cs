using System;

namespace ReplaceMultipleSpacesWithSingleSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide input string");
            string strInput = Console.ReadLine();
            strInput = string.Join(" ", strInput.Split(' ', StringSplitOptions.RemoveEmptyEntries));            
            Console.WriteLine($"Output after replacing: {strInput}");
            Console.ReadKey();
        }
    }
}
